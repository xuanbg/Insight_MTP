using System.Collections.Generic;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Interfaces
{
    public class DataModel
    {
        private const string service = "/common/config";

        /// <summary>
        /// 获取计划任务集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>计划任务集合</returns>
        public Result<List<Interface>> getInterfaces(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/configs";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Interface>>(url);

            return client.getResult(dict);
        }
        
        /// <summary>
        /// 新增接口配置
        /// </summary>
        /// <param name="config">接口配置实体对象</param>
        /// <returns>角色ID</returns>
        public string addInterface(Interface config)
        {
            if (config == null) return null;

            var url = $"{service}/v1.0/configs";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, config);
        }

        /// <summary>
        /// 更新接口配置
        /// </summary>
        /// <param name="config">接口配置实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateInterface(Interface config)
        {
            if (config == null) return false;

            var url = $"{service}/v1.0/configs";
            var client = new HttpClient<object>(url);

            return client.put(config);
        }

        /// <summary>
        /// 删除接口配置数据
        /// </summary>
        /// <param name="config">接口配置对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteInterface(Interface config)
        {
            if (config == null) return false;

            var url = $"{service}/v1.0/configs";
            var client = new HttpClient<object>(url);

            return client.delete(config.id);
        }

        /// <summary>
        /// 加载接口配置数据
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool loadInterfaces()
        {
            var url = $"{service}/v1.0/configs/load";
            var client = new HttpClient<object>(url);

            return client.get();
        }
    }
}
