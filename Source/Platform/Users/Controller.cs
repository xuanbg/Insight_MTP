using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.ViewModels;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Users
{
    public class Controller : MdiController<User, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info) : base(info) { }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData(mdiModel.handle);
        }
        
    }
}