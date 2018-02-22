using System.Diagnostics;
using System.Windows.Forms;
using Insight.MTP.Client.MainForm.Views;

namespace Insight.MTP.Client.MainForm.Models
{
    public class AboutModel
    {
        public About view = new About();

        /// <summary>
        /// 构造函数，初始化视图
        /// </summary>
        public AboutModel()
        {
            // 显示文件版本信息
            var fileVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            view.labProduct.Text = fileVersion.ProductName;
            view.labVer.Text = fileVersion.FileVersion;
            view.labDev.Text = fileVersion.CompanyName;
        }
    }
}