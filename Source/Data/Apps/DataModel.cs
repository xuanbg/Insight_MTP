using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;
using System.Collections.Generic;

namespace Insight.MTP.Client.Data.Apps
{
    public class DataModel
    {
        private const string service = "/base/resource";

        /// <summary>
        /// 获取应用集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>应用集合</returns>
        public Result<List<App>> getApps(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/apps";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<App>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定应用的导航集合
        /// </summary>
        /// <param name="id">应用ID</param>
        /// <returns>导航集合</returns>
        public List<Navigation> getNavs(string id)
        {
            var url = $"{service}/v1.0/apps/{id}/navigators";
            var client = new HttpClient<List<Navigation>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取指定模块的功能集合
        /// </summary>
        /// <param name="id">模块ID</param>
        /// <returns>功能集合</returns>
        public List<Function> getFuncs(string id)
        {
            var url = $"{service}/v1.0/navigators/{id}/functions";
            var client = new HttpClient<List<Function>>(url);

            return client.getData();
        }

        /// <summary>
        /// 新增应用信息
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>应用ID</returns>
        public string addApp(App app)
        {
            if (app == null) return null;

            var url = $"{service}/v1.0/apps";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, app);
        }

        /// <summary>
        /// 更新应用信息
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateApp(App app)
        {
            if (app == null) return false;

            var url = $"{service}/v1.0/apps";
            var client = new HttpClient<object>(url);

            return client.put(app);
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="app">应用实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteApp(App app)
        {
            if (app == null) return false;

            var url = $"{service}/v1.0/apps";
            var client = new HttpClient<object>(url);

            return client.delete(app.id);
        }

        /// <summary>
        /// 新增导航信息
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>导航ID</returns>
        internal string addNav(Navigation nav)
        {
            if (nav == null) return null;

            var url = $"{service}/v1.0/navigators";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, nav);
        }

        /// <summary>
        /// 更新导航信息
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateNav(Navigation nav)
        {
            if (nav == null) return false;

            var url = $"{service}/v1.0/navigators";
            var client = new HttpClient<object>(url);

            return client.put(nav);
        }

        /// <summary>
        /// 删除导航
        /// </summary>
        /// <param name="nav">导航实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteNav(Navigation nav)
        {
            if (nav == null) return false;

            var url = $"{service}/v1.0/navigators";
            var client = new HttpClient<object>(url);

            return client.delete(nav.id);
        }

        /// <summary>
        /// 新增功能信息
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>应用ID</returns>
        public string addFunc(Function func)
        {
            if (func == null) return null;

            var url = $"{service}/v1.0/functions";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, func);
        }

        /// <summary>
        /// 更新功能信息
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateFunc(Function func)
        {
            if (func == null) return false;

            var url = $"{service}/v1.0/functions";
            var client = new HttpClient<object>(url);

            return client.put(func);
        }

        /// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="func">功能实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteFunc(Function func)
        {
            if (func == null) return false;

            var url = $"{service}/v1.0/functions";
            var client = new HttpClient<object>(url);

            return client.delete(func.id);
        }
    }
}
