using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Models;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Apps
{
    public class Controller : MdiController<App, Manager, ManagerModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info)
        {
            // 订阅界面事件
            mdiView.gdvApp.DoubleClick += (sender, args) => editApp();
            mdiView.TreNav.DoubleClick += (sender, args) => editNav();
            mdiView.gdvFunc.DoubleClick += (sender, args) => editFun();

            mdiView.gdvApp.FocusedRowObjectChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            mdiView.TreNav.FocusedNodeChanged += (sender, args) => navChanged(args.Node);
            mdiView.gdvFunc.FocusedRowObjectChanged += (sender, args) => funChanged(args.FocusedRowHandle);

            // 设置界面样式
            Format.gridFormat(mdiView.gdvApp);
            Format.treeFormat(mdiView.TreNav);
            Format.gridFormat(mdiView.gdvFunc);

            // 加载数据

        }
        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            showWaitForm();
            mdiModel.loadData();
            mdiView.grdApp.DataSource = mdiModel.list;
            mdiView.gdvApp.FocusedRowHandle = mdiModel.handle;
            closeWaitForm();
        }


        /// <summary>
        /// 新建应用
        /// </summary>
        public void newApp()
        {
            var app = new App();
            var model = new AppModel(app, "新建应用");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                app = model.add();
                closeWaitForm();
                if (app == null) return;

                mdiModel.addItem(app);
                mdiView.gdvApp.RefreshData();
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑应用
        /// </summary>
        public void editApp()
        {
            if (!allowDoubleClick("editApp")) return;

            var app = Util.clone(mdiModel.item);
            var model = new AppModel(app, "编辑应用");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                app = model.edit();
                closeWaitForm();
                if (app == null) return;

                mdiModel.update(app);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 新建导航
        /// </summary>
        public void newNav()
        {
            var nav = new Navigation{id = mdiModel.item.id};
            var navs = mdiModel.item.navs.Select(i => new TreeLookUpMember {id = i.id, parentId = i.parentId, name = i.name});
            var model = new NavModel(nav, "新建导航") {navs = navs.ToList()};
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                nav = model.add();
                closeWaitForm();
                if (nav == null) return;

                mdiModel.addItem(nav);
                mdiView.TreNav.RefreshDataSource();
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        public void editNav()
        {
            if (!allowDoubleClick("editNav")) return;

            var nav = Util.clone(mdiModel.nav);
            var navs = mdiModel.item.navs.Where(i => i.id != nav.id && i.parentId != nav.id)
                .Select(i => new TreeLookUpMember { id = i.id, parentId = i.parentId, name = i.name });
            var model = new NavModel(nav, "编辑导航") { navs = navs.ToList() };
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                nav = model.edit();
                closeWaitForm();
                if (nav == null) return;

                mdiModel.update(nav);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 新建功能
        /// </summary>
        public void newFun()
        {
            var app = new Function{navId = mdiModel.nav.id};
            var model = new FunModel(app, "新建功能");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                app = model.add();
                closeWaitForm();
                if (app == null) return;

                mdiModel.addItem(app);
                mdiView.gdvFunc.RefreshData();
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 编辑功能
        /// </summary>
        public void editFun()
        {
            if (!allowDoubleClick("editFun")) return;

            var fun = Util.clone(mdiModel.fun);
            var model = new FunModel(fun, "编辑功能");
            var view = model.view;
            subCloseEvent(view);
            view.Confirm.Click += (sender, args) =>
            {
                showWaitForm();
                fun = model.edit();
                closeWaitForm();
                if (fun == null) return;

                mdiModel.update(fun);
                closeDialog(view);
            };

            view.ShowDialog();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void itemChanged(int index)
        {
            mdiModel.handle = index;
            mdiModel.item = index < 0 ? null : mdiModel.list[index];
            if (mdiModel.item != null && mdiModel.item.navs == null) mdiModel.getDetail();

            mdiView.TreNav.DataSource = mdiModel.item?.navs;
            mdiView.TreNav.FocusedNode = mdiView.TreNav.Nodes.FirstNode;
            mdiView.TreNav.ExpandAll();
            if (!(mdiModel.item?.navs?.Any() ?? false)) mdiModel.nav = null;

            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        private void navChanged(TreeListNode node)
        {
            if (node != null)
            {
                var id = node.GetValue("id").ToString();
                mdiModel.nav = mdiModel.item.navs.SingleOrDefault(m => m.id == id);
                if (node.HasChildren) mdiModel.fun = null;
                else if (mdiModel.nav != null) mdiModel.getFuns(id);
            }

            mdiView.grdFunc.DataSource = mdiModel.nav?.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void funChanged(int index)
        {
            mdiModel.fun = index < 0 ? null : mdiModel.nav.functions[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editApp"] = mdiModel.item != null,
                ["deleteApp"] = mdiModel.item != null,
                ["newNav"] = mdiModel.item != null,
                ["editNav"] = mdiModel.nav != null,
                ["deleteNav"] = mdiModel.nav != null,
                ["newFun"] = mdiModel.nav != null,
                ["editFun"] = mdiModel.fun != null,
                ["deleteFun"] = mdiModel.fun != null,
            };
            switchItemStatus(dict);
        }

    }
}