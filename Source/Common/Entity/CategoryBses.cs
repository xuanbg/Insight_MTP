using System;

namespace Insight.MTP.Client.Common.Entity
{
    public class CategoryBses
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 父分类ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 业务模块ID
        /// </summary>
        public Guid ModuleId { get; set; }

        /// <summary>
        /// 排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }
    }
}
