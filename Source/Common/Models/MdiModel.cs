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
using Insight.MTP.Client.Common.Dialogs;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Models
{
    public class MdiModel<T> where T : BaseMDI, new()
    {
        private const int MinWaitTime = 800;
        private readonly string moduleId;
        private int waits;
        private DateTime wait;
        private GridHitInfo hitInfo = new GridHitInfo();

        public T view;
        public List<BarButtonItem> buttons;

        /// <summary>
        /// 模块参数集合
        /// </summary>
        public List<MemberUser> ModuleParams { get; set; }

        /// <summary>
        /// 构造函数，初始化MDI窗体并显示
        /// </summary>
        /// <param name="info">模块信息</param>
        protected MdiModel(ModuleInfo info)
        {
            moduleId = info.id;
            view = new T
            {
                MdiParent = Application.OpenForms["MainWindow"],
                Icon = Icon.FromHandle(new Bitmap(new MemoryStream(info.Icon)).GetHicon()),
                Name = info.ProgramName,
                Text = info.ApplicationName
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
                           AllowDrawArrow = a.BeginGroup,
                           Caption = a.Alias,
                           Enabled = a.Enable,
                           Name = a.Name,
                           Tag = a.Enable,
                           Glyph = Image.FromStream(new MemoryStream(a.Icon)),
                           PaintStyle = a.ShowText ? BarItemPaintStyle.CaptionGlyph : BarItemPaintStyle.Standard,
                           Visibility = a.Validity ? BarItemVisibility.Always : BarItemVisibility.Never
                       }).ToList();
            buttons.ForEach(i => view.ToolBar.ItemLinks.Add(i, i.AllowDrawArrow));
        }

        /// <summary>
        /// 获取模块功能按钮集合
        /// </summary>
        /// <returns>功能按钮集合</returns>
        private List<ModuleAction> GetActions()
        {
            var url = $"{Params.tokenHelper.baseServer}/moduleapi/v1.0/modules/{moduleId}/actions";
            var client = new HttpClient<List<ModuleAction>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<ModuleAction>();
        }

        /// <summary>
        /// 根据输入的选项ID获取选项值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> GetParameter(string id)
        {
            var pvl = new List<string>();
            if (ModuleParams.Exists(obj => obj.ID == id))
            {
                pvl.AddRange(ModuleParams.FindAll(p => p.ID == id).Select(p => p.Name));
            }
            return pvl;
        }

        /// <summary>
        /// 读取模块选项参数
        /// </summary>
        public void ReadModuleParameter()
        {
            //ModuleParams = Interface.ModuleParam(_ModuleId);
        }

        /// <summary>
        /// 保存模块选项参数
        /// </summary>
        //public void WriteModuleParameter(IEnumerable<SYS_ModuleParam> pams)
        //{
        //    var apl = new List<SYS_ModuleParam>();
        //    var upl = new List<SYS_ModuleParam>();
        //    foreach (var pam in pams)
        //    {
        //        if (!ModuleParams.Exists(p => p.ID == pam.ID)) apl.Add(pam);
        //        if (ModuleParams.Exists(p => p.ID == pam.ID && p.Value != pam.Value)) upl.Add(pam);
        //    }

        //    var result = Interface.SaveModuleParam(apl, upl);
        //    if (!result)
        //    {
        //        Messages.ShowError("保存选项失败！如多次保存失败，请联系管理员。");
        //    }
        //}

        /// <summary>
        /// 新建/编辑分类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isEdit"></param>
        /// <param name="allowEditRoot"></param>
        /// <returns></returns>
        public bool EditCatalog(Guid id, bool isEdit, bool allowEditRoot = false)
        {
            var dig = new Category
            {
                AllowEditRoot = allowEditRoot,
            };
            var result = dig.ShowDialog() == DialogResult.OK;
            dig.Close();
            return result;
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        //public void DeleteCatalog(TreeList tree)
        //{
        //    var fn = tree.FocusedNode;
        //    var msg = $"您确定要删除分类【{fn.GetValue("Name")}】吗？";
        //    if (Messages.ShowConfirm(msg) != DialogResult.OK) return;

        //    var id = fn.GetValue("ID").ToString();
        //    var result = Interface.DeleteCategory(id);
        //    if (!result) return;

        //    tree.DeleteNode(tree.FocusedNode);
        //}

    }
}