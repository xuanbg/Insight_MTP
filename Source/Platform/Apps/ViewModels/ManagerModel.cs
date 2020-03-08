using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Apps.ViewModels
{
    public class ManagerModel : BaseMdiModel<App, Manager, DataModel>
    {
        public Navigation nav;
        public Function func;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            init(view.gdvApp, "editApp", view.pccApp, view.KeyInput, view.Search);

            view.TreNav.DoubleClick += (sender, args) => callback("editNav");
            view.TreNav.FocusedNodeChanged += (sender, args) => navChanged(args.Node);
            Format.treeFormat(view.TreNav);

            view.gdvFunc.DoubleClick += (sender, args) => callback("editFun");
            view.gdvFunc.FocusedRowObjectChanged += (sender, args) => funChanged(args.FocusedRowHandle);
            Format.gridFormat(view.gdvFunc);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getApps(keyWord, tab.page, tab.size);
            list = result.data;
            closeWaitForm();

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = handle;
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
                nav = null;
                func = null;
                view.grdFunc.DataSource = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                handle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.navs == null)
                    {
                        item.navs = dataModel.getNavs(item.id);
                    }
                }
            }

            view.TreNav.DataSource = item?.navs;
            if (item?.navs.Any() ?? false)
            {
                view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
                view.TreNav.ExpandAll();
            }

            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        private void navChanged(TreeListNode node)
        {
            var id = node.GetValue("id").ToString();
            nav = item.navs.SingleOrDefault(m => m.id == id);
            if (nav == null) return;

            if (node.HasChildren)
            {
                func = null;
            }
            else if (nav.functions == null)
            {
                nav.functions = dataModel.getFuncs(nav.id);
            }

            view.grdFunc.DataSource = nav.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 功能列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void funChanged(int index)
        {
            func = index < 0 ? null : nav.functions[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editApp"] = item != null,
                ["deleteApp"] = item != null,
                ["newNav"] = item != null && (nav == null || nav.type == 1),
                ["editNav"] = nav != null,
                ["deleteNav"] = nav != null,
                ["newFunc"] = nav != null && nav.type == 2,
                ["editFunc"] = func != null,
                ["deleteFunc"] = func != null,
            };
            switchItemStatus(dict);
        }
    }
}