using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants
{
    public class DataModel
    {
        private const string resourceService = "/base/tenant";

        /// <summary>
        /// 获取租户集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>租户集合</returns>
        public Result<List<Tenant>> getTenants(string keyword, int page, int size)
        {
            var url = $"{resourceService}/v1.0/tenants";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Tenant>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取指定租户绑定的租户集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <returns>绑定的租户集合</returns>
        public List<TenantApp> getTenantApps(string id)
        {
            var url = $"{resourceService}/v1.0/tenants/{id}/apps";
            var client = new HttpClient<List<TenantApp>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取指定租户绑定的用户集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>绑定的用户集合</returns>
        public Result<List<TenantUser>> getTenantUsers(string id, int page, int size)
        {
            var url = $"{resourceService}/v1.0/tenants/{id}/users";
            var dict = new Dictionary<string, object>
            {
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<TenantUser>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 新增租户信息
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>租户ID</returns>
        public string addTenant(Tenant tenant)
        {
            var msg = $"新建租户【{tenant.name}】失败！";
            var url = $"{resourceService}/v1.0/tenants";
            var client = new HttpClient<string>();

            return client.commit(url, tenant, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新租户信息
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateTenant(Tenant tenant)
        {
            var msg = $"更新租户【{tenant.name}】数据失败！";
            var url = $"{resourceService}/v1.0/tenants";
            var client = new HttpClient<object>();

            return client.put(url, tenant, msg);
        }

        /// <summary>
        /// 删除租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteTenant(Tenant tenant)
        {
            var msg = $"对不起，无法删除租户【{tenant.name}】！";
            var url = $"{resourceService}/v1.0/tenants";
            var client = new HttpClient<object>();

            return client.delete(url, tenant.id, msg);
        }

        /// <summary>
        /// 审核租户
        /// </summary>
        /// <param name="dict">参数</param>
        /// <returns>是否成功</returns>
        internal bool auditTenant(object dict)
        {
            var url = $"{resourceService}/v1.0/tenants/status";
            var client = new HttpClient<object>();

            return client.put(url, dict);
        }

        /// <summary>
        /// 禁用租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否成功</returns>
        public bool disableTenant(Tenant tenant)
        {
            var msg = $"禁用租户【{tenant.name}】失败！";
            var url = $"{resourceService}/v1.0/tenants/disable";
            var client = new HttpClient<object>();

            return client.put(url, tenant.id, msg);
        }

        /// <summary>
        /// 启用租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否成功</returns>
        public bool enableTenant(Tenant tenant)
        {
            var msg = $"启用租户【{tenant.name}】失败！";
            var url = $"{resourceService}/v1.0/tenants/enable";
            var client = new HttpClient<object>();

            return client.put(url, tenant.id, msg);
        }

        /// <summary>
        /// 获取租户可用应用集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <returns>应用集合</returns>
        public List<TenantApp> getApps(string id)
        {
            var url = $"{resourceService}/v1.0/tenants/{id}/unbounds";
            var client = new HttpClient<List<TenantApp>>();

            return client.getData(url);
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <param name="apps">租户应用实体对象集合</param>
        /// <returns>是否成功</returns>
        public bool bindApps(string id, IEnumerable<TenantApp> apps)
        {
            var url = $"{resourceService}/v1.0/tenants/{id}/apps";
            var data = apps.Select(i => i.id).ToList();
            var client = new HttpClient<object>();

            return client.post(url, data);
        }

        /// <summary>
        /// 解绑应用
        /// </summary>
        /// <param name="app">租户应用实体对象</param>
        /// <returns>是否成功</returns>
        public bool unbindApp(TenantApp app)
        {
            var msg = $"对不起，应用【{app.name}】解除绑定失败！";
            var url = $"{resourceService}/v1.0/tenants/{app.tenantId}/apps";
            var data = new List<string> {app.id};
            var client = new HttpClient<object>();

            return client.delete(url,data, msg);
        }

        /// <summary>
        /// 续租应用
        /// </summary>
        /// <param name="app">租户应用实体对象</param>
        /// <returns>是否成功</returns>
        public bool rentApp(TenantApp app)
        {
            var msg = $"对不起，续租应用【{app.name}】失败！";
            var url = $"{resourceService}/v1.0/tenants/{app.tenantId}/apps";
            var dict = new Dictionary<string, object>
            {
                {"appId", app.id},
                {"expireDate", app.expireDate}
            };
            var client = new HttpClient<object>();

            return client.put(url, dict, msg);
        }
    }
}
