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
            init(view.gdvTenant, "editItem", view.ppcTenant, view.KeyInput, view.Search);
            initGrid(view.gdvApp, "appChanged", "rent");
            initGrid(view.gdvUser, null, null, view.ppcUser);
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

            list = result.data;
            tab.totalRows = int.Parse(result.option.ToString());
            view.grdTenant.DataSource = list;
            view.gdvTenant.FocusedRowHandle = handle;

            refreshToolBar();
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
            }
            else
            {
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.apps == null || !item.apps.Any())
                    {
                        item.apps = dataModel.getTenantApps(item.id);
                    }

                    if (item.users == null || !item.users.Any())
                    {
                        var result = dataModel.getTenantUsers(item.id, view.ppcUser.page, view.ppcUser.size);
                        if (result.success)
                        {
                            item.users = result.data;
                            view.ppcUser.totalRows = int.Parse(result.option.ToString());
                        }
                    }
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