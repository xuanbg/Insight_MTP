using System;

namespace Insight.MTP.Client.Common.Entity
{
    public class Schedule
    {
        /// <summary>
        /// UUID主键
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 任务类型:0.消息;1.本地调用;2.远程调用
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 调用方法
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// 调用方法
        /// </summary>
        public DateTime taskTime { get; set; }

        /// <summary>
        /// 累计执行次数
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// 累计执行次数
        /// </summary>
        public bool invalid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createdTime { get; set; }
    }
}
