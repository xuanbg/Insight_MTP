using System.Threading;
using System.Windows.Forms;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainApp.Models;

namespace Insight.MTP.Client.MainApp
{
    public class Controller : BaseController<LoginModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Controller()
        {
            // 构造登录Model并订阅登录窗体事件
            Model = new LoginModel();
            var view = Model.View;
            view.LoginButton.Click += (sender, args) => UserLogin();
            view.SetButton.Click += (sender, args) => ConfigServer();
            view.CloseButton.Click += (sender, args) => Application.Exit();

            // 显示登录界面
            view.Show();
            view.Refresh();

            InitParams();
            Model.Test();
            if (!Model.TestPass) ConfigServer();

            Model.InitUserName();
        }

        /// <summary>
        /// 初始化全局参数
        /// </summary>
        private void InitParams()
        {
            Params.LookAndFeel = Config.LookAndFeel();

            Params.DocPrint = Config.Printer("DocPrint");
            Params.TagPrint = Config.Printer("TagPrint");
            Params.BilPrint = Config.Printer("BilPrint");
            Params.IsMergerPrint = Config.IsMergerPrint();

            Params.InsightServer = Config.Address();
            Params.Token.BaseServer = Config.BaseAddress();
            Params.Token.Account = "5A3E41525B289CF0FC160E411F9B5188";
            Params.Token.Signature("0382F334BDE049519A4CDDE0A67C0821");
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        private void UserLogin()
        {
            if (!Model.Login()) return;

            // 显示等待界面
            var model = new WaitingModel();
            var view = model.View;
            view.Show();
            view.Refresh();

            // 关闭登录对话框，进入主窗体
            Model.View.Close();
            // ReSharper disable once UnusedVariable
            var controller = new MainForm.Controller();

            // 关闭等待界面
            Thread.Sleep(1000);
            view.Close();
        }

        /// <summary>
        /// 修改服务器配置
        /// </summary>
        private void ConfigServer()
        {
            var model = new SetModel();
            var view = model.View;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                Model.Test();
                if (!Model.TestPass) return;

                Model.InitUserName();
                model.Save();

                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}
