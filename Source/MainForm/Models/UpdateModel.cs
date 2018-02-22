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
        public Update view = new Update();
        public bool restart;

        private List<FileInfo> updates;
        private readonly string root = Application.StartupPath;

        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateModel()
        {
            view.Shown += (sender, args) => Update();
        }

        /// <summary>
        /// 检查客户端文件更新
        /// </summary>
        /// <returns>int 更新文件数</returns>
        public int CheckUpdate()
        {
            // 读取本地客户端文件信息
            var locals = new List<FileInfo>();
            Util.GetLocalFiles(locals, root, ".bak");
            locals.ForEach(f => Util.DeleteFile(f.fullPath));

            locals = new List<FileInfo>();
            Util.GetLocalFiles(locals, root, ".exe|.dll|.frl");

            // 根据服务器上文件信息，通过比对版本号得到可更新文件列表
            updates = (from sf in GetFiles()
                        let cf = locals.SingleOrDefault(f => f.name == sf.name && f.path == sf.path)
                        let cv = new Version(cf?.version ?? "1.0.0")
                        let sv = new Version(sf?.version ?? "1.0.0")
                        where cf == null || cv < sv
                        select sf).ToList();
            return updates.Count;
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
            view.Confirm.Enabled = false;
            foreach (var file in updates)
            {
                view.Progress.EditValue = $"正在更新：{file.name}……";
                view.Refresh();
                Thread.Sleep(1000);
                var data = GetFile(file.id);
                if (data == null) continue;

                var buffer = Convert.FromBase64String(data);
                var bytes = Util.Decompress(buffer);
                restart = Util.UpdateFile(file, root, bytes) || restart;
            }

            view.Confirm.Enabled = true;
            view.Progress.EditValue = restart ? "已更新关键文件，需要重新运行客户端程序！" : "更新完成！";
            view.Confirm.Text = restart ? "重  启" : "关  闭";
            view.Refresh();
        }

        /// <summary>
        /// 获取服务器上的客户端文件版本信息
        /// </summary>
        /// <returns>文件版本信息</returns>
        private List<FileInfo> GetFiles()
        {
            var url = $"{Params.tokenHelper.baseServer}/commonapi/v1.0/files";
            var client = new HttpClient<List<FileInfo>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<FileInfo>();
        }

        /// <summary>
        /// 根据文件ID获取更新文件
        /// </summary>
        /// <param name="id">更新文件ID</param>
        /// <returns>Result</returns>
        private string GetFile(string id)
        {
            var url = $"{Params.tokenHelper.baseServer}/commonapi/v1.0/files/{id}";
            var client = new HttpClient<object>(Params.tokenHelper);
            return client.Get(url) ? client.data.ToString() : null;
        }
    }
}
