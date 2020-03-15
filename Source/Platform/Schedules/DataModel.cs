using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Schedules
{
    public class DataModel
    {
        private const string service = "/base/message";

        /// <summary>
        /// 获取计划任务集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>计划任务集合</returns>
        public Result<List<Schedule>> getSchedules(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/schedules";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Schedule>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 立即执行指定的计划任务
        /// </summary>
        /// <param name="id">计划任务ID</param>
        /// <returns>是否成功</returns>
        public bool executeSchedule(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            const string msg = "对不起，无法执行选中的计划任务！";
            var url = $"{service}/v1.0/schedules";
            var client = new HttpClient<List<Navigation>>();

            return client.put(url, id, msg);
        }

        /// <summary>
        /// 删除计划任务
        /// </summary>
        /// <param name="id">计划任务ID</param>
        /// <returns>是否删除成功</returns>
        public bool deleteSchedule(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            const string msg = "对不起，无法删除选中的计划任务！";
            var url = $"{service}/v1.0/schedules";
            var client = new HttpClient<object>();

            return client.delete(url, id, msg);
        }

        /// <summary>
        /// 禁用计划任务
        /// </summary>
        /// <param name="id">计划任务ID</param>
        /// <returns>是否成功</returns>
        public bool disableSchedule(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            const string msg = "对不起，无法禁用选中的计划任务！";
            var url = $"{service}/v1.0/schedules/disable";
            var client = new HttpClient<object>();

            return client.put(url, id, msg);
        }

        /// <summary>
        /// 启用计划任务
        /// </summary>
        /// <param name="id">计划任务ID</param>
        /// <returns>是否成功</returns>
        public bool enableSchedule(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            const string msg = "对不起，无法启用选中的计划任务！";
            var url = $"{service}/v1.0/schedules/enable";
            var client = new HttpClient<object>();

            return client.put(url, id, msg);
        }
    }
}
