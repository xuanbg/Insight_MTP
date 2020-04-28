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
            var client = new HttpClient<List<Scene>>();

            return client.getResult(url, dict);
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
            var client = new HttpClient<List<TempConfig>>();

            return client.getResult(url, dict);
        }
        
        /// <summary>
        /// 新增场景信息
        /// </summary>
        /// <param name="Scene">场景实体对象</param>
        /// <returns>场景ID</returns>
        public string addScene(Scene Scene)
        {
            if (Scene == null) return null;

            var msg = $"新建场景【{Scene.name}】失败！";
            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<string>();

            return client.commit(url, Scene, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新场景信息
        /// </summary>
        /// <param name="Scene">场景实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateScene(Scene Scene)
        {
            if (Scene == null) return false;

            var msg = $"更新场景【{Scene.name}】数据失败！";
            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<object>();

            return client.put(url, Scene, msg);
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="Scene">场景实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteScene(Scene Scene)
        {
            if (Scene == null) return false;

            var msg = $"对不起，无法删除场景【{Scene.name}】！";
            var url = $"{service}/v1.0/scenes";
            var client = new HttpClient<object>();

            return client.delete(url, Scene.id, msg);
        }

        /// <summary>
        /// 获取模板集合
        /// </summary>
        /// <returns>应用集合</returns>
        public List<MessageTemp> getTemplates()
        {
            var url = $"{service}/v1.0/templates";
            var dict = new Dictionary<string, object>
            {
                {"page", 1},
                {"size", 999}
            };
            var client = new HttpClient<List<MessageTemp>>();

            return client.getData(url, dict);
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
            var client = new HttpClient<List<LookUpMember>>();

            return client.getData(url, dict);
        }

        /// <summary>
        /// 绑定模板
        /// </summary>
        /// <param name="config">场景模板实体对象</param>
        /// <returns>是否成功</returns>
        public string bindTemps(TempConfig config)
        {
            if (config == null) return null;

            var url = $"{service}/v1.0/scenes/configs";
            var client = new HttpClient<string>();

            return client.commit(url, config, RequestMethod.POST);
        }

        /// <summary>
        /// 解绑模板
        /// </summary>
        /// <param name="config">场景模板实体对象</param>
        /// <returns>是否成功</returns>
        public bool unbindTemp(TempConfig config)
        {
            if (config == null) return false;

            var msg = $"对不起，模板【{config.template}】解除绑定失败！";
            var url = $"{service}/v1.0/scenes/configs";
            var client = new HttpClient<object>();

            return client.delete(url, config.id, msg);
        }
    }
}
