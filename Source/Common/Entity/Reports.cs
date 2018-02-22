using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 报表分类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Category<T>
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

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否内置
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// 创建部门ID
        /// </summary>
        public Guid? CreatorDeptId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 焦点行
        /// </summary>
        public int Handle { get; set; }

        /// <summary>
        /// 成员总数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 分类成员集合
        /// </summary>
        public List<T> Members { get; set; }
    }

    /// <summary>
    /// 报表
    /// </summary>
    public class ReportDef
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// 分期模式
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// 延时(小时)
        /// </summary>
        public int Delay { get; set; }

        /// <summary>
        /// 报表类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建部门ID
        /// </summary>
        public Guid? CreatorDeptId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 报表分期
        /// </summary>
        public List<Period> Periods { get; set; }

        /// <summary>
        /// 会计主体
        /// </summary>
        public List<Entity> Entities { get; set; }

        /// <summary>
        /// 报表成员（角色）
        /// </summary>
        public List<Subscriber> Members { get; set; }
    }

    /// <summary>
    /// 报表模板
    /// </summary>
    public class Template
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建部门ID
        /// </summary>
        public Guid? CreatorDeptId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 分期规则
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        public int CycleType { get; set; }

        /// <summary>
        /// 周期数
        /// </summary>
        public int? Cycle { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        public string CycleInfo
        {
            get
            {
                var cycle = "";
                switch (CycleType)
                {
                    case 1:
                        cycle = "年";
                        break;
                    case 2:
                        cycle = "月";
                        break;
                    case 3:
                        cycle = "周";
                        break;
                    case 4:
                        cycle = "日";
                        break;
                }
                return Cycle.HasValue || Cycle > 0 ? $"{Cycle} {cycle}" : null;
            }
        }

        /// <summary>
        /// 起始日期
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// 是否内置
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// 创建部门ID
        /// </summary>
        public Guid? CreatorDeptId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 报表实例
    /// </summary>
    public class Instance
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 报表ID
        /// </summary>
        public Guid ReportId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 报表分期
    /// </summary>
    public class Period
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 分期规则ID
        /// </summary>
        public Guid RuleId { get; set; }

        /// <summary>
        /// 分期规则名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        public string CycleInfo { get; set; }
    }

    /// <summary>
    /// 会计主体
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 组织机构ID
        /// </summary>
        public Guid OrgId { get; set; }

        /// <summary>
        /// 组织机构名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// 报表订阅者
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 会计主体ID
        /// </summary>
        public Guid EntityId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}