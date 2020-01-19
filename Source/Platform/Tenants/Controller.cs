using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Models;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants
{
    public class Controller : MdiController<Tenant, Manager, ManagerModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info)
        {
            // 订阅界面事件
            mdiView.gdvTenant.DoubleClick += (sender, args) => edit();
            // 订阅租户列表分页控件事件
            mdiView.tabTenant.pageSizeChanged += (sender, args) => mdiModel.rows = args.pageSize;
            mdiView.tabTenant.currentPageChanged += (sender, args) => mdiModel.loadData(mdiView.tabTenant.currentPage, args.rowHandle);
            mdiView.tabTenant.totalRowsChanged += (sender, args) => mdiView.gdvTenant.FocusedRowHandle = args.rowHandle;

            // 订阅用户列表分页控件事件
            mdiView.tabUser.pageSizeChanged += (sender, args) => mdiModel.rows = args.pageSize;
            mdiView.tabUser.currentPageChanged += (sender, args) => mdiModel.loadData(mdiView.tabUser.currentPage, args.rowHandle);
            mdiView.tabUser.totalRowsChanged += (sender, args) => mdiView.gdvUser.FocusedRowHandle = args.rowHandle;

            // 订阅界面事件
            mdiView.gdvTenant.FocusedRowObjectChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            mdiView.Search.Click += (sender, args) => mdiModel.loadData();
            mdiView.KeyInput.Properties.Click += (sender, args) => mdiView.KeyInput.EditValue = null;
            mdiView.KeyInput.EditValueChanged += (sender, args) => mdiModel.key = mdiView.KeyInput.Text.Trim();
            mdiView.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                mdiModel.loadData();
            };

            // 设置界面样式
            Format.gridFormat(mdiView.gdvTenant);
            Format.gridFormat(mdiView.gdvApp);
            Format.gridFormat(mdiView.gdvUser);

            // 加载角色列表
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            showWaitForm();
            mdiModel.loadData(mdiView.tabTenant.currentPage, mdiView.tabTenant.focusedRowHandle);
            mdiView.tabTenant.totalRows = mdiModel.total;
            mdiView.grdTenant.DataSource = mdiModel.list;
            mdiView.gdvTenant.FocusedRowHandle = mdiModel.handle;
            closeWaitForm();
        }


        /// <summary>
        /// 新建
        /// </summary>
        private void add()
        {
            var tenant = new Tenant();
            var model = new TenantModel(tenant, "新建租户");
            var view = model.view;
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                tenant = model.add();
                closeWaitForm();
                if (tenant == null) return;

                mdiModel.addItem(tenant);
                mdiView.tabTenant.addItems();
                mdiView.gdvTenant.RefreshData();
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        private void edit()
        {
            if (!allowDoubleClick("editTenant")) return;

            var tenant = Util.clone(mdiModel.item);
            var model = new TenantModel(tenant, "编辑租户");
            var view = model.view;
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                tenant = model.edit();
                closeWaitForm();
                if (tenant == null) return;

                mdiModel.update(tenant);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        private void bind()
        {
            var tenant = Util.clone(mdiModel.item);
            var model = new BindModel(tenant, "绑定应用");
            var view = model.view;
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                tenant = model.save();
                closeWaitForm();
                if (tenant == null) return;

                mdiModel.update(tenant);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 续租
        /// </summary>
        private void extend()
        {
            var tenant = Util.clone(mdiModel.item);
            var model = new ExtendModel(tenant, "续租");
            var view = model.view;
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                tenant = model.save();
                closeWaitForm();
                if (tenant == null) return;

                mdiModel.update(tenant);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editTenant"] = mdiModel.item != null,
                ["deleteTenant"] = mdiModel.item != null,
                ["bindApp"] = mdiModel.item != null,
                ["extend"] = mdiModel.item != null
            };
            switchItemStatus(dict);
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void itemChanged(int index)
        {
            mdiView.tabTenant.focusedRowHandle = index;
            mdiModel.item = index < 0 ? null : mdiModel.list[index];
            if (mdiModel.item != null && (mdiModel.item.apps == null || mdiModel.item.users == null)) mdiModel.getDetail();

            mdiView.grdApp.DataSource = mdiModel.item?.apps;
            mdiView.grdUser.DataSource = mdiModel.item?.users;

            refreshToolBar();
        }

    }
}