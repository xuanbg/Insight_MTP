﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Entity;
using DrawFocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle;
using ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility;

namespace Insight.MTP.Client.Common.Utils
{
    public class Format
    {
        private const string AlignCenters = "类型;状态;创建人;操作员;规格;单位;单价;数量;币种;汇率";
        private const string Numerics = "汇率;单价;数量";

        /// <summary>
        /// 格式化GridView样式和属性
        /// </summary>
        /// <param name="view">GridView</param>
        /// <param name="width">指示列宽度（像素，默认36）</param>
        /// <param name="editable">是否可编辑（默认false）</param>
        /// <param name="rowclick">点击行选中（默认true）</param>
        public static void GridFormat(GridView view, int width = 36, bool editable = false, bool rowclick = true)
        {
            if (rowclick)
            {
                view.RowClick -= RowClick;
                view.RowClick += RowClick;
            }

            // 格式化指示列样式
            if (width > 0)
            {
                view.CustomDrawRowIndicator -= CustomDrawRowIndicator;
                view.CustomDrawRowIndicator += CustomDrawRowIndicator;
                view.IndicatorWidth = width;
            }
            else
            {
                view.OptionsView.ShowIndicator = false;
            }

            // 设置列格式
            foreach (GridColumn col in view.Columns)
            {
                var name = col.Caption;
                var keys = AlignCenters.Split(';');
                if (keys.Any(k => name.EndsWith(k))) col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                if (Numerics.Contains(name))
                {
                    col.DisplayFormat.FormatType = FormatType.Numeric;
                    col.DisplayFormat.FormatString = "#,##0.######";
                }

                if (name.EndsWith("金额"))
                {
                    col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
                    col.DisplayFormat.FormatType = FormatType.Numeric;
                    col.DisplayFormat.FormatString = "n";
                }

                if (name.EndsWith("时间"))
                {
                    col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                    col.DisplayFormat.FormatType = FormatType.DateTime;
                    col.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
                }

                if (name.EndsWith("日期"))
                {
                    col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                    col.DisplayFormat.FormatType = FormatType.DateTime;
                    col.DisplayFormat.FormatString = "yyyy-MM-dd";
                }

                col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            }

            // 格式化GridView属性
            view.FocusRectStyle = editable ? DrawFocusRectStyle.CellFocus : DrawFocusRectStyle.RowFullFocus;
            view.OptionsBehavior.Editable = editable;
            view.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDown;
            view.OptionsCustomization.AllowFilter = false;
            view.OptionsCustomization.AllowGroup = false;
            view.OptionsCustomization.AllowSort = false;
            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.EnableAppearanceOddRow = true;
            view.RowHeight = 21;
            view.VertScrollVisibility = ScrollVisibility.Always;
        }

        /// <summary>
        /// 格式化TreeList样式和属性
        /// </summary>
        /// <param name="tree">TreeList</param>
        /// <param name="type"></param>
        /// <param name="showColumns">显示列头</param>
        /// <param name="showIndicator">显示指示列</param>
        public static void TreeFormat(TreeList tree, NodeIconType type = NodeIconType.General, bool showColumns = false, bool showIndicator = false)
        {
            // 使列标题文字居中显示
            foreach (TreeListColumn column in tree.Columns)
            {
                if (column.FieldName == "index") column.SortOrder = SortOrder.Ascending;

                column.OptionsColumn.AllowSort = false;
                column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            }

            // 格式化TreeList属性
            tree.BorderStyle = BorderStyles.NoBorder;
            tree.KeyFieldName = "id";
            tree.ParentFieldName = "parentId";
            tree.OptionsBehavior.Editable = false;
            tree.OptionsView.ShowColumns = showColumns;
            tree.OptionsView.ShowIndicator = showIndicator;
            tree.OptionsView.ShowHorzLines = false;
            tree.OptionsView.ShowVertLines = false;
            tree.RowHeight = 23;
            tree.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;

            CustomDrawNodeImages(tree, type);
        }


        /// <summary>
        /// 初始化LookUpEdit
        /// </summary>
        /// <param name="control">LookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        /// <param name="index">选中项索引，默认不选中</param>
        public static void InitComboBoxEdit(ComboBoxEdit control, List<LookUpMember> list, int index = -1)
        {
            control.Properties.ImmediatePopup = true;
            control.Properties.PopupFormMinSize = new Size(60, 0);
            control.Properties.Items.Clear();
            if (list == null) return;

            foreach (var i in list)
            {
                var item = new ImageComboBoxItem { Value = i.name };
                control.Properties.Items.Add(item);
            }

            control.SelectedIndex = index;
        }

        /// <summary>
        /// 初始化LookUpEdit
        /// </summary>
        /// <param name="control">LookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        public static void InitComboBoxEdit(RepositoryItemComboBox control, List<LookUpMember> list)
        {
            control.ImmediatePopup = true;
            control.PopupFormMinSize = new Size(60, 0);
            control.Items.Clear();
            if (list == null) return;

            foreach (var i in list)
            {
                var item = new ImageComboBoxItem { Value = i.name };
                control.Items.Add(item);
            }
        }

