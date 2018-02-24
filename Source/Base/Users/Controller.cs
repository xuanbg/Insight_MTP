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
            model = new ManagerModel(info);
            model.buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅界面事件
            model.view.GdvUser.DoubleClick += (sender, args) => EditUser();

            // 加载角色列表
            model.LoadUsers();
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
                case "NewUser":
                    AddUser();
                    break;
                case "EditUser":
                    EditUser();
                    break;
                case "DeleteUser":
                    model.DeleteUser();
                    break;
                case "Banned":
                    model.SetStatus(false);
                    break;
                case "Release":
                    model.SetStatus(true);
                    break;
                case "Reset":
                    model.Reset();
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
            var view = userModel.View;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                model.ShowWaitForm();
                user = userModel.AddUser();
                model.CloseWaitForm();
                if (user == null) return;

                model.AddUser(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditUser()
        {
            if (!model.AllowDoubleClick("EditUser")) return;

            var user = Util.Clone(model.user);
            user.funcs = null;
            user.datas = null;
            var userModel = new UserModel(user, "编辑用户");
            var view = userModel.View;
            view.LoginName.Enabled = false;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                model.ShowWaitForm();
                user = userModel.EditUser();
                model.CloseWaitForm();
                if (user == null) return;

                model.Update(user);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}