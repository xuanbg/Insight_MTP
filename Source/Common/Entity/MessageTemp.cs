using Insight.Base.BaseForm.Utils;

namespace Insight.MTP.Client.Common.Entity
{
    public class MessageTemp
    {

        /// <summary>
        /// UUID主键
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string tenantId { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 消息标签
        /// </summary>
        [InputCheck(true, "消息标签不能为空")]
        public string tag { get; set; }

        /// <summary>
        /// 发送类型:0.未定义;1.仅消息(0001);2.仅推送(0010);3.推送+消息(0011);4.仅短信(0100);8.仅邮件(1000)
        /// </summary>
        [InputCheck("发送类型不能为空")]
        public int type { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        [InputCheck(true, "消息标题不能为空")]
        public string title { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [InputCheck(true, "消息内容不能为空")]
        public string content { get; set; }

        /// <summary>
        /// 消息有效时长(小时)
        /// </summary>
        public int? expire { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 是否失效:0.正常;1.失效
        /// </summary>
        public bool invalid { get; set; }
    }
}
