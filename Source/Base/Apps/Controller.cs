using System.Linq;
using Insight.MTP.Client.Base.Apps.Models;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Controller;
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
            manage.buttons.ForEach(i => i.ItemClick += (sender, args) => itemClick(args.Item.Name));

            // 订阅界面事件
            manage.view.gdvApp.DoubleClick += (sender, args) => editApp();
            manage.view.TreNav.DoubleClick += (sender, args) => editNav();
            manage.view.gdvFunc.DoubleClick += (sender, args) => editFun();

            // 加载角色列表
            manage.loadData();
        }

        /// <summary>
        /// 工具栏按钮点击事件路由
        /// </summary>
        /// <param name="action">功能操作</param>
        private void itemClick(string action)
        {
            switch (action)
            {
                case "getApps":
                    manage.refresh();
                    break;
                case "newApp":
                    addApp();
                    break;
                case "editApp":
                    editApp();
                    break;
                case "deleteApp":
                    manage.deleteItem();
                    break;
                case "newNav":
                    addNav();
                    break;
                case "editNav":
                    editNav();
                    break;
                case "deleteNav":
                    manage.deleteNav();
                    break;
                case "newFun":
                    addFun();
                    break;
                case "editFun":
                    editFun();
                    break;
                case "deleteFun":
                    manage.deleteFun();
                    break;
                default:
                    Messages.showError("对不起，该功能尚未实现！");
                    break;
            }
        }

        /// <summary>
        /// 新建应用
        /// </summary>
        private void addApp()
        {
            var app = new App();
            var model = new AppModel(app, "新建应用");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                app = model.add();
                manage.closeWaitForm();
                if (app == null) return;

                manage.addItem(app);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑应用
        /// </summary>
        private void editApp()
        {
            if (!manage.allowDoubleClick("editApp")) return;

            var app = Util.clone(manage.item);
            var model = new AppModel(app, "编辑应用");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                app = model.edit();
                manage.closeWaitForm();
                if (app == null) return;

                manage.update(app);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 新建导航
        /// </summary>
        private void addNav()
        {
            var nav = new Navigation{appId = manage.item.id};
            var navs = manage.item.navs.Select(i => new TreeLookUpMember {id = i.id, parentId = i.parentId, name = i.name});
            var model = new NavModel(nav, "新建导航") {navs = navs.ToList()};
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                nav = model.add();
                manage.closeWaitForm();
                if (nav == null) return;

                manage.addItem(nav);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        private void editNav()
        {
            if (!manage.allowDoubleClick("editNav")) return;

            var nav = Util.clone(manage.nav);
            var navs = manage.item.navs.Where(i => i.id != nav.id && i.parentId != nav.id)
                .Select(i => new TreeLookUpMember { id = i.id, parentId = i.parentId, name = i.name });
            var model = new NavModel(nav, "编辑导航") { navs = navs.ToList() };
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                nav = model.edit();
                manage.closeWaitForm();
                if (nav == null) return;

                manage.update(nav);
                closeDialog(view);
            };

            view.ShowDialog();
        }
        /// <summary>
        /// 新建功能
        /// </summary>
        private void addFun()
        {
            var app = new Function{navigatorId = manage.nav.id};
            var model = new FunModel(app, "新建功能");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                app = model.add();
                manage.closeWaitForm();
                if (app == null) return;

                manage.addItem(app);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑功能
        /// </summary>
        private void editFun()
        {
            if (!manage.allowDoubleClick("editFun")) return;

            var fun = Util.clone(manage.fun);
            var model = new FunModel(fun, "编辑功能");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                manage.showWaitForm();
                fun = model.edit();
                manage.closeWaitForm();
                if (fun == null) return;

                manage.update(fun);
                closeDialog(view);
            };

            view.ShowDialog();
        }
    }
}