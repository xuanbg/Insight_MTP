using System.Diagnostics;
using System.Windows.Forms;
using Insight.MTP.Client.MainForm.Views;

namespace Insight.MTP.Client.MainForm.Models
{
    public class AboutModel
    {
        public About View = new About();

        /// <summary>
        /// 构造函数，初始化视图
        /// </summary>
        public AboutModel()
        {
            // 显示文件版本信息
            var fileVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            View.labProduct.Text = fileVersion.ProductName;
            View.labVer.Text = fileVersion.FileVersion;
            View.labDev.Text = fileVersion.CompanyName;
        }
    }
}