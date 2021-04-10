using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Insight.MTP.Client.Platform.Tenants
{
    public class DataModel
    {
        private const string service = "/base/tenant";
        private const string commonService = "/common/area";

        /// <summary>
        /// 获取租户集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>租户集合</returns>
        public Result<List<Tenant>> getTenants(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/tenants";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Tenant>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定租户绑定的租户集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <returns>绑定的租户集合</returns>
        public List<TenantApp> getTenantApps(string id)
        {
            var url = $"{service}/v1.0/tenants/{id}/apps";
            var client = new HttpClient<List<TenantApp>>(url);

            return client.getData();
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
            var url = $"{service}/v1.0/tenants/{id}/users";
            var dict = new Dictionary<string, object>
            {
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<TenantUser>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取全部省级行政区划
        /// </summary>
        /// <returns>省级行政区划集合</returns>
        public List<LookUpMember> getProvinces()
        {
            var url = $"{commonService}/v1.0/areas/provinces";
            var client = new HttpClient<List<LookUpMember>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取指定上级ID的行政区划集合数据
        /// </summary>
        /// <param name="id">上级区划ID</param>
        /// <returns>行政区划集合</returns>
        public List<Region> getRegions(string id)
        {
            var url = $"{commonService}/v1.0/areas/{id}/subs";
            var client = new HttpClient<List<Region>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取租户可用应用集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <returns>应用集合</returns>
        public List<TenantApp> getApps(string id)
        {
            var url = $"{service}/v1.0/tenants/{id}/unbounds";
            var client = new HttpClient<List<TenantApp>>(url);

            return client.getData();
        }

        /// <summary>
        /// 新增租户信息
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>租户ID</returns>
        public string addTenant(Tenant tenant)
        {
            if (tenant == null) return null;

            var url = $"{service}/v1.0/tenants";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, tenant);
        }

        /// <summary>
        /// 更新租户信息
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateTenant(Tenant tenant)
        {
            if (tenant == null) return false;

            var url = $"{service}/v1.0/tenants";
            var client = new HttpClient<object>(url);

            return client.put(tenant);
        }

        /// <summary>
        /// 删除租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteTenant(Tenant tenant)
        {
            if (tenant == null) return false;

            var url = $"{service}/v1.0/tenants";
            var client = new HttpClient<object>(url);

            return client.delete(tenant.id);
        }

        /// <summary>
        /// 审核租户
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <param name="status">状态</param>
        /// <returns>是否成功</returns>
        internal bool auditTenant(string id, int status)
        {
            if (string.IsNullOrEmpty(id)) return false;

            var url = $"{service}/v1.0/tenants/status";
            var dict = new Dictionary<string, object>
            {
                {"id", id},
                {"status", status}
            };
            var client = new HttpClient<object>(url);

            return client.put(dict);
        }

        /// <summary>
        /// 禁用租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否成功</returns>
        public bool disableTenant(Tenant tenant)
        {
            if (tenant == null) return false;

            var url = $"{service}/v1.0/tenants/disable";
            var client = new HttpClient<object>(url);

            return client.put(tenant.id);
        }

        /// <summary>
        /// 启用租户
        /// </summary>
        /// <param name="tenant">租户实体对象</param>
        /// <returns>是否成功</returns>
        public bool enableTenant(Tenant tenant)
        {
            if (tenant == null) return false;

            var url = $"{service}/v1.0/tenants/enable";
            var client = new HttpClient<object>(url);

            return client.put(tenant.id);
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <param name="apps">租户应用实体对象集合</param>
        /// <returns>是否成功</returns>
        public bool bindApps(string id, List<TenantApp> apps)
        {
            if (!apps.Any()) return false;

            var url = $"{service}/v1.0/tenants/{id}/apps";
            var data = apps.Select(i => i.id).ToList();
            var client = new HttpClient<object>(url);

            return client.post(data);
        }

        /// <summary>
        /// 解绑应用
        /// </summary>
        /// <param name="app">租户应用实体对象</param>
        /// <returns>是否成功</returns>
        public bool unbindApp(TenantApp app)
        {
            if (app == null) return false;

            var url = $"{service}/v1.0/tenants/{app.tenantId}/apps";
            var data = new List<string> { app.id };
            var client = new HttpClient<object>(url);

            return client.delete(data);
        }

        /// <summary>
        /// 续租应用
        /// </summary>
        /// <param name="app">租户应用实体对象</param>
        /// <returns>是否成功</returns>
        public bool rentApp(TenantApp app)
        {
            if (app == null) return false;

            var url = $"{service}/v1.0/tenants/{app.tenantId}/apps";
            var dict = new Dictionary<string, object>
            {
                {"appId", app.id},
                {"expireDate", app.expireDate}
            };
            var client = new HttpClient<object>(url);

            return client.put(dict);
        }
    }
}
