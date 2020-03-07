namespace Insight.MTP.Client.Common.Entity
{
    public class Resource
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 级别:0.应用;1.一级导航;2.二级导航;3.功能
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 图标url
        /// </summary>
        public string icon { get; set; }
    }
}
