using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class MainModel
    {
        public MainWindow View = new MainWindow();
        public List<NavBarItemLink> Links = new List<NavBarItemLink>();
        public List<object> NeedOpens = new List<object>();

        private List<ModuleInfo> _NavItems;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public MainModel()
        {
            // 加载模块数据并初始化导航栏
            InitNavBar();

            // 初始化界面
            FastReport.Utils.Res.LoadLocale("Components\\Chinese (Simplified).frl");
            View.MyFeel.LookAndFeel.SkinName = Params.LookAndFeel;

            View.StbTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            View.StbDept.Caption = Params.DeptName;
            View.StbDept.Visibility = string.IsNullOrEmpty(Params.DeptName) ? BarItemVisibility.Never : BarItemVisibility.Always;
            View.StbUser.Caption = Params.Token.Token.userName;
            View.StbServer.Caption = Params.InsightServer;
            if (SystemInformation.WorkingArea.Height > 755) return;

            View.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 打开MDI子窗体
        /// </summary>
        /// <param name="name"></param>
        public void AddPageMdi(object name)
        {
            var form = Application.OpenForms[name.ToString()];
            if (form != null)
            {
                form.Activate();
                return;
            }

            var mod = _NavItems.Single(m => m.ProgramName == name.ToString());
            var path = $"{Application.StartupPath}\\{mod.Location}";
            if (!File.Exists(path))
            {
                var msg = $"对不起，{mod.ApplicationName}模块无法加载！\r\n未能发现{path}文件。";
                Messages.ShowError(msg);
                return;
            }

            View.Loading.ShowWaitForm();
            var asm = Assembly.LoadFrom(path);
            var cont = asm.CreateInstance($"{mod.NameSpace}.Controller", false, BindingFlags.Default, null, new object[]{mod}, CultureInfo.CurrentCulture, null);
            if (cont == null)
            {
                var msg = $"对不起，{mod.ApplicationName}模块无法加载！\r\n您的应用程序中缺少{mod.ApplicationName}组件。";
                Messages.ShowError(msg);
            }

            View.Loading.CloseWaitForm();
        }

        /// <summary>
        /// 如注销用户失败，弹出询问对话框。
        /// </summary>
        public bool Logout()
        {
            var msg = "退出应用程序将导致当前未完成的输入内容丢失！\r\n您确定要退出吗？";
            if (!Messages.ShowConfirm(msg)) return true;

            var url = $"{Params.Token.BaseServer}/securityapi/v1.0/tokens";
            var client = new HttpClient<object>(Params.Token);
            if (client.Delete(url)) return false;

            msg = "用户注销失败！是否强制退出系统？";
            return !Messages.ShowConfirm(msg);
        }

        /// <summary>
        /// 保存当前主题样式到配置文件
        /// </summary>
        public void SaveLookAndFeel()
        {
            Config.SaveLookAndFeel(View.MyFeel.LookAndFeel.SkinName);
        }

        /// <summary>
        /// 初始化导航栏
        /// </summary>
        private void InitNavBar()
        {
            var url = $"{Params.Token.BaseServer}/moduleapi/v1.0/navigations";
            var client = new HttpClient<NavData>(Params.Token);
            if (!client.Get(url)) return;

            _NavItems = client.Data.Modules;

            var height = View.NavMain.Height;
            foreach (var g in client.Data.Groups)
            {
                var expand = false;
                var items = new List<NavBarItemLink>();
                foreach (var item in _NavItems.Where(i => i.ModuleGroupId == g.ID))
                {
                    if (item.Default)
                    {
                        expand = true;
                        NeedOpens.Add(item.ProgramName);
                    }

                    var icon = Image.FromStream(new MemoryStream(item.Icon));
                    var n = new NavBarItem(item.ApplicationName) {Tag = item.ProgramName, SmallImage = icon};
                    items.Add(new NavBarItemLink(n));
                }

                var group = new NavBarGroup
                {
                    Caption = g.Name,
                    Name = g.ID.ToString(),
                    SmallImage = Image.FromStream(new MemoryStream(g.Icon))
                };
                var count = Links.Count + items.Count;
                group.Expanded = client.Data.Groups.Count * 55 + count * 32 < height || expand;
                group.ItemLinks.AddRange(items.ToArray());

                View.NavMain.Groups.Add(group);
                Links.AddRange(items);
            }
        }
    }
}
