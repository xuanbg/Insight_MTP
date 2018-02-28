using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class MainModel : BaseModel
    {
        public MainWindow view = new MainWindow();
        public List<NavBarItemLink> links = new List<NavBarItemLink>();

        private readonly List<object> needOpens = new List<object>();
        private List<Navigation> navItems;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public MainModel()
        {
            // 加载模块数据并初始化导航栏
            InitNavBar();

            // 初始化界面
            view.MyFeel.LookAndFeel.SkinName = Params.lookAndFeel;
            view.Text = "Insight MTP management client";

            view.StbTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            view.StbUser.Caption = Params.userName;
            if (SystemInformation.WorkingArea.Height > 755) return;

            view.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 加载默认启动模块
        /// </summary>
        public void LoadDefault()
        {
            needOpens.ForEach(AddPageMdi);
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

            var mod = navItems.Single(m => m.alias == name.ToString());
            var path = $"{Application.StartupPath}\\{mod.filePath}";
            if (!File.Exists(path))
            {
                var msg = $"对不起，{mod.name}模块无法加载！\r\n未能发现{path}文件。";
                Messages.ShowError(msg);
                return;
            }

            view.Loading.ShowWaitForm();
            var asm = Assembly.LoadFrom(path);
            var start = mod.filePath.LastIndexOf("/", StringComparison.Ordinal);
            if (start < 0) start = 0;

            var end = mod.filePath.LastIndexOf(".", StringComparison.Ordinal);
            var className = mod.filePath.Substring(start, end - start);
            var cont = asm.CreateInstance($"Insight.MTP.Client.{className}.{mod.alias}.Controller", false, BindingFlags.Default, null, new object[]{mod}, CultureInfo.CurrentCulture, null);
            view.Loading.CloseWaitForm();
            if (cont == null)
            {
                var msg = $"对不起，{mod.name}模块无法加载！\r\n您的应用程序中缺少相应组件。";
                Messages.ShowError(msg);
            }
        }

        /// <summary>
        /// 如注销用户失败，弹出询问对话框。
        /// </summary>
        public bool Logout()
        {
            const string msg = "退出应用程序将导致当前未完成的输入内容丢失！\r\n您确定要退出吗？";
            if (!Messages.ShowConfirm(msg)) return true;

            token.DeleteToken();

            return false;
        }

        /// <summary>
        /// 保存当前主题样式到配置文件
        /// </summary>
        public void SaveLookAndFeel()
        {
            Config.SaveLookAndFeel(view.MyFeel.LookAndFeel.SkinName);
        }

        /// <summary>
        /// 初始化导航栏
        /// </summary>
        private void InitNavBar()
        {
            var url = $"{server}/moduleapi/v1.0/navigations";
            var client = new HttpClient<List<Navigation>>(token);
            if (!client.Get(url)) return;

            navItems = client.data.Where(i => i.parentId != null).ToList();
            var groups = client.data.Where(i => i.parentId == null).ToList();
            var height = view.NavMain.Height;
            foreach (var g in groups)
            {
                var expand = false;
                var items = new List<NavBarItemLink>();
                foreach (var item in navItems.Where(i => i.parentId == g.id))
                {
                    if (item.isDefault)
                    {
                        expand = true;
                        needOpens.Add(item.alias);
                    }

                    var icon = Image.FromStream(new MemoryStream(item.icon));
                    var navBarItem = new NavBarItem(item.name) {Tag = item.alias, SmallImage = icon};
                    items.Add(new NavBarItemLink(navBarItem));
                }

                var group = new NavBarGroup
                {
                    Caption = g.name,
                    Name = g.name,
                    SmallImage = Image.FromStream(new MemoryStream(g.icon))
                };
                var count = links.Count + items.Count;
                group.Expanded = groups.Count * 55 + count * 32 < height || expand;
                group.ItemLinks.AddRange(items.ToArray());

                view.NavMain.Groups.Add(group);
                links.AddRange(items);
            }
        }
    }
}
