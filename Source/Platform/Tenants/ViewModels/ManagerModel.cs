using System.Collections.Generic;
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
            init(view.gdvTenant, "editTenant", view.tabTenant, view.KeyInput, view.Search);
            initGrid(view.gdvApp, null, "appChanged");
            initGrid(view.gdvUser, null, null, view.tabUser);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">当前焦点行</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getTenants(keyWord, tab.page, tab.size);
            list = result.data;
            closeWaitForm();
            if (!result.success) return;

            tab.totalRows = int.Parse(result.option.ToString());
            view.grdTenant.DataSource = list;
            view.gdvTenant.FocusedRowHandle = handle;
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
                app = null;
                view.grdApp.DataSource = null;
                view.grdUser.DataSource = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                handle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.apps == null)
                    {
                        item.apps = dataModel.getTenantApps(item.id);
                        view.grdApp.DataSource = item.apps;
                    }

                    if (item.users == null)
                    {
                        var result = dataModel.getTenantUsers(item.id, view.tabUser.page, view.tabUser.size);
                        item.users = result.data;
                        view.tabUser.totalRows = int.Parse(result.option.ToString());
                        view.grdUser.DataSource = item.users;
                    }
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
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvTenant.RefreshData();
            refreshToolBar();
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