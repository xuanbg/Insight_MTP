﻿using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Tenants.Models
{
    public class ManagerModel : BaseMdiModel<Tenant, Manager, DataModel>
    {

        public int rows = 20;
        public int total;
        public string key;

        public ManagerModel()
        {
            // 订阅界面事件
            view.gdvTenant.DoubleClick += (sender, args) => callback("edit");
            // 订阅租户列表分页控件事件
            view.tabTenant.pageSizeChanged += (sender, args) => rows = args.pageSize;
            view.tabTenant.currentPageChanged += (sender, args) => loadData(view.tabTenant.page, args.rowHandle);
            view.tabTenant.totalRowsChanged += (sender, args) => view.gdvTenant.FocusedRowHandle = args.rowHandle;

            // 订阅用户列表分页控件事件
            view.tabUser.pageSizeChanged += (sender, args) => rows = args.pageSize;
            view.tabUser.currentPageChanged += (sender, args) => loadData(view.tabUser.page, args.rowHandle);
            view.tabUser.totalRowsChanged += (sender, args) => view.gdvUser.FocusedRowHandle = args.rowHandle;

            // 订阅界面事件
            view.gdvTenant.FocusedRowObjectChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            view.Search.Click += (sender, args) => loadData();
            view.KeyInput.Properties.Click += (sender, args) => view.KeyInput.EditValue = null;
            view.KeyInput.EditValueChanged += (sender, args) => key = view.KeyInput.Text.Trim();
            view.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                loadData();
            };

            // 设置界面样式
            Format.gridFormat(view.gdvTenant);
            Format.gridFormat(view.gdvApp);
            Format.gridFormat(view.gdvUser);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void loadData(int page = 1, int handel = 0)
        {
            showWaitForm();
            view.tabTenant.totalRows = total;
            view.grdTenant.DataSource = list;
            view.gdvTenant.FocusedRowHandle = handle;
            closeWaitForm();
            var url = $"/tenantapi/v1.0/tenants";
            var dict = new Dictionary<string, object>
            {
                {"key", key},
                {"page", page},
                {"rows", rows}
            };
            var client = new HttpClient<List<Tenant>>();
            if (!client.get(url, dict))
            {
                return;
            }
            total = int.Parse(client.option.ToString());
            list = client.data;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data"></param>
        public void addItem(Tenant data)
        {
            list.Add(data);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">UserInfo</param>
        public void update(Tenant data)
        {
            Util.copyValue(data, item);
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除租户【{item.name}】吗？\r\n租户删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            msg = $"对不起，无法租除用户【{item.name}】！";
            var url = $"/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<object>();
            if (!client.delete(url, null, msg))
            {
                return;
            }

            list.Remove(item);
            //view.tabTenant.removeItems();
            //view.gdvTenant.RefreshData();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        public void getDetail()
        {
            var url = $"/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<Tenant>();
            if (!client.get(url)) return;

            item.apps = client.data.apps;
            item.users = client.data.users;
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editTenant"] = item != null,
                ["deleteTenant"] = item != null,
                ["bindApp"] = item != null,
                ["extend"] = item != null
            };
            switchItemStatus(dict);
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void itemChanged(int index)
        {
            view.tabTenant.focusedRowHandle = index;
            item = index < 0 ? null : list[index];
            if (item != null && (item.apps == null || item.users == null)) getDetail();

            view.grdApp.DataSource = item?.apps;
            view.grdUser.DataSource = item?.users;

            refreshToolBar();
        }

    }
}