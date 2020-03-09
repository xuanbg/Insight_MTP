using System.Collections.Generic;
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
        /// <returns>应用集合</returns>
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
        /// 获取指定租户绑定的应用集合
        /// </summary>
        /// <param name="id">租户ID</param>
        /// <returns>绑定的应用集合</returns>
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
        /// 新增应用信息
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>应用ID</returns>
        public string addApp(App app)
        {
            var msg = $"新建应用【{app.name}】失败！";
            var url = $"{resourceService}/v1.0/apps";
            var client = new HttpClient<string>();

            return client.commit(url, app, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新应用信息
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateApp(App app)
        {
            var msg = $"更新应用【{app.name}】数据失败！";
            var url = $"{resourceService}/v1.0/apps";
            var client = new HttpClient<object>();

            return client.put(url, app, msg);
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteApp(App app)
        {
            var msg = $"对不起，无法删除应用【{app.name}】！";
            var url = $"{resourceService}/v1.0/apps";
            var client = new HttpClient<object>();

            return client.delete(url, app.id, msg);
        }

        /// <summary>
        /// 新增导航信息
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>导航ID</returns>
        internal string addNav(Navigation nav)
        {
            var msg = $"新建导航【{nav.name}】失败！";
            var url = $"{resourceService}/v1.0/navigators";
            var client = new HttpClient<string>();

            return client.commit(url, nav, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新导航信息
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateNav(Navigation nav)
        {
            var msg = $"更新导航【{nav.name}】数据失败！";
            var url = $"{resourceService}/v1.0/navigators";
            var client = new HttpClient<object>();

            return client.put(url, nav, msg);
        }

        /// <summary>
        /// 删除导航
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteNav(Navigation nav)
        {
            var msg = $"对不起，无法删除导航【{nav.name}】！";
            var url = $"{resourceService}/v1.0/navigators";
            var client = new HttpClient<object>();

            return client.delete(url, nav.id, msg);
        }

        /// <summary>
        /// 新增功能信息
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>应用ID</returns>
        public string addFunc(Function func)
        {
            var msg = $"新建功能【{func.name}】失败！";
            var url = $"{resourceService}/v1.0/functions";
            var client = new HttpClient<string>();

            return client.commit(url, func, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新功能信息
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateFunc(Function func)
        {
            var msg = $"更新功能【{func.name}】数据失败！";
            var url = $"{resourceService}/v1.0/functions";
            var client = new HttpClient<object>();

            return client.put(url, func, msg);
        }

        /// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteFunc(Function func)
        {
            var msg = $"对不起，无法删除功能【{func.name}】！";
            var url = $"{resourceService}/v1.0/functions";
            var client = new HttpClient<object>();

            return client.delete(url, func.id, msg);
        }
    }
}
