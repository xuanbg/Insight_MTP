namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 导航栏数据
    /// </summary>
    public class Navigation
    {   
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 上级导航ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 导航名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string filePath { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] icon { get; set; }

        /// <summary>
        /// 是否默认启动：0、否；1、是
        /// </summary>
        public bool isDefault { get; set; }
    }

    /// <summary>
    /// 模块工具栏按钮
    /// </summary>
    public class Function
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
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] icon { get; set; }

        /// <summary>
        /// 是否开始分组：0、否；1、是
        /// </summary>
        public bool isBegin { get; set; }

        /// <summary>
        /// 是否显示文字：0、隐藏；1、显示
        /// </summary>
        public bool isShowText { get; set; }

        /// <summary>
        /// 是否启用状态
        /// </summary>
        public bool permit { get; set; }
    }
}
