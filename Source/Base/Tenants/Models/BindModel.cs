using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class BindModel : BaseModel
    {
        public BindDialog view = new BindDialog();

        private readonly Tenant tenant;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="tenant">租户对象</param>
        public BindModel(Tenant tenant)
        {
            this.tenant = tenant;

            view.grdApp.DataSource = GetApps();
            Format.GridFormat(view.gdvApp, 0);
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Tenant Save()
        {
            const string msg = "更新绑定应用失败！";
            var url = $"{server}/tenantapi/v1.0/tenants/{tenant.id}";
            var dict = new Dictionary<string, object> { { "tenant", tenant } };
            var client = new HttpClient<Tenant>(token);

            return client.Put(url, dict, msg) ? tenant : null;
        }

        /// <summary>
        /// 加载非角色成员用户列表数据
        /// </summary>
        private List<App> GetApps()
        {
            var url = $"{server}/appapi/v1.0/apps/all";
            var client = new HttpClient<List<App>>(token);
            client.Get(url);

            return client.data;
        }
    }
}
