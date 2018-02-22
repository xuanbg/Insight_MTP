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
        public Controller(Navigation info)
        {
            // 构造ViewModel，订阅工具栏按钮点击事件
            model = new ManagerModel(info);
            model.buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅角色列表双击事件
            model.view.GdvRole.DoubleClick += (sender, args) => RoleEdit();

            // 加载角色列表
            model.LoadRoles();
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
                    model.Refresh();
                    break;
                case "NewRole":
                    AddRole();
                    break;
                case "EditRole":
                    RoleEdit();
                    break;
                case "DeleteRole":
                    model.RoleDelete();
                    break;
                case "AddMember":
                    AddMembers();
                    break;
                case "Remove":
                    model.MemberRemove();
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
                base.model.ShowWaitForm();
                role = model.AddRole();
                base.model.CloseWaitForm();
                if (role == null) return;

                base.model.AddRole(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑当前所选角色
        /// </summary>
        private void RoleEdit()
        {
            if (!base.model.AllowDoubleClick("EditRole")) return;

            var role = Util.Clone(base.model.Role);
            var model = new WizardModel(role, "编辑角色");
            var view = model.View;
            SubCloseEvent(view);
            view.WizRole.FinishClick += (sender, args) =>
            {
                base.model.ShowWaitForm();
                role = model.EditRole();
                base.model.CloseWaitForm();
                if (role == null) return;

                base.model.UpdatePerm(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 为当前所选角色添加成员
        /// </summary>
        private void AddMembers()
        {
            var model = new MemberModel(base.model.Role);
            var view = model.View;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                base.model.ShowWaitForm();
                var role = model.Save();
                base.model.CloseWaitForm();
                if (role == null) return;

                base.model.UpdateMember(role);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}
