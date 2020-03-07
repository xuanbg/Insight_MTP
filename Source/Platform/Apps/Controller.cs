using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.ViewModels;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
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
            refresh();
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData();
        }


        /// <summary>
        /// 新建应用
        /// </summary>
        public void newApp()
        {
            var app = new App();
            var model = new AppModel(app, "新建应用");
        }

        /// <summary>
        /// 编辑应用
        /// </summary>
        public void editApp()
        {
            if (!mdiModel.allowDoubleClick("editApp")) return;

            var model = new AppModel(null, "编辑应用");
        }

        /// <summary>
        /// 新建导航
        /// </summary>
        public void newNav()
        {
            var nav = new Navigation();
            var navs =  new TreeLookUpMember();
            var model = new NavModel(nav, "新建导航");
        }

        /// <summary>
        /// 编辑导航
        /// </summary>
        public void editNav()
        {
            if (!mdiModel.allowDoubleClick("editNav")) return;

            var nav = Util.clone(mdiModel.nav);
            var model = new NavModel(nav, "编辑导航");
        }

        /// <summary>
        /// 新建功能
        /// </summary>
        public void newFun()
        {
            var app = new Function{navId = mdiModel.nav.id};
            var model = new FunModel(app, "新建功能");
        }

        /// <summary>
        /// 编辑功能
        /// </summary>
        public void editFun()
        {
            if (!mdiModel.allowDoubleClick("editFun")) return;

            var fun = Util.clone(mdiModel.fun);
            var model = new FunModel(fun, "编辑功能");
        }

    }
}