using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;
using System.Collections.Generic;

namespace Insight.MTP.Client.Platform.Scenes
{
    public class DataModel
    {
        private const string service = "/common/message";
        private const string appService = "/base/resource";

        /// <summary>
        /// 获取场景集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="pageNum">页码</param>
        /// <param name="pageSize">每页行数</param>
        /// <returns>场景集合</returns>
        public Result<List<Scene>> getScenes(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/scenes";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"pageNum", page},
                {"pageSize", size}
            };
            var client = new HttpClient<List<Scene>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定场景的模板配置集合
        /// </summary>
        /// <param name="id">场景ID</param>
        /// <returns>绑定的用户集合</returns>
        public List<SceneConfig> getConfigs(string id)
        {
            var url = $"{service}/v1.0/scenes/{id}/configs";
            var client = new HttpClient<List<SceneConfig>>(url);

            return client.getData();
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

            var url = $"{service}/v1.0/scenes/{scene.id}";
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

            var url = $"{service}/v1.0/scenes/{scene.id}";
            var client = new HttpClient<object>(url);

            return client.delete();
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
                {"pageNum", 1},
                {"pageSize", 999}
            };
            var client = new HttpClient<List<LookUpMember>>(url);

            return client.getData(dict);
        }

        /// <summary>
        /// 新增场景配置
        /// </summary>
        /// <param name="config">场景配置实体对象</param>
        /// <returns>场景ID</returns>
        public string addSceneConfig(SceneConfig config)
        {
            if (config == null) return null;

            var url = $"{service}/v1.0/scenes/{config.sceneId}/configs";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, config);
        }

        /// <summary>
        /// 更新场景配置
        /// </summary>
        /// <param name="config">场景配置实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateSceneConfig(SceneConfig config)
        {
            if (config == null) return false;

            var url = $"{service}/v1.0/scenes/configs/{config.id}";
            var client = new HttpClient<object>(url);

            return client.put(config);
        }

        /// <summary>
        /// 删除场景配置
        /// </summary>
        /// <param name="config">场景配置实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteSceneConfig(SceneConfig config)
        {
            if (config == null) return false;

            var url = $"{service}/v1.0/scenes/configs/{config.id}";
            var client = new HttpClient<object>(url);

            return client.delete();
        }
    }
}
