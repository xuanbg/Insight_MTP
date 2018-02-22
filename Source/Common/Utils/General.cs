using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using FastReport;
using Insight.WS.Client.Common.Entity;
using Insight.WS.Client.Common.Util;

namespace Insight.WS.Client.Common
{

    public class General
    {

        /// <summary>
        /// 获取CPU序列号
        /// </summary>
        /// <returns>String 序列号</returns>
        public static string GetCpuId()
        {
            var myCpu = new ManagementClass("win32_Processor").GetInstances();
            return (from ManagementObject cpu in myCpu select cpu.Properties["Processorid"].Value).Aggregate("", (current, val) => current + (val?.ToString() ?? ""));
        }

        /// <summary>
        /// 获取主板序列号
        /// </summary>
        /// <returns>String 序列号</returns>
        public static string GetMbId()
        {
            var myMb = new ManagementClass("Win32_BaseBoard").GetInstances();
            return (from ManagementObject mb in myMb select mb.Properties["SerialNumber"].Value).Aggregate("", (current, val) => current + (val?.ToString() ?? ""));
        }

        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        /// <returns>String 序列号</returns>
        public static string GetHdId()
        {
            var lpm = new ManagementClass("Win32_PhysicalMedia").GetInstances();
            return (from ManagementObject hd in lpm select hd.Properties["SerialNumber"].Value).Aggregate("", (current, val) => current + (val?.ToString().Trim() ?? ""));
        }

        /// <summary>
        /// 增加水印
        /// </summary>
        /// <param name="fr">Report对象实体</param>
        /// <param name="str">水印文字</param>
        /// <param name="size"></param>
        /// <returns>Report对象实体</returns>
        public static void AddWatermark(Report fr, string str, int size = 72)
        {
            var wm = new Watermark
            {
                Enabled = true,
                Text = str,
                Font = new Font("宋体", size, FontStyle.Bold)
            };

            for (var i = 0; i < fr.PreparedPages.Count; i++)
            {
                var pag = fr.PreparedPages.GetPage(i);
                pag.Watermark = wm;
                fr.PreparedPages.ModifyPage(i, pag);
            }
        }

        /// <summary>
        /// Image 转换为 byte[]数组
        /// </summary>
        /// <param name="img">图片</param>
        /// <returns>byte[] 数组</returns>
        public static byte[] ImageToByteArray(Image img)
        {
            if (img == null)
                return null;

            using (var ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 获取图片缩略图
        /// </summary>
        /// <param name="img">原图片</param>
        /// <returns>Image 缩略图</returns>
        public static Image GetThumbnail(Image img)
        {
            if (img == null) return null;

            var callb = new Image.GetThumbnailImageAbort(Callback);
            return img.GetThumbnailImage(120, 150, callb, IntPtr.Zero);
        }

        private static bool Callback()
        {
            return false;
        }

        /// <summary>
        /// 将打开的本地文档转换成电子影像
        /// </summary>
        /// <param name="slv">附件涉密等级</param>
        /// <param name="type">附件类型（默认0：附件）</param>
        /// <returns>ImageData List 电子影像对象集合</returns>
        public static List<ImageData> AddFiles(Guid? slv, int type = 0)
        {
            var imgs = new List<ImageData>();
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() != DialogResult.OK) return null;

                var array = dialog.FileNames;
                foreach (var fileName in array)
                {
                    var fs = new FileStream(fileName, FileMode.Open);
                    var br = new BinaryReader(fs);
                    var bf = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    var img = new ImageData
                    {
                        ID = Guid.NewGuid(),
                        ImageType = type,
                        Name = Path.GetFileNameWithoutExtension(fileName),
                        Expand = Path.GetExtension(fileName),
                        SecrecyDegree = slv,
                        Size = bf.LongLength,
                        Image = bf,
                        CreatorDeptId = Utils.Session.DeptId,
                        CreatorUserId = Utils.Session.UserId
                    };
                    imgs.Add(img);
                }
            }
            return imgs;
        }

        /// <summary>
        /// 根据ID获取ImageData对象实体
        /// </summary>
        /// <param name="id">电子影像ID</param>
        /// <returns>ImageData 电子影像对象实体</returns>
        public static void OpenAttach(Guid id)
        {
            var img = Interface.ImageData(id);
            var fn = img.Name + img.ID.ToString().Substring(23) + img.Expand;
            SaveFile(img.Image, fn);
        }

        /// <summary>
        /// 保存文件并打开
        /// </summary>
        /// <param name="file">文件内容</param>
        /// <param name="name">文件名</param>
        public static void SaveFile(byte[] file, string name)
        {
            var path = Path.GetTempPath() + name;
            if (!File.Exists(path))
            {
                var bw = new BinaryWriter(File.Create(path));
                bw.Write(file);
                bw.Flush();
                bw.Close();
            }
            Process.Start(path);
        }
    }
}
