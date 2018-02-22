using System;
using Insight.MTP.Client.Base.Roles.Models;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Roles
{
    public class Controller : BaseController<ManagerModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleInfo info)
        {
            // 构造ViewModel，订阅工具栏按钮点击事件
            Model = new ManagerModel(info);
            Model.Buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅角色列表双击事件
            Model.View.GdvRole.DoubleClick += (sender, args) => RoleEdit();

            // 加载角色列表
            Model.LoadRoles();
        }

        /// <summary>
        /// 工具栏按钮点击事件路由
        /// </summary>
        /// <param name="action">功能操作</param>
        private void ItemClick(string action)
        {
            switch (action)
            {
                case "Refresh":
                    Model.Refresh();
                    break;
                case "NewRole":
                    AddRole();
                    break;
                case "EditRole":
                    RoleEdit();
                    break;
                case "DeleteRole":
                    Model.RoleDelete();
                    break;
                case "AddMember":
                    AddMembers();
                    break;
                case "Remove":
                    Model.MemberRemove();
                    break;
                default:
                    Messages.ShowError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建角色
        /// </summary>
        private void AddRole()
        {
            var role = new Role {ID = Guid.NewGuid(), Validity = true};
            var model = new WizardModel(role, "新建角色");
            var view = model.View;
            SubCloseEvent(view);
            view.WizRole.FinishClick += (sender, args) =>
            {
                Model.ShowWaitForm();
                role = model.AddRole();
                Model.CloseWaitForm();
                if (role == null) return;

                Model.AddRole(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑当前所选角色
        /// </summary>
        private void RoleEdit()
        {
            if (!Model.AllowDoubleClick("EditRole")) return;

            var role = Util.Clone(Model.Role);
            var model = new WizardModel(role, "编辑角色");
            var view = model.View;
            SubCloseEvent(view);
            view.WizRole.FinishClick += (sender, args) =>
            {
                Model.ShowWaitForm();
                role = model.EditRole();
                Model.CloseWaitForm();
                if (role == null) return;

                Model.UpdatePerm(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 为当前所选角色添加成员
        /// </summary>
        private void AddMembers()
        {
            var model = new MemberModel(Model.Role);
            var view = model.View;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                Model.ShowWaitForm();
                var role = model.Save();
                Model.CloseWaitForm();
                if (role == null) return;

                Model.UpdateMember(role);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}
