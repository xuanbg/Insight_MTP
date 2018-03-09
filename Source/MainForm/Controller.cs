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
        private AboutModel about;
         
        /// <summary>
        /// 构造函数
        /// </summary>
        public Controller()
        {
            // 构造主窗体并显示
            manage = new MainModel();
            var view = manage.view;
            view.Show();
            view.Refresh();

            // 订阅主窗体菜单事件
            view.MubChangPassWord.ItemClick += (sender, args) => ChangPassword();
            view.MubLock.ItemClick += (sender, args) => Lock();
            view.MubLogout.ItemClick += (sender, args) => Logout();
            view.MubExit.ItemClick += (sender, args) => view.Close();

            view.MubAbout.ItemClick += (sender, args) => About();

            // 订阅主窗体事件
            view.Shown += (sender, args) =>
            {
                manage.LoadDefault();
                CheckPassword();
            };
            view.Closing += (sender, args) => args.Cancel = manage.Logout();
            view.Closed += (sender, args) => Exit();

            // 订阅导航栏点击事件
            manage.links.ForEach(i => i.Item.LinkClicked += (sender, args) => manage.AddPageMdi(args.Link.Item.Tag));
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
        private static void Logout()
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
            manage.SaveLookAndFeel();
            Application.Exit();
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
