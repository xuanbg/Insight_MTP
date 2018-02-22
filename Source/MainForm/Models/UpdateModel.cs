using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.MainForm.Models
{
    public class UpdateModel
    {
        public Update View = new Update();
        public bool Restart;

        private List<FileInfo> _Updates;
        private readonly string _Root = Application.StartupPath;

        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateModel()
        {
            View.Shown += (sender, args) => Update();
        }

        /// <summary>
        /// 检查客户端文件更新
        /// </summary>
        /// <returns>int 更新文件数</returns>
        public int CheckUpdate()
        {
            // 读取本地客户端文件信息
            var locals = new List<FileInfo>();
            Util.GetLocalFiles(locals, _Root, ".bak");
            locals.ForEach(f => Util.DeleteFile(f.FullPath));

            locals = new List<FileInfo>();
            Util.GetLocalFiles(locals, _Root, ".exe|.dll|.frl");

            // 根据服务器上文件信息，通过比对版本号得到可更新文件列表
            _Updates = (from sf in GetFiles()
                        let cf = locals.SingleOrDefault(f => f.Name == sf.Name && f.Path == sf.Path)
                        let cv = new Version(cf?.Version ?? "1.0.0")
                        let sv = new Version(sf?.Version ?? "1.0.0")
                        where cf == null || cv < sv
                        select sf).ToList();
            return _Updates.Count;
        }

        /// <summary>
        /// 生成批处理文件
        /// </summary>
        public ProcessStartInfo CreateBat()
        {
            using (var bat = System.IO.File.CreateText("restart.bat"))
            {
                bat.WriteLine(@"start """" ""{0}""", Application.ExecutablePath);
                bat.WriteLine("del /s /q *.bak");
                bat.WriteLine("del %0%");
            }

            return new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = "restart.bat",
                WindowStyle = ProcessWindowStyle.Hidden,
            };
        }

        /// <summary>
        /// 更新文件
        /// </summary>
        private void Update()
        {
            View.Confirm.Enabled = false;
            foreach (var file in _Updates)
            {
                View.Progress.EditValue = $"正在更新：{file.Name}……";
                View.Refresh();
                Thread.Sleep(1000);
                var data = GetFile(file.ID);
                if (data == null) continue;

                var buffer = Convert.FromBase64String(data);
                var bytes = Util.Decompress(buffer);
                Restart = Util.UpdateFile(file, _Root, bytes) || Restart;
            }

            View.Confirm.Enabled = true;
            View.Progress.EditValue = Restart ? "已更新关键文件，需要重新运行客户端程序！" : "更新完成！";
            View.Confirm.Text = Restart ? "重  启" : "关  闭";
            View.Refresh();
        }

        /// <summary>
        /// 获取服务器上的客户端文件版本信息
        /// </summary>
        /// <returns>文件版本信息</returns>
        private List<FileInfo> GetFiles()
        {
            var url = $"{Params.InsightServer}/commonapi/v1.0/files";
            var client = new HttpClient<List<FileInfo>>(Params.Token);
            return client.Get(url) ? client.Data : new List<FileInfo>();
        }

        /// <summary>
        /// 根据文件ID获取更新文件
        /// </summary>
        /// <param name="id">更新文件ID</param>
        /// <returns>Result</returns>
        private string GetFile(string id)
        {
            var url = $"{Params.InsightServer}/commonapi/v1.0/files/{id}";
            var client = new HttpClient<object>(Params.Token);
            return client.Get(url) ? client.Data.ToString() : null;
        }
    }
}
