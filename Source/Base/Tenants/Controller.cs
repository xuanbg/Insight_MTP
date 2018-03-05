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
            model = new ManagerModel(info);
            model.buttons.ForEach(i => i.ItemClick += (sender, args) => ItemClick(args.Item.Name));

            // 订阅界面事件
            model.view.gdvUser.DoubleClick += (sender, args) => EditUser();

            // 加载角色列表
            model.LoadData();
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
                    model.Refresh();
                    break;
                case "newTenant":
                    AddUser();
                    break;
                case "editTenant":
                    EditUser();
                    break;
                case "deleteTenant":
                    model.DeleteItem();
                    break;
                case "extend":
                    model.DeleteItem();
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
            //var user = new User();
            //var userModel = new UserModel(user, "新建用户");
            //var view = userModel.view;
            //SubCloseEvent(view);
            //view.Confirm.Click += (sender, args) =>
            //{
            //    model.ShowWaitForm();
            //    user = userModel.AddUser();
            //    model.CloseWaitForm();
            //    if (user == null) return;

            //    model.AddUser(user);
            //    CloseDialog(view);
            //};

            //view.ShowDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditUser()
        {
            //if (!model.AllowDoubleClick("editTenant")) return;

            //var user = Util.Clone(model.user);
            //user.funcs = null;
            //user.datas = null;
            //var userModel = new UserModel(user, "编辑用户");
            //var view = userModel.view;
            //SubCloseEvent(view);
            //view.Confirm.Click += (sender, args) =>
            //{
            //    model.ShowWaitForm();
            //    user = userModel.EditUser();
            //    model.CloseWaitForm();
            //    if (user == null) return;

            //    model.Update(user);
            //    CloseDialog(view);
            //};

            //view.ShowDialog();
        }
    }
}