using Insight.Base.BaseForm.Utils;

namespace Insight.MTP.Client.Common.Entity
{
    public class Interface
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 接口名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 接口HTTP请求方法
        /// </summary>
        public string method { get; set; } = "GET";

        /// <summary>
        /// 接口URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 接口授权码
        /// </summary>
        public string authCode { get; set; }

        /// <summary>
        /// 访问最小时间间隔(秒),0表示无调用时间间隔
        /// </summary>
        public int? limitGap { get; set; } = 1;

        /// <summary>
        /// 限流周期(秒),null表示不进行周期性限流
        /// </summary>
        public int? limitCycle { get; set; }

        /// <summary>
        /// 限制次数/限流周期,null表示不进行周期性限流
        /// </summary>
        public int? limitMax { get; set; }

        /// <summary>
        /// 限流消息
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 接口描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 是否需要一次性Token
        /// </summary>
        public bool needToken { get; set; }

        /// <summary>
        /// 是否验证Token
        /// </summary>
        [InputCheck("接口验证设置不能为空")]
        public bool verify { get; set; } = true;

        /// <summary>
        /// 是否限流
        /// </summary>
        [InputCheck("接口限流设置不能为空")]
        public bool limit { get; set; } = true;

        /// <summary>
        /// 是否通过日志输出返回值
        /// </summary>
        public bool logResult { get; set; }
    }
}
