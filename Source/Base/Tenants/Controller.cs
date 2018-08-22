using Insight.MTP.Client.Base.Tenants.Models;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Controller;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Base.Tenants
{
    public class Controller : BaseController<ManagerModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(Navigation info)
        {
            // 构造ViewModel，订阅工具栏按钮点击事件
            manage = new ManagerModel(info);
            manage.buttons.ForEach(i => i.ItemClick += (sender, args) => itemClick(args.Item.Name));

            // 订阅界面事件
            manage.view.gdvTenant.DoubleClick += (sender, args) => edit();

            // 加载角色列表
            manage.loadData();
        }

        /// <summary>
        /// 工具栏按钮点击事件路由
        /// </summary>
        /// <param name="action">功能操作</param>
        private void itemClick(string action)
        {
            switch (action)
            {
                case "getTenants":
                    manage.refresh();
                    break;
                case "newTenant":
                    add();
                    break;
                case "editTenant":
                    edit();
                    break;
                case "deleteTenant":
                    manage.deleteItem();
                    break;
                case "bindApp":
                    bind();
                    break;
                case "extend":
                    extend();
                    break;
                default:
                    Messages.showError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建
        /// </summary>
        private void add()
        {
            var tenant = new Tenant();
            var model = new TenantModel(tenant, "新建租户");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                tenant = model.add();
                manage.closeWaitForm();
                if (tenant == null) return;

                manage.addItem(tenant);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        private void edit()
        {
            if (!manage.allowDoubleClick("editTenant")) return;

            var tenant = Util.clone(manage.item);
            var model = new TenantModel(tenant, "编辑租户");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                tenant = model.edit();
                manage.closeWaitForm();
                if (tenant == null) return;

                manage.update(tenant);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        private void bind()
        {
            var tenant = Util.clone(manage.item);
            var model = new BindModel(tenant, "绑定应用");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                tenant = model.save();
                manage.closeWaitForm();
                if (tenant == null) return;

                manage.update(tenant);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 续租
        /// </summary>
        private void extend()
        {
            var tenant = Util.clone(manage.item);
            var model = new ExtendModel(tenant, "续租");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                tenant = model.save();
                manage.closeWaitForm();
                if (tenant == null) return;

                manage.update(tenant);
                closeDialog(view);
            };

            view.ShowDialog();
        }
    }
}