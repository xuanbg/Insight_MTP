using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    public class App
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 应用别名
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 图标url
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        /// 授权码生命周期(毫秒)
        /// </summary>
        public int permitLife { get; set; } = 300;

        /// <summary>
        /// 令牌生命周期(毫秒)
        /// </summary>
        public int tokenLife { get; set; } = 7200;

        /// <summary>
        /// 是否单设备登录
        /// </summary>
        public bool signinOne { get; set; }

        /// <summary>
        /// 是否自动刷新Token
        /// </summary>
        public bool autoRefresh { get; set; }

        /// <summary>
        /// 是否自动加载租户
        /// </summary>
        public bool autoTenant { get; set; }
        
        /// <summary>
        /// 导航集合
        /// </summary>
        public List<Navigation> navigations { get; set; }
    }
}
