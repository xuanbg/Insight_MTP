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
        private readonly Guid _ModuleId;
        private readonly int _MinWaitTime = 800;
        private int _Waits;
        private DateTime _Wait;
        private GridHitInfo _HitInfo = new GridHitInfo();

        public T View;
        public List<BarButtonItem> Buttons;

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
            _ModuleId = info.ID;
            View = new T
            {
                MdiParent = Application.OpenForms["MainWindow"],
                Icon = Icon.FromHandle(new Bitmap(new MemoryStream(info.Icon)).GetHicon()),
                Name = info.ProgramName,
                Text = info.ApplicationName
            };

            View.Show();
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
                var item = Buttons.Single(b => b.Name == obj.Key);
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
            var button = Buttons.SingleOrDefault(i => i.Name == key);
            return button != null && button.Enabled;
        }

        /// <summary>
        /// 显示等待提示
        /// </summary>
        public void ShowWaitForm()
        {
            _Waits++;
            if (View.Wait.IsSplashFormVisible) return;

            _Wait = DateTime.Now;
            View.Wait.ShowWaitForm();
        }

        /// <summary>
        /// 关闭等待提示
        /// </summary>
        public void CloseWaitForm()
        {
            _Waits--;
            if (_Waits > 0) return;

            var time = (int) (DateTime.Now - _Wait).TotalMilliseconds;
            if (time < _MinWaitTime) Thread.Sleep(_MinWaitTime - time);

            View.Wait.CloseWaitForm();
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
            _HitInfo = gridView.CalcHitInfo(point);
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
                if (_HitInfo.Column == null) return;

                var content = gridView.GetRowCellDisplayText(_HitInfo.RowHandle, _HitInfo.Column);
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
            Buttons = (from a in GetActions()
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
            Buttons.ForEach(i => View.ToolBar.ItemLinks.Add(i, i.AllowDrawArrow));
        }

        /// <summary>
        /// 获取模块功能按钮集合
        /// </summary>
        /// <returns>功能按钮集合</returns>
        private List<ModuleAction> GetActions()
        {
            var url = $"{Params.Token.BaseServer}/moduleapi/v1.0/modules/{_ModuleId}/actions";
            var client = new HttpClient<List<ModuleAction>>(Params.Token);
            return client.Get(url) ? client.Data : new List<ModuleAction>();
        }

        /// <summary>
        /// 根据输入的选项ID获取选项值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> GetParameter(string id)
        {
            var pid = Guid.Parse(id);
            var pvl = new List<string>();
            if (ModuleParams.Exists(obj => obj.ID == pid))
            {
                pvl.AddRange(ModuleParams.FindAll(p => p.ID == pid).Select(p => p.Name));
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

        /// <summary>
        /// 使用指定的模板打印数据
        /// </summary>
        /// <param name="oid">数据对象ID</param>
        /// <param name="tid">模板ID</param>
        /// <param name="printer">打印机名称</param>
        /// <param name="obj">ImageData对象实体</param>
        /// <param name="onSheet">合并打印模式</param>
        public string PrintImage(Guid oid, Guid? tid, string printer = null, ImageData obj = null,
            PagesOnSheet onSheet = PagesOnSheet.One)
        {
            var print = BuildReport(oid, tid, obj);
            if (print == null) return null;

            if (onSheet != PagesOnSheet.One)
            {
                print.PrintSettings.PrintMode = PrintMode.Scale;
                print.PrintSettings.PagesOnSheet = onSheet;
            }

            if (!string.IsNullOrEmpty(printer))
            {
                print.PrintSettings.ShowDialog = false;
                print.PrintSettings.Printer = printer;
            }
            print.PrintPrepared();
            return print.FileName;
        }

        /// <summary>
        /// 使用指定的模板预览数据
        /// </summary>
        /// <param name="oid">数据对象ID</param>
        /// <param name="tid">模板ID</param>
        public void PreviewImage(Guid oid, Guid? tid)
        {
            var print = BuildReport(oid, tid);

            print?.ShowPrepared(true);
        }


        private FastReport.Report BuildReport(Guid oid, Guid? tid, ImageData obj = null)
        {
            var isCopy = false;
            ImageData img = new ImageData();
            if (tid == null || tid == Guid.Empty)
            {
                isCopy = true;
                //img = new ImageData();
                if (img == null)
                {
                    Messages.ShowError("尚未设置打印模板！请先在设置对话框中设置正确的模板。");
                    return null;
                }
            }
            else
            {
                //img = Interface.BuildImageData(oid, (Guid) tid, obj);
            }

            var print = new FastReport.Report { FileName = img.ID.ToString()};
            print.LoadPrepared(new MemoryStream(img.Image));

            if (isCopy) ImageHelper.AddWatermark(print, "副 本");
            return print;
        }

    }
}