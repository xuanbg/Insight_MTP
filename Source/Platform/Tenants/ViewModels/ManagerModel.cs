﻿using System.Collections.Generic;
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
        /// <param name="page">当前页</param>
        /// <param name="handle">焦点行号</param>
        public void loadData(int page = 1, int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getTenants(keyWord, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;
            tab.page = page;
            view.gdvTenant.FocusedRowHandle = handle;

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
                view.grdUser.DataSource = null;
            }
            else
            {
                item = list[index];
                if (!item.apps.Any())
                {
                    getTenantApps();
                }

                if (!item.users.Any())
                {
                    getTenantUsers();
                }
            }


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
            view.gdvApp.RefreshData();
            view.gdvApp.FocusedRowHandle = handle;

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
            view.gdvUser.FocusedRowHandle = handle;
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
                ["unbind"] = item != null && app != null,
                ["rent"] = item != null && app != null
            };
            switchItemStatus(dict);
        }
    }
}