using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using System.Collections.Generic;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Apps
{
    internal class DataModel
    {
        private const string resourceService = "/base/resource";

        /// <summary>
        /// 获取应用集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>应用集合</returns>
        internal Result<List<App>> getApps(string keyword, int page, int size)
        {
            var url = $"{resourceService}/v1.0/apps";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<App>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取指定应用的导航集合
        /// </summary>
        /// <param name="id">应用ID</param>
        /// <returns>导航集合</returns>
        internal List<Navigation> getNavs(string id)
        {
            var url = $"{resourceService}/v1.0/apps/{id}/navigators";
            var client = new HttpClient<List<Navigation>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取指定模块的功能集合
        /// </summary>
        /// <param name="id">模块ID</param>
        /// <returns>功能集合</returns>
        internal List<Function> getFuncs(string id)
        {
            var url = $"{resourceService}/v1.0/navigators/{id}/functions";
            var client = new HttpClient<List<Function>>();

            return client.getData(url);
        }

        /// <summary>
        /// 更新应用信息
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>是否更新成功</returns>
        internal bool updateApp(App app)
        {
            var msg = $"新建应用【{app.name}】失败！";
            var url = $"{resourceService}/v1.0/apps";
            var client = new HttpClient<App>();

            return client.put(url, app, msg);
        }
    }
}
