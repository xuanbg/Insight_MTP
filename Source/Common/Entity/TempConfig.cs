namespace Insight.MTP.Client.Common.Entity
{
    public class TempConfig
    {
        /// <summary>
        /// UUID主键
        /// </summary>
        public string id{ get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        public string sceneId{ get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public string templateId{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string template{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string appName{ get; set; }

        /// <summary>
        /// 合作伙伴编码
        /// </summary>
        public string partnerCode{ get; set; }

        /// <summary>
        /// 合作伙伴名称
        /// </summary>
        public string partner{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string sign{ get; set; }
    }
}
