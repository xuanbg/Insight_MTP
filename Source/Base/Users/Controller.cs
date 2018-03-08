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
        public Controller(Navigation info)
        {
            // 构造ViewModel，订阅工具栏按钮点击事件
            manage = new ManagerModel(info);
            manage.buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅界面事件
            manage.view.GdvUser.DoubleClick += (sender, args) => EditUser();

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
                case "getUsers":
                    manage.Refresh();
                    break;
                case "newUser":
                    AddUser();
                    break;
                case "editUser":
                    EditUser();
                    break;
                case "deleteUser":
                    manage.DeleteItem();
                    break;
                case "banned":
                    manage.SetInvalid(true);
                    break;
                case "release":
                    manage.SetInvalid(false);
                    break;
                case "reset":
                    manage.Reset();
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
            var user = new User();
            var userModel = new UserModel(user, "新建用户");
            var view = userModel.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                user = userModel.AddUser();
                manage.CloseWaitForm();
                if (user == null) return;

                manage.AddItem(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditUser()
        {
            if (!manage.AllowDoubleClick("editUser")) return;

            var user = Util.Clone(manage.user);
            user.funcs = null;
            user.datas = null;
            var userModel = new UserModel(user, "编辑用户");
            var view = userModel.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                user = userModel.EditUser();
                manage.CloseWaitForm();
                if (user == null) return;

                manage.Update(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}