using System.Diagnostics;
using System.Windows.Forms;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Models;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm
{
    public class Controller : BaseController<MainModel>
    {
        private ChangPwModel _ChangPw;
        private LockModel _Lock;
        private PrintModel _Print;
        private UpdateModel _Update;
        private AboutModel _About;
         
        /// <summary>
        /// 构造函数
        /// </summary>
        public Controller()
        {
            // 构造主窗体并显示
            Model = new MainModel();
            var view = Model.View;
            view.Show();
            view.Refresh();

            // 订阅主窗体菜单事件
            view.MubChangPassWord.ItemClick += (sender, args) => ChangPassword();
            view.MubLock.ItemClick += (sender, args) => Lock();
            view.MubLogout.ItemClick += (sender, args) => Logout();
            view.MubExit.ItemClick += (sender, args) => view.Close();

            view.MubPrintSet.ItemClick += (sender, args) => PrintSet();
            view.MubUpdate.ItemClick += (sender, args) => Update();
            view.MubAbout.ItemClick += (sender, args) => About();

            // 订阅主窗体事件
            view.Shown += (sender, args) =>
            {
                Model.NeedOpens.ForEach(Model.AddPageMdi);
                CheckPassword();
                Update(false);
            };
            view.Closing += (sender, args) => args.Cancel = Model.Logout();
            view.Closed += (sender, args) => Exit();

            // 订阅导航栏点击事件
            Model.Links.ForEach(i => i.Item.LinkClicked += (sender, args) => Model.AddPageMdi(args.Link.Item.Tag));
        }

        /// <summary>
        /// 进入主窗体时检查密码是否需要修改
        /// </summary>
        private void CheckPassword()
        {
            if (!Params.NeedChangePW) return;
            
            ChangPassword();
        }

        /// <summary>
        /// 点击菜单项：修改密码，弹出修改密码对话框
        /// </summary>
        private void ChangPassword()
        {
            _ChangPw = new ChangPwModel();
            var view = _ChangPw.View;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                if (!_ChangPw.Save()) return;

                CloseDialog(view);
            };

            _ChangPw.Init();
            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：锁定，弹出解锁对话框
        /// </summary>
        private void Lock()
        {
            _Lock = new LockModel();
            var view = _Lock.View;

            view.Confirm.Click += (sender, args) =>
            {
                if (!_Lock.Unlock()) return;

                CloseDialog(view);
            };

            _Lock.Init();
            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：注销，弹出询问对话框，确认注销后重启应用程序
        /// </summary>
        private void Logout()
        {
            const string msg = "注销用户将导致当前未完成的输入内容丢失！\r\n您确定要注销吗？";
            if (!Messages.ShowConfirm(msg)) return;

            Application.Restart();
        }

        /// <summary>
        /// 退出系统前保存当前应用的皮肤
        /// </summary>
        private void Exit()
        {
            Model.SaveLookAndFeel();
            Application.Exit();
        }

        /// <summary>
        /// 点击菜单项：打印机设置，打开打印机设置对话框
        /// </summary>
        private void PrintSet()
        {
            _Print = new PrintModel();
            var view = _Print.View;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                _Print.Save();
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：检查更新，如有更新，提示是否更新
        /// </summary>
        private void Update(bool confirm = true)
        {
            _Update = new UpdateModel();
            var view = _Update.View;

            view.Confirm.Click += (sender, args) =>
            {
                CloseDialog(view);
                if (!_Update.Restart) return;

                // 运行restart.bat重启应用程序
                Process.Start(_Update.CreateBat());
                Application.Exit();
            };

            // 检查更新
            var count = _Update.CheckUpdate();
            if (count == 0)
            {
                if (confirm) Messages.ShowMessage("当前无可用更新！");
                return;
            }

            var msg = $"当前有 {count} 个文件需要更新，是否立即更新？";
            if (confirm && !Messages.ShowConfirm(msg)) return;

            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：关于，打开关于对话框
        /// </summary>
        private void About()
        {
            _About = new AboutModel();
            var view = _About.View;

            SubCloseEvent(view, true);
            view.ShowDialog();
        }
    }
}
