using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 唯一ID
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
        public bool builtin { get; set; }

        /// <summary>
        /// 角色权限
        /// </summary>
        public List<AppTree> funcs { get; set; }

        /// <summary>
        /// 成员用户
        /// </summary>
        public List<User> users { get; set; }
    }

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
        public bool builtin { get; set; }

        /// <summary>
        /// 是否失效：0、有效；1、失效
        /// </summary>
        public bool invalid { get; set; }
        
        /// <summary>
        /// 授予用户的功能权限
        /// </summary>
        public List<AppTree> funcs { get; set; }

        /// <summary>
        /// 授予用户的数据权限
        /// </summary>
        public List<AppTree> datas { get; set; }
    }

    public class Member
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
        public int type { get; set; }

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
        public int type { get; set; }

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
        /// 授权状态
        /// </summary>
        public bool? permit { get; set; }
    }
}