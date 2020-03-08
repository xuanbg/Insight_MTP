using Insight.MTP.Client.Base.Tenants.Models;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Models;
using Insight.Utils.BaseControllers;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants
{
    public class Controller : MdiController<Tenant, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info)
        {

            // 加载角色列表
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData();
        }


        /// <summary>
        /// 新建
        /// </summary>
        private void add()
        {
            var tenant = new Tenant();
            var model = new TenantModel(tenant, "新建租户");
        }

        /// <summary>
        /// 编辑
        /// </summary>
        private void edit()
        {
            if (!mdiModel.allowDoubleClick("editTenant")) return;

            var model = new TenantModel(new Tenant(), "编辑租户");
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        private void bind()
        {
            var model = new BindModel(new Tenant(), "绑定应用");
        }

        /// <summary>
        /// 续租
        /// </summary>
        private void extend()
        {
            var model = new ExtendModel(new Tenant(), "续租");
        }

    }
}