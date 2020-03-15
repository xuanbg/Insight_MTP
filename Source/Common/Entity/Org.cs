namespace Insight.MTP.Client.Common.Entity
{
    public class Org
    {
        /// <summary>
        /// 成员ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 图标类型
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string name { get; set; }
    }
}
