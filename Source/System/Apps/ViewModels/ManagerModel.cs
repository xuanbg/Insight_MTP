using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Apps.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Setting.Apps.ViewModels
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
            initTree(view.TreNav, "navChanged", "editNav");
            initGrid(view.gdvFunc, "funChanged", "editFunc");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getApps(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            list = result.data;
            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = handle;

            refreshToolBar();
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
            }
            else
            {
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.navigations == null || !item.navigations.Any())
                    {
                        item.navigations = dataModel.getNavs(item.id);
                    }
                }
            }

            view.TreNav.DataSource = item?.navigations;
            if (item?.navigations.Any() ?? false)
            {
                view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
                view.TreNav.ExpandAll();
            }
            else
            {
                nav = null;
            }

            view.grdFunc.DataSource = nav?.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        public void navChanged(TreeListNode node)
        {
            if (node == null)
            {
                nav = null;
                func = null;
            }
            else
            {

                var id = node.GetValue("id").ToString();
                nav = item.navigations.SingleOrDefault(m => m.id == id);
                if (nav == null) return;

                if (node.HasChildren)
                {
                    func = null;
                }
                else if (nav.functions == null)
                {
                    nav.functions = dataModel.getFuncs(nav.id);
                }
            }

            view.grdFunc.DataSource = nav?.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 功能列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void funChanged(int index)
        {
            func = index < 0 ? null : nav.functions[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新树数据
        /// </summary>
        public void refreshTree()
        {
            view.TreNav.RefreshDataSource();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvFunc.RefreshData();
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
                ["newNav"] = item?.autoTenant != null,
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