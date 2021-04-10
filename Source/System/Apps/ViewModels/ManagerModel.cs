using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Apps.Views;
using Insight.Base.BaseForm.ViewModels;

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
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdApp, view.gdvApp, view.pccApp, "loadData", "editApp");
            initTree(view.TreNav, "navChanged", "editNav");
            initGrid(view.grdFunc, view.gdvFunc, "editFunc", "funChanged");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getApps(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;

            refreshToolBar();
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            nav = null;
            func = null;
            if (index < 0 || index >= list.Count)
            {
                item = null;
            }
            else
            {
                item = list[index];
                if (!item.navigations.Any())
                {
                    var navs = dataModel.getNavs(item.id);
                    if (navs != null) item.navigations.AddRange(navs);
                }
            }

            view.TreNav.DataSource = item?.navigations;
            view.TreNav.CollapseAll();
            view.TreNav.FocusedNode = view.TreNav.GetNodeList().FirstOrDefault(i => i.Level == 0);
            view.TreNav.ExpandAll();

            view.grdFunc.DataSource = nav?.functions;

            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        public void navChanged(TreeListNode node)
        {
            func = null;
            if (node == null)
            {
                nav = null;
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
                else if (!nav.functions.Any())
                {
                    var funcs = dataModel.getFuncs(nav.id);
                    if (funcs != null) nav.functions.AddRange(funcs);
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
        public void refreshFunc()
        {
            view.gdvFunc.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private new void refreshToolBar()
        {
            buttonStatus = new Dictionary<string, bool>
            {
                ["editApp"] = item != null,
                ["deleteApp"] = item != null,
                ["newNav"] = item?.permitLife > 0,
                ["editNav"] = nav != null,
                ["deleteNav"] = nav != null,
                ["newFunc"] = nav != null && nav.type == 2,
                ["editFunc"] = func != null,
                ["deleteFunc"] = func != null,
            };

            base.refreshToolBar();
        }
    }
}