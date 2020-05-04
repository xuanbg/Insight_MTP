using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    public class Scene
    {
        /// <summary>
        /// UUID主键
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 场景编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 配置总数
        /// </summary>
        public int configTotal { get; set; }

        /// <summary>
        /// 模板配置集合
        /// </summary>
        public List<TempConfig> configs { get; set; } = new List<TempConfig>();
    }
}
