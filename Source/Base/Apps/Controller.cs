using Insight.MTP.Client.Base.Apps.Models;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Apps
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
            manage.view.gdvApp.DoubleClick += (sender, args) => EditApp();

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
                case "getApps":
                    manage.Refresh();
                    break;
                case "newApp":
                    AddApp();
                    break;
                case "editApp":
                    EditApp();
                    break;
                case "deleteApp":
                    manage.DeleteItem();
                    break;
                case "newNav":
                    AddApp();
                    break;
                case "editNav":
                    EditApp();
                    break;
                case "deleteNav":
                    manage.DeleteItem();
                    break;
                case "newFun":
                    AddApp();
                    break;
                case "editFun":
                    EditApp();
                    break;
                case "deleteFun":
                    manage.DeleteItem();
                    break;
                default:
                    Messages.ShowError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        private void AddApp()
        {
            var app = new App();
            var model = new AppModel(app, "新建应用");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                app = model.Add();
                manage.CloseWaitForm();
                if (app == null) return;

                manage.AddItem(app);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        private void EditApp()
        {
            if (!manage.AllowDoubleClick("editApp")) return;

            var app = Util.Clone(manage.item);
            var model = new AppModel(app, "编辑应用");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                app = model.Edit();
                manage.CloseWaitForm();
                if (app == null) return;

                manage.Update(app);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}