        /// <summary>
        /// 初始化LookUpEdit
        /// </summary>
        /// <param name="control">LookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        public static void InitLookUpEdit(LookUpEdit control, List<LookUpMember> list)
        {
            control.Properties.ShowHeader = false;
            control.Properties.ShowFooter = false;
            control.Properties.DataSource = list;
            control.Properties.DisplayMember = "name";
            control.Properties.ValueMember = "id";
            control.Properties.Columns.Add(new LookUpColumnInfo(control.Properties.DisplayMember));
            control.Properties.PopupFormMinSize = new Size(60, 0);
        }

        /// <summary>
        /// 初始化RepositoryItemLookUpEdit
        /// </summary>
        /// <param name="control">RepositoryItemLookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        public static void InitLookUpEdit(RepositoryItemLookUpEdit control, List<LookUpMember> list)
        {
            control.ShowHeader = false;
            control.ShowFooter = false;
            control.DataSource = list;
            control.DisplayMember = "name";
            control.ValueMember = "id";
            control.Columns.Add(new LookUpColumnInfo(control.DisplayMember));
            control.PopupFormMinSize = new Size(60, 0);
        }

        /// <summary>
        /// 初始化GridLookUpEdit
        /// </summary>
        /// <param name="control">GridLookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        public static void InitGridLookUpEdit(GridLookUpEdit control, List<LookUpMember> list)
        {
            control.Properties.DataSource = list;
            control.Properties.DisplayMember = "name";
            control.Properties.ValueMember = "id";
            control.Properties.PopulateViewColumns();
            control.Properties.PopupFormMinSize = new Size(60, 0);
            GridFormat(control.Properties.View);
        }

        /// <summary>
        /// 初始化SearchLookUpEdit
        /// </summary>
        /// <param name="control">SearchLookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        public static void InitSearchLookUpEdit(SearchLookUpEdit control, List<LookUpMember> list)
        {
            control.Properties.DataSource = list;
            control.Properties.DisplayMember = "name";
            control.Properties.ValueMember = "id";
            control.Properties.PopulateViewColumns();
            GridFormat(control.Properties.View);
        }

        /// <summary>
        /// 初始化TreeListLookUpEdit
        /// </summary>
        /// <param name="control">TreeListLookUpEdit</param>
        /// <param name="list">MemberSelect集合</param>
        /// <param name="type">图标类型</param>
        public static void InitTreeListLookUpEdit(TreeListLookUpEdit control, List<TreeLookUpMember> list, NodeIconType type = NodeIconType.General)
        {
            control.Properties.DataSource = list;
            control.Properties.DisplayMember = "name";
            control.Properties.ValueMember = "id";
            control.Properties.PopupFormMinSize = new Size(60, 0);
            control.Properties.TreeList.ParentFieldName = "parentId";

            TreeFormat(control.Properties.TreeList, type);
        }

        /// <summary>
        /// 注册TreeList控件重绘节点图标事件
        /// </summary>
        /// <param name="tree">TreeList</param>
        /// <param name="type">图标类型</param>
        private static void CustomDrawNodeImages(TreeList tree, NodeIconType type)
        {
            tree.CustomDrawNodeImages += (sender, args) =>
            {
                switch (type)
                {
                    case NodeIconType.General:
                        var node = args.Node;
                        args.SelectImageIndex = node.Level == 0 || node.HasChildren ? (node.Expanded ? 2 : 1) : 0;
                        break;
                    case NodeIconType.Category:
                        args.SelectImageIndex = args.Node.Expanded ? 2 : 1;
                        break;
                    case NodeIconType.NodeType:
                        args.SelectImageIndex = (int)args.Node.GetValue("nodeType");
                        break;
                    case NodeIconType.Organization:
                        args.SelectImageIndex = (int) args.Node.GetValue("nodeType") - 1;
                        break;
                    case NodeIconType.OnlyLevel0:
                        if (args.Node.Level > 0) return;

                        args.SelectImageIndex = (int) args.Node.GetValue("nodeType");
                        break;
                    case NodeIconType.Custom:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            };
        }

        /// <summary>
        /// 为GridView生成行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            if (e.Info.IsRowIndicator && e.RowHandle > -1000)
            {
                e.Info.DisplayText = e.RowHandle >= 0 ? (e.RowHandle + 1).ToString() : "G" + e.RowHandle;
            }
        }

        /// <summary>
        /// 实现行点击选中/取消选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void RowClick(object sender, RowClickEventArgs e)
        {
            var view = (GridView)sender;
            if (e.X <= view.IndicatorWidth + view.OptionsSelection.CheckBoxSelectorColumnWidth) return;

            if (view.IsRowSelected(e.RowHandle))
            {
                view.UnselectRow(e.RowHandle);
            }
            else
            {
                view.SelectRow(e.RowHandle);
            }
        }
    }
}
