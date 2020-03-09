using System;

namespace Insight.MTP.Client.Common.Entity
{
    public class TenantApp
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// 应用名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        public DateTime expireDate { get; set; }
    }
}
