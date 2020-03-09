namespace Insight.MTP.Client.Common.Entity
{
    public class TenantUser
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 用户E-mail
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 用户是否失效
        /// </summary>
        public bool invalid { get; set; }
    }
}
