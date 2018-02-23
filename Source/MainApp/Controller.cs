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
            model = new LoginModel();
            var view = model.login;
            view.LoginButton.Click += (sender, args) => UserLogin();
            view.SetButton.Click += (sender, args) => ConfigServer();
            view.CloseButton.Click += (sender, args) => Application.Exit();

            // 显示登录界面
            view.Show();
            view.Refresh();

            InitParams();
            model.InitUserName();
        }

        /// <summary>
        /// 初始化全局参数
        /// </summary>
        private static void InitParams()
        {
            Params.lookAndFeel = Config.LookAndFeel();
            Params.docPrint = Config.Printer("DocPrint");
            Params.tagPrint = Config.Printer("TagPrint");
            Params.bilPrint = Config.Printer("BilPrint");
            Params.isMergerPrint = Config.IsMergerPrint();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        private void UserLogin()
        {
            if (!model.Login()) return;

            // 显示等待界面
            var waiting = new WaitingModel();
            var view = waiting.View;
            view.Show();
            view.Refresh();


            // 关闭登录对话框，进入主窗体
            model.login.Close();
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
            var set = new SetModel();
            var view = set.View;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                model.InitUserName();
                set.Save();

                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}
