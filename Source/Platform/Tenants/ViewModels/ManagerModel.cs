using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Base.BaseForm.ViewModels;

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
            initGrid(view.grdApp, view.gdvApp, "appChanged", "rent");
            initGrid(view.grdUser, view.gdvUser, null, null, view.ppcUser, "getTenantUsers");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getTenants(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;

            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            app = null;
            if (index < 0 || index >= list.Count)
            {
                item = null;
                view.grdApp.DataSource = null;
                view.ppcUser.totalRows = 0;
                view.grdUser.DataSource = null;
                view.gdvUser.FocusedRowHandle = -1;
                refreshToolBar();

                return;
            }

            item = list[index];
            if (!item.apps.Any()) getTenantApps();

            if (!item.users.Any()) getTenantUsers();

            view.grdApp.DataSource = item.apps;
            view.ppcUser.totalRows = item.userTotal;
            view.grdUser.DataSource = item.users;
            view.gdvUser.FocusedRowHandle = 0;

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
        public void getTenantApps(int handle = 0)
        {
            var apps = dataModel.getTenantApps(item.id);
            if (apps == null) return;

            item.apps.AddRange(apps);
            view.grdApp.DataSource = item.apps;
            view.gdvApp.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 获取租户绑定用户集合
        /// </summary>
        public void getTenantUsers()
        {
            var result = dataModel.getTenantUsers(item.id, view.ppcUser.page, view.ppcUser.size);
            if (!result.success) return;

            item.users = result.data;
            item.userTotal = result.total;
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
                ["disable"] = item != null && !item.invalid && item.status == 1,
                ["enable"] = item != null && item.invalid,
                ["bind"] = item != null && item.status == 1,
                ["unbind"] = item != null && app?.id != "e46c0d4f85f24f759ad4d86b9505b1d4",
                ["rent"] = item != null && app != null
            };
            switchItemStatus(dict);
        }
    }
}