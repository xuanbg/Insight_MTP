using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 组织机构
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// 组织机构唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// 节点排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 组织机构编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 组织机构名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 组织机构简称
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 组织机构全称
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 岗位ID
        /// </summary>
        public Guid? PositionId { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool Validity { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 职位成员
        /// </summary>
        public List<MemberUser> Members { get; set; }
    }

    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户唯一ID
        /// </summary>
        public Guid id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string loginName { get; set; }

        /// <summary>
        /// 用户描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 是否内置
        /// </summary>
        public bool builtIn { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool validity { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid creatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// 用户已授权功能权限
        /// </summary>
        public List<RoleAction> Actions { get; set; }

        /// <summary>
        /// 用户已授权数据权限
        /// </summary>
        public List<RoleData> Datas { get; set; }
    }

    /// <summary>
    /// 用户组
    /// </summary>
    public class UserGroup
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 用户组名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户组描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否内置
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 用户组成员
        /// </summary>
        public List<MemberUser> Members { get; set; }
    }

    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否内置
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Validity { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 角色操作权限集合
        /// </summary>
        public List<RoleAction> Actions { get; set; }

        /// <summary>
        /// 角色数据权限集合
        /// </summary>
        public List<RoleData> Datas { get; set; }

        /// <summary>
        /// 角色成员
        /// </summary>
        public List<RoleMember> Members { get; set; }
    }

    /// <summary>
    /// 角色成员
    /// </summary>
    public class RoleMember
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 成员ID
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 节点类型（成员类型：1、用户；2、用户组；3、岗位）
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// 角色操作权限
    /// </summary>
    public class RoleAction
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 父节点ID（数据节点：业务模块ID）
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 模块功能ID
        /// </summary>
        public Guid ActionId { get; set; }

        /// <summary>
        /// 原权限：0、只读；1、读写
        /// </summary>
        public int? Action { get; set; }

        /// <summary>
        /// 新权限：0、只读；1、读写
        /// </summary>
        public int? Permit { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 节点权限情况
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// 角色数据权限
    /// </summary>
    public class RoleData
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 父节点ID（数据节点：业务模块ID）
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 数据授权模式：0、相对模式；1、用户模式；2、部门模式
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// 模式ID或部门/用户ID（绝对模式）
        /// </summary>
        public Guid ModeId { get; set; }

        /// <summary>
        /// 原权限：0、只读；1、读写
        /// </summary>
        public int? Permission { get; set; }

        /// <summary>
        /// 新权限：0、只读；1、读写
        /// </summary>
        public int? Permit { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 节点权限情况
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// 编码方案
    /// </summary>
    public class Coding
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
        /// 编码格式
        /// </summary>
        public string CodeFormat { get; set; }

        /// <summary>
        /// 分组规则
        /// </summary>
        public string SerialFormat { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool Validity { get; set; }

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
        /// 编码记录集合
        /// </summary>
        public List<CodeRecord> Records { get; set; }

        /// <summary>
        /// 编码分配记录集合
        /// </summary>
        public List<CodeAllot> Allots { get; set; }
    }

    /// <summary>
    /// 编码记录
    /// </summary>
    public class CodeRecord
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 分组标识
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// 当前流水
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        public int RecordCount { get; set; }

        /// <summary>
        /// 最新流水创建时间
        /// </summary>
        public DateTime LastRecordTime { get; set; }
    }

    /// <summary>
    /// 号段分配记录
    /// </summary>
    public class CodeAllot
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 拥有者
        /// </summary>
        public string OwnerUser { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 分配号段
        /// </summary>
        public string CodeArea { get; set; }

        /// <summary>
        /// 分配人
        /// </summary>
        public string AllotUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}