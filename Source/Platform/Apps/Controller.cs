using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.ViewModels;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Apps
{
    public class Controller : MdiController<App, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info)
        {
            mdiModel.loadData();
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData(mdiModel.handle);
        }

        /// <summary>
        /// 新建应用
        /// </summary>
        public void newApp()
        {
            var app = new App();
            var model = new AppModel(app, "新建应用");
            model.callbackEvent += (sender, args) =>
            {
                app.id = dataModel.addApp(app);
                if (app.id == null) return;

                mdiModel.list.Add(app);
                mdiModel.tab.addItems();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑应用
        /// </summary>
        public void editApp()
        {
            if (!mdiModel.allowDoubleClick("editApp")) return;

            var model = new AppModel(mdiModel.item, "编辑应用");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateApp(mdiModel.item)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        public void deleteApp()
        {
            var msg = $"您确定要删除应用【{mdiModel.item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteApp(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
            }
        }

        /// <summary>
        /// 新建导航
        /// </summary>
        public void newNav()
        {
            var nav = new Navigation();
            var model = new NavModel(nav, "新建导航");
            model.callbackEvent += (sender, args) =>
            {
                nav.id = dataModel.addNav(nav);
                if (nav.id == null) return;

                mdiModel.item.navs.Add(nav);
                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        public void editNav()
        {
            if (!mdiModel.allowDoubleClick("editNav")) return;

            var model = new NavModel(mdiModel.nav, "编辑导航");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateNav(mdiModel.nav)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除当前选中导航
        /// </summary>
        public void deleteNav()
        {
            var msg = $"您确定要删除导航【{mdiModel.nav.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteNav(mdiModel.nav))
            {
                mdiModel.item.navs.Remove(mdiModel.nav);
            }
        }

        /// <summary>
        /// 新建功能
        /// </summary>
        public void newFunc()
        {
            var func = new Function{navId = mdiModel.nav.id};
            var model = new FunModel(func, "新建功能");
            model.callbackEvent += (sender, args) =>
            {
                func.id = dataModel.addFunc(func);
                if (func.id == null) return;

                mdiModel.nav.functions.Add(func);
                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑功能
        /// </summary>
        public void editFunc()
        {
            if (!mdiModel.allowDoubleClick("editFun")) return;

            var model = new FunModel(mdiModel.func, "编辑功能");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateFunc(mdiModel.func)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除当前选中功能
        /// </summary>
        public void deleteFunc()
        {
            var msg = $"您确定要删除功能【{mdiModel.func.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteFunc(mdiModel.func))
            {
                mdiModel.nav.functions.Remove(mdiModel.func);
            }
        }
    }
}