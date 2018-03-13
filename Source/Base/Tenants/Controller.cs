using Insight.MTP.Client.Base.Tenants.Models;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;

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
            manage.buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅界面事件
            manage.view.gdvTenant.DoubleClick += (sender, args) => Edit();

            // 加载角色列表
            manage.LoadData();
        }

        /// <summary>
        /// 工具栏按钮点击事件路由
        /// </summary>
        /// <param name="action">功能操作</param>
        private void ItemClick(string action)
        {
            switch (action)
            {
                case "getTenants":
                    manage.Refresh();
                    break;
                case "newTenant":
                    Add();
                    break;
                case "editTenant":
                    Edit();
                    break;
                case "deleteTenant":
                    manage.DeleteItem();
                    break;
                case "bindApp":
                    Bind();
                    break;
                case "extend":
                    Extend();
                    break;
                default:
                    Messages.ShowError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建
        /// </summary>
        private void Add()
        {
            var tenant = new Tenant();
            var model = new TenantModel(tenant, "新建租户");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                tenant = model.Add();
                manage.CloseWaitForm();
                if (tenant == null) return;

                manage.AddItem(tenant);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        private void Edit()
        {
            if (!manage.AllowDoubleClick("editTenant")) return;

            var tenant = Util.Clone(manage.item);
            var model = new TenantModel(tenant, "编辑租户");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                tenant = model.Edit();
                manage.CloseWaitForm();
                if (tenant == null) return;

                manage.Update(tenant);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        private void Bind()
        {
            var tenant = Util.Clone(manage.item);
            var model = new BindModel(tenant, "绑定应用");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                tenant = model.Save();
                manage.CloseWaitForm();
                if (tenant == null) return;

                manage.Update(tenant);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 续租
        /// </summary>
        private void Extend()
        {
            var tenant = Util.Clone(manage.item);
            var model = new ExtendModel(tenant, "续租");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                tenant = model.Save();
                manage.CloseWaitForm();
                if (tenant == null) return;

                manage.Update(tenant);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}