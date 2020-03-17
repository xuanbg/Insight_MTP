using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class ManagerModel : BaseMdiModel<Tenant, Manager, DataModel>
    {
        public TenantApp app;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdTenant, view.gdvTenant, view.ppcTenant);
            initGrid(view.gdvApp, "appChanged", "rent");
            initGrid(view.gdvUser, null, null, view.ppcUser, "getTenantUsers");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">当前焦点行</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getTenants(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;
            view.gdvTenant.RefreshData();
            view.gdvTenant.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                item = null;
                app = null;
            }
            else
            {
                item = list[index];
                if (!item.apps.Any())
                {
                    var apps = dataModel.getTenantApps(item.id);
                    if (apps != null) item.apps.AddRange(apps);
                }

                if (!item.users.Any())
                {
                    getTenantUsers();
                }
            }

            view.grdApp.DataSource = item?.apps;
            view.grdUser.DataSource = item?.users;
            refreshToolBar();
        }

        /// <summary>
        /// 所选绑定应用改变
        /// </summary>
        /// <param name="index">列表行号</param>
        public void appChanged(int index)
        {
            app = index < 0 ? null : item.apps[index];

            refreshToolBar();
        }

        /// <summary>
        /// 获取租户绑定用户集合
        /// </summary>
        /// <param name="handle"></param>
        public void getTenantUsers(int handle = 0)
        {
            var result = dataModel.getTenantUsers(item.id, view.ppcUser.page, view.ppcUser.size);
            if (!result.success) return;

            item.users = result.data;
            view.ppcUser.totalRows = result.total;
            view.gdvUser.RefreshData();
            view.gdvUser.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvTenant.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshApp()
        {
            view.gdvApp.RefreshData();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null,
                ["audit"] = item != null && item.status != 1,
                ["disable"] = item != null && !item.invalid,
                ["enable"] = item != null && item.invalid,
                ["bind"] = item != null,
                ["unbind"] = item != null && app != null,
                ["rent"] = item != null && app != null
            };
            switchItemStatus(dict);
        }
    }
}