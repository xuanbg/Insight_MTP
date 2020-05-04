using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    public class Tenant
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 租户别名
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        public CompanyInfo companyInfo { get; set; } = new CompanyInfo();

        /// <summary>
        /// 描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 租户状态：0、待审核；1、已通过；2、未通过
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 是否失效：0、正常；1、失效
        /// </summary>
        public bool invalid { get; set; }
        
        /// <summary>
        /// 创建人ID
        /// </summary>
        public List<TenantApp> apps { get; set; } = new List<TenantApp>();

        /// <summary>
        /// 用户总数
        /// </summary>
        public int userTotal { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public List<TenantUser> users { get; set; } = new List<TenantUser>();
    }
}
