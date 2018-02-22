using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 导航栏数据
    /// </summary>
    public class NavData
    {
        /// <summary>
        /// 模块组集合
        /// </summary>
        public List<ModuleGroup> Groups { get; set; }

        /// <summary>
        /// 业务模块集合
        /// </summary>
        public List<ModuleInfo> Modules { get; set; }
    }

    /// <summary>
    /// 业务模块组
    /// </summary>
    public class ModuleGroup
    {
        /// <summary>
        /// 模块组唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 组排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] Icon { get; set; }
    }

    /// <summary>
    /// 业务模块
    /// </summary>
    public class ModuleInfo
    {
        /// <summary>
        /// 业务模块唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 所属组ID
        /// </summary>
        public Guid ModuleGroupId { get; set; }

        /// <summary>
        /// 排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 程序名称
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get; set; }

        /// <summary>
        /// 业务模块名称
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// 文件相对路径
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 是否默认加载
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] Icon { get; set; }
    }

    /// <summary>
    /// 模块工具栏按钮
    /// </summary>
    public class ModuleAction
    {
        /// <summary>
        /// 功能操作唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 所属模块ID
        /// </summary>
        public Guid ModuleId { get; set; }

        /// <summary>
        /// 排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] Icon { get; set; }

        /// <summary>
        /// 是否显示按钮文字
        /// </summary>
        public bool ShowText { get; set; }

        /// <summary>
        /// 是否开始分组
        /// </summary>
        public bool BeginGroup { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool Validity { get; set; }
    }
}
