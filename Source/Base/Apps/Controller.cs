using System.Linq;
using Insight.MTP.Client.Base.Apps.Models;
using Insight.MTP.Client.Common.Controller;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;

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
            manage.view.TreNav.DoubleClick += (sender, args) => EditNav();
            manage.view.gdvFunc.DoubleClick += (sender, args) => EditFun();

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
                    AddNav();
                    break;
                case "editNav":
                    EditNav();
                    break;
                case "deleteNav":
                    manage.DeleteNav();
                    break;
                case "newFun":
                    AddFun();
                    break;
                case "editFun":
                    EditFun();
                    break;
                case "deleteFun":
                    manage.DeleteFun();
                    break;
                default:
                    Messages.ShowError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建应用
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
        /// 编辑应用
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

        /// <summary>
        /// 新建导航
        /// </summary>
        private void AddNav()
        {
            var nav = new Navigation{appId = manage.item.id};
            var navs = manage.item.navs.Select(i => new TreeLookUpMember {id = i.id, parentId = i.parentId, name = i.name});
            var model = new NavModel(nav, "新建导航") {navs = navs.ToList()};
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                nav = model.Add();
                manage.CloseWaitForm();
                if (nav == null) return;

                manage.AddItem(nav);
                CloseDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        private void EditNav()
        {
            if (!manage.AllowDoubleClick("editNav")) return;

            var nav = Util.Clone(manage.nav);
            var navs = manage.item.navs.Where(i => i.id != nav.id && i.parentId != nav.id)
                .Select(i => new TreeLookUpMember { id = i.id, parentId = i.parentId, name = i.name });
            var model = new NavModel(nav, "编辑导航") { navs = navs.ToList() };
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                nav = model.Edit();
                manage.CloseWaitForm();
                if (nav == null) return;

                manage.Update(nav);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
        /// <summary>
        /// 新建功能
        /// </summary>
        private void AddFun()
        {
            var app = new Function{navigatorId = manage.nav.id};
            var model = new FunModel(app, "新建功能");
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
        /// 编辑功能
        /// </summary>
        private void EditFun()
        {
            if (!manage.AllowDoubleClick("editFun")) return;

            var fun = Util.Clone(manage.fun);
            var model = new FunModel(fun, "编辑功能");
            var view = model.view;
            SubCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.ShowWaitForm();
                fun = model.Edit();
                manage.CloseWaitForm();
                if (fun == null) return;

                manage.Update(fun);
                CloseDialog(view);
            };

            view.ShowDialog();
        }
    }
}