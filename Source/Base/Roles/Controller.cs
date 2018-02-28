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
                case "getRoles":
                    model.Refresh();
                    break;
                case "newRole":
                    AddRole();
                    break;
                case "editRole":
                    RoleEdit();
                    break;
                case "deleteRole":
                    model.RoleDelete();
                    break;
                case "addRoleMember":
                    AddMembers();
                    break;
                case "removeRoleMember":
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
            var role = new Role {id = Util.NewId()};
            var wizardModel = new WizardModel(role, "新建角色");
            var view = wizardModel.view;
            SubCloseEvent(view);
            view.WizRole.FinishClick += (sender, args) =>
            {
                model.ShowWaitForm();
                role = wizardModel.AddRole();
                model.CloseWaitForm();
                if (role == null)
                {
                    args.Cancel = true;
                    return;
                }

                model.AddRole(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑当前所选角色
        /// </summary>
        private void RoleEdit()
        {
            if (!model.AllowDoubleClick("editRole")) return;

            var role = Util.Clone(model.role);
            var wizardModel = new WizardModel(role, "编辑角色");
            var view = wizardModel.view;
            SubCloseEvent(view);
            view.WizRole.FinishClick += (sender, args) =>
            {
                model.ShowWaitForm();
                role = wizardModel.EditRole();
                model.CloseWaitForm();
                if (role == null)
                {
                    args.Cancel = true;
                    return;
                }

                model.UpdatePerm(role);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 为当前所选角色添加成员
        /// </summary>
        private void AddMembers()
        {
            var memberModel = new MemberModel(model.role);
            var view = memberModel.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                model.ShowWaitForm();
                var role = memberModel.Save();
                model.CloseWaitForm();
                if (role == null) return;

                model.UpdateMember(role);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}
