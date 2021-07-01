using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Insight.MTP.Client.Setting.Roles
{
    public class DataModel
    {
        private const string service = "/base/role";

        /// <summary>
        /// 获取角色集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>角色集合</returns>
        public Result<List<Role>> getRoles(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/roles";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Role>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定角色的成员
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>成员集合</returns>
        public List<Member> getRoleMember(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<List<Member>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取指定角色的成员用户
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>成员用户集合</returns>
        public Result<List<User>> getMemberUsers(string id, int page, int size)
        {
            var url = $"{service}/v1.0/roles/{id}/users";
            var dict = new Dictionary<string, object>
            {
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<User>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定角色的授权功能集合
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>授权功能集合</returns>
        public List<AppTree> getRoleFuncs(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/funcs";
            var client = new HttpClient<List<AppTree>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取角色可用应用集合
        /// </summary>
        /// <returns>应用集合</returns>
        public List<LookUpMember> getRoleApps()
        {
            var url = $"{service}/v1.0/apps";
            var client = new HttpClient<List<LookUpMember>>(url);

            return client.getData();
        }

        /// <summary>
        /// 获取角色可选用户成员
        /// </summary>
        /// <returns>用户成员集合</returns>
        public List<Member> getMemberOfUser(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/users/other";
            var client = new HttpClient<List<Member>>(url);

            return client.getData();
        }

        /// <summary>
        /// 新增角色信息
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>角色ID</returns>
        public string addRole(Role role)
        {
            if (role == null) return null;

            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, role);
        }

        /// <summary>
        /// 更新角色信息
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateRole(Role role)
        {
            if (role == null) return false;

            var url = $"{service}/v1.0/roles/{role.id}";
            var client = new HttpClient<object>(url);

            return client.put(role);
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteRole(Role role)
        {
            if (role == null) return false;

            var url = $"{service}/v1.0/roles/{role.id}";
            var client = new HttpClient<object>(url);

            return client.delete();
        }

        /// <summary>
        /// 添加角色成员
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="members">角色成员实体对象集合</param>
        /// <returns>是否成功</returns>
        public bool addMember(string id, List<Member> members)
        {
            if (!members.Any()) return false;

            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<object>(url);

            return client.post(members);
        }

        /// <summary>
        /// 移除角色成员
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="member">角色成员实体对象</param>
        /// <returns>是否成功</returns>
        public bool removeMember(string id, Member member)
        {
            if (string.IsNullOrEmpty(id) || member == null) return false;

            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<object>(url);

            return client.delete(member);
        }

        /// <summary>
        /// 设置角色功能权限
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="permit">授权实体</param>
        /// <returns>是否成功</returns>
        public bool setFuncPermit(string id, AppTree permit)
        {
            if (string.IsNullOrEmpty(id)) return false;

            var url = $"{service}/v1.0/roles/{id}/funcs";
            var client = new HttpClient<object>(url);

            return client.put(permit);
        }
    }
}
