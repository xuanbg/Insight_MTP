using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;
using Insight.MTP.Client.Common.Entity;
using Insight.Base.BaseForm.Utils;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Scenes
{
    public class DataModel
    {
        private const string service = "/common/message";
        private const string appService = "/base/resource";

        /// <summary>
        /// 获取场景集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>场景集合</returns>
        public Result<List<Scene>> getScenes(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/scenes";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Scene>>(url);

            return client.getResult(dict);
        }
        
        /// <summary>
        /// 获取指定场景的模板配置集合
        /// </summary>
        /// <param name="id">场景ID</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>绑定的用户集合</returns>
        public Result<List<TempConfig>> getTempConfigs(string id, int page, int size)
        {
            var url = $"{service}/v1.0/scenes/{id}/configs";
            var dict = new Dictionary<string, object>
            {
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<TempConfig>>(url);

            return client.getResult(dict);
        }
        
        /// <summary>
        /// 新增场景信息
        /// </summary>
        /// <param name="scene">场景实体对象</param>
        /// <returns>场景ID</returns>
        public string addScene(Scene scene)
        {
            if (scene == null) return null;

            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, scene);
        }

        /// <summary>
        /// 更新场景信息
        /// </summary>
        /// <param name="scene">场景实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateScene(Scene scene)
        {
            if (scene == null) return false;

            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<object>(url);

            return client.put(scene);
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="scene">场景实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteScene(Scene scene)
        {
            if (scene == null) return false;

            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<object>(url);

            return client.delete(scene.id);
        }

        /// <summary>
        /// 获取应用集合
        /// </summary>
        /// <returns>应用集合</returns>
        public List<LookUpMember> getApps()
        {
            var url = $"{appService}/v1.0/apps";
            var dict = new Dictionary<string, object>
            {
                {"page", 1},
                {"size", 999}
            };
            var client = new HttpClient<List<LookUpMember>>(url);

            return client.getData(dict);
        }
    }
}
