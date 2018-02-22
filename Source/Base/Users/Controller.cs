using System;
using Insight.MTP.Client.Base.Users.Models;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Users
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

            // 订阅界面事件
            Model.View.GdvUser.DoubleClick += (sender, args) => EditUser();

            // 加载角色列表
            Model.LoadUsers();
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
                case "NewUser":
                    AddUser();
                    break;
                case "EditUser":
                    EditUser();
                    break;
                case "DeleteUser":
                    Model.DeleteUser();
                    break;
                case "Banned":
                    Model.SetStatus(false);
                    break;
                case "Release":
                    Model.SetStatus(true);
                    break;
                case "Reset":
                    Model.Reset();
                    break;
                default:
                    Messages.ShowError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        private void AddUser()
        {
            var user = new User
            {
                id = Guid.NewGuid(),
                type = 1
            };
            var model = new UserModel(user, "新建用户");
            var view = model.View;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                Model.ShowWaitForm();
                user = model.AddUser();
                Model.CloseWaitForm();
                if (user == null) return;

                Model.AddUser(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditUser()
        {
            if (!Model.AllowDoubleClick("EditUser")) return;

            var user = Util.Clone(Model.User);
            user.Actions = null;
            user.Datas = null;
            var model = new UserModel(user, "编辑用户");
            var view = model.View;
            view.LoginName.Enabled = false;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                Model.ShowWaitForm();
                user = model.EditUser();
                Model.CloseWaitForm();
                if (user == null) return;

                Model.Update(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}