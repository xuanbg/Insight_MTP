using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Apps.ViewModels;
using Insight.MTP.Client.Setting.Apps.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Apps
{
    public class Controller : MdiController<App, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info){}

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData(mdiModel.tab.page, mdiModel.tab.focusedRowHandle);
        }

        /// <summary>
        /// 新建应用
        /// </summary>
        public void newApp()
        {
            var count = dataModel.getApps(null, 1, 1).option;
            var app = new App{index = int.Parse(count.ToString()) + 1};
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
            var model = new AppModel(mdiModel.item, "编辑应用");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateApp(mdiModel.item)) return;

                mdiModel.refreshFunc();
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
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 新建导航
        /// </summary>
        public void newNav()
        {
            var type = mdiModel.nav?.type == 1 ? 2 : 1;
            var parentId = type == 1 ? null : mdiModel.nav?.id;
            var nav = new Navigation
            {
                parentId = parentId,
                appId = mdiModel.item.id,
                type = type,
                index = mdiModel.item.navigations.Count(i => i.parentId == parentId) + 1
            };
            var model = new NavModel(nav, "新建导航");
            model.callbackEvent += (sender, args) =>
            {
                nav.id = dataModel.addNav(nav);
                if (nav.id == null) return;

                mdiModel.item.navigations.Add(nav);
                mdiModel.refreshTree();
                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        public void editNav()
        {
            var model = new NavModel(mdiModel.nav, "编辑导航");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateNav(mdiModel.nav)) return;

                mdiModel.refreshTree();
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
                var id = mdiModel.nav.id;
                mdiModel.item.navigations.RemoveAll(i => i.id == id || i.parentId == id);
                mdiModel.refreshTree();
            }
        }

        /// <summary>
        /// 新建功能
        /// </summary>
        public void newFunc()
        {
            var func = new Function{navId = mdiModel.nav.id, index = mdiModel.nav.functions.Count + 1};
            var model = new FunModel(func, "新建功能");
            model.callbackEvent += (sender, args) =>
            {
                func.id = dataModel.addFunc(func);
                if (func.id == null) return;

                mdiModel.nav.functions.Add(func);
                mdiModel.refreshFunc();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑功能
        /// </summary>
        public void editFunc()
        {
            var model = new FunModel(mdiModel.func, "编辑功能");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateFunc(mdiModel.func)) return;

                mdiModel.refreshFunc();
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
                mdiModel.refreshFunc();
            }
        }
    }
}