using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.Base.BaseForm.Utils;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Templates
{
    public class DataModel
    {
        private const string service = "/common/message";

        /// <summary>
        /// 获取计划任务集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>计划任务集合</returns>
        public Result<List<MessageTemp>> getTemplates(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/templates";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<MessageTemp>>();

            return client.getResult(url, dict);
        }
        
        /// <summary>
        /// 新增消息模板
        /// </summary>
        /// <param name="temp">消息模板实体对象</param>
        /// <returns>角色ID</returns>
        public string addTemplate(MessageTemp temp)
        {
            if (temp == null) return null;

            var msg = $"新建消息模板【{temp.title}】失败！";
            var url = $"{service}/v1.0/templates";
            var client = new HttpClient<string>();

            return client.commit(url, temp, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新消息模板
        /// </summary>
        /// <param name="temp">消息模板实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateTemplate(MessageTemp temp)
        {
            if (temp == null) return false;

            var msg = $"更新消息模板【{temp.title}】失败！";
            var url = $"{service}/v1.0/templates";
            var client = new HttpClient<object>();

            return client.put(url, temp, msg);
        }

        /// <summary>
        /// 删除消息模板数据
        /// </summary>
        /// <param name="temp">消息模板对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteTemplate(MessageTemp temp)
        {
            if (temp == null) return false;

            var msg = $"对不起，无法删除消息模板【{temp.title}】！";
            var url = $"{service}/v1.0/templates";
            var client = new HttpClient<object>();

            return client.delete(url, temp.id, msg);
        }

        /// <summary>
        /// 加载消息模板数据
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>是否更新成功</returns>
        public bool disableTemplates(MessageTemp temp)
        {
            var msg = $"对不起，无法禁用消息模板{temp.title}！";
            var url = $"{service}/v1.0/templates/disable";
            var client = new HttpClient<object>();

            return client.put(url, temp.id, msg);
        }

        /// <summary>
        /// 加载消息模板数据
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>是否更新成功</returns>
        public bool enableTemplates(MessageTemp temp)
        {
            var msg = $"对不起，无法启用消息模板{temp.title}！";
            var url = $"{service}/v1.0/templates/enable";
            var client = new HttpClient<object>();

            return client.put(url, temp.id, msg);
        }
    }
}
