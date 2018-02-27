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
        private ChangPwModel changPw;
        private LockModel _Lock;
        private PrintModel print;
        private UpdateModel update;
        private AboutModel about;
         
        /// <summary>
        /// 构造函数
        /// </summary>
        public Controller()
        {
            // 构造主窗体并显示
            model = new MainModel();
            var view = model.view;
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
                model.LoadDefault();
                CheckPassword();
            };
            view.Closing += (sender, args) => args.Cancel = model.Logout();
            view.Closed += (sender, args) => Exit();

            // 订阅导航栏点击事件
            model.links.ForEach(i => i.Item.LinkClicked += (sender, args) => model.AddPageMdi(args.Link.Item.Tag));
        }

        /// <summary>
        /// 进入主窗体时检查密码是否需要修改
        /// </summary>
        private void CheckPassword()
        {
            if (!Params.needChangePw) return;
            
            ChangPassword("123456");
        }

        /// <summary>
        /// 点击菜单项：修改密码，弹出修改密码对话框
        /// </summary>
        /// <param name="old">旧密码</param>
        private void ChangPassword(string old = null)
        {
            changPw = new ChangPwModel();
            var view = changPw.view;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                if (!changPw.Save()) return;

                CloseDialog(view);
            };

            changPw.Init(old);
            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：锁定，弹出解锁对话框
        /// </summary>
        private void Lock()
        {
            _Lock = new LockModel();
            var view = _Lock.view;

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

            Params.tokenHelper.DeleteToken();
            Application.Restart();
        }

        /// <summary>
        /// 退出系统前保存当前应用的皮肤
        /// </summary>
        private void Exit()
        {
            model.SaveLookAndFeel();
            Application.Exit();
        }

        /// <summary>
        /// 点击菜单项：打印机设置，打开打印机设置对话框
        /// </summary>
        private void PrintSet()
        {
            print = new PrintModel();
            var view = print.view;

            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                print.Save();
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 点击菜单项：检查更新，如有更新，提示是否更新
        /// </summary>
        private void Update(bool confirm = true)
        {
            update = new UpdateModel();
            var view = update.view;

            view.Confirm.Click += (sender, args) =>
            {
                CloseDialog(view);
                if (!update.restart) return;

                // 运行restart.bat重启应用程序
                Process.Start(update.CreateBat());
                Application.Exit();
            };

            // 检查更新
            var count = update.CheckUpdate();
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
            about = new AboutModel();
            var view = about.view;

            SubCloseEvent(view, true);
            view.ShowDialog();
        }
    }
}
