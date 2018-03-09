using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 姓名/昵称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 注册邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 是否预置：0、自定；1、预置
        /// </summary>
        public bool isBuiltin { get; set; }

        /// <summary>
        /// 是否失效：0、有效；1、失效
        /// </summary>
        public bool isInvalid { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// 授予用户的功能权限
        /// </summary>
        public List<AppTree> funcs { get; set; }

        /// <summary>
        /// 授予用户的数据权限
        /// </summary>
        public List<AppTree> datas { get; set; }
    }

    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string tenantId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string appName { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 是否预置：0、自定；1、预置
        /// </summary>
        public bool isBuiltin { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// 角色成员
        /// </summary>
        public List<RoleMember> members { get; set; }

        /// <summary>
        /// 角色成员用户
        /// </summary>
        public List<MemberUser> memberUsers { get; set; }

        /// <summary>
        /// 角色功能权限
        /// </summary>
        public List<AppTree> funcs { get; set; }

        /// <summary>
        /// 角色数据权限
        /// </summary>
        public List<AppTree> datas { get; set; }
    }

    /// <summary>
    /// 角色成员
    /// </summary>
    public class RoleMember
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        public int nodeType { get; set; }

        /// <summary>
        /// 成员类型（成员类型：1、用户；2、用户组；3、岗位）
        /// </summary>
        public int memberType { get; set; }

        /// <summary>
        /// 成员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string name { get; set; }
    }

    /// <summary>
    /// 应用树
    /// </summary>
    public class AppTree
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
        /// 图标类型
        /// </summary>
        public int nodeType { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 授权
        /// </summary>
        public bool? permit { get; set; }
    }

    public class Region
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 上级区划ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public int grade { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 别名/简称
        /// </summary>
        public string alias { get; set; }
    }
}