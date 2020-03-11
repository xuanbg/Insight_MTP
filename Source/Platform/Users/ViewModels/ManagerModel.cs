using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Platform.Users.ViewModels
{
    public class ManagerModel : BaseMdiModel<App, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            init(view.gdvApp, "editApp", view.pccApp, view.KeyInput, view.Search);
            initTree(view.TreNav, "editNav", "navChanged");
            initGrid(view.gdvFunc, "editFunc", "funChanged");
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
            if (!result.success) return;

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
                    if (item.navigations == null)
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
            };
            switchItemStatus(dict);
        }
    }
}