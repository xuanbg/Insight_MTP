using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Insight.MTP.Client.Common.BaseForm;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;

namespace Insight.MTP.Client.Common.Models
{
    public class MdiModel<T> where T : BaseMDI, new()
    {
        private const int MinWaitTime = 800;
        private readonly string moduleId;
        private int waits;
        private DateTime wait;
        private GridHitInfo hitInfo = new GridHitInfo();

        public TokenHelper token = Params.tokenHelper;
        public string server = Params.server;
        public T view;
        public List<BarButtonItem> buttons;

        /// <summary>
        /// 构造函数，初始化MDI窗体并显示
        /// </summary>
        /// <param name="info">模块信息</param>
        protected MdiModel(Navigation info)
        {
            moduleId = info.id;
            view = new T
            {
                MdiParent = Application.OpenForms["MainWindow"],
                Icon = Icon.FromHandle(new Bitmap(new MemoryStream(info.icon)).GetHicon()),
                Name = info.alias,
                Text = info.name
            };

            view.Show();
            InitToolBar();
        }

        /// <summary>
        /// 切换工具栏按钮状态
        /// </summary>
        /// <param name="dict"></param>
        public void SwitchItemStatus(Dictionary<string, bool> dict)
        {
            foreach (var obj in dict)
            {
                var item = buttons.Single(b => b.Name == obj.Key);
                item.Enabled = obj.Value && (bool)item.Tag;
            }
        }

        /// <summary>
        /// 是否允许双击
        /// </summary>
        /// <param name="key">操作名称</param>
        /// <returns>是否允许双击</returns>
        public bool AllowDoubleClick(string key)
        {
            var button = buttons.SingleOrDefault(i => i.Name == key);
            return button != null && button.Enabled;
        }

        /// <summary>
        /// 显示等待提示
        /// </summary>
        public void ShowWaitForm()
        {
            waits++;
            if (view.Wait.IsSplashFormVisible) return;

            wait = DateTime.Now;
            view.Wait.ShowWaitForm();
        }

        /// <summary>
        /// 关闭等待提示
        /// </summary>
        public void CloseWaitForm()
        {
            waits--;
            if (waits > 0) return;

            var time = (int) (DateTime.Now - wait).TotalMilliseconds;
            if (time < MinWaitTime) Thread.Sleep(MinWaitTime - time);

            view.Wait.CloseWaitForm();
        }

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <param name="args">MouseEventArgs</param>
        public void MouseDownEvent(GridView gridView, MouseEventArgs args)
        {
            if (args.Button != MouseButtons.Right) return;

            var point = new Point(args.X, args.Y);
            hitInfo = gridView.CalcHitInfo(point);
        }

        /// <summary>
        /// 创建右键菜单并注册事件
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip CreateCopyMenu(GridView gridView)
        {
            var tsmi = new ToolStripMenuItem { Text = "复制" };
            tsmi.Click += (sender, args) =>
            {
                if (hitInfo.Column == null) return;

                var content = gridView.GetRowCellDisplayText(hitInfo.RowHandle, hitInfo.Column);
                if (string.IsNullOrEmpty(content)) return;

                Clipboard.Clear();
                Clipboard.SetData(DataFormats.Text, content);
            };

            var menu = new ContextMenuStrip();
            menu.Items.Add(tsmi);
            return menu;
        }

        /// <summary>
        /// 初始化模块工具栏
        /// </summary>
        private void InitToolBar()
        {
            buttons = (from a in GetActions()
                       select new BarButtonItem
                       {
                           AllowDrawArrow = a.isBegin,
                           Caption = a.name,
                           Enabled = a.permit,
                           Name = a.alias,
                           Tag = a.permit,
                           Glyph = Image.FromStream(new MemoryStream(a.icon)),
                           PaintStyle = a.isShowText ? BarItemPaintStyle.CaptionGlyph : BarItemPaintStyle.Standard,
                       }).ToList();
            buttons.ForEach(i => view.ToolBar.ItemLinks.Add(i, i.AllowDrawArrow));
        }

        /// <summary>
        /// 获取模块功能按钮集合
        /// </summary>
        /// <returns>功能按钮集合</returns>
        private IEnumerable<Function> GetActions()
        {
            var url = $"{Params.server}/moduleapi/v1.0/modules/{moduleId}/functions";
            var client = new HttpClient<List<Function>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<Function>();
        }
    }
}