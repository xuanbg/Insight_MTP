using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

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
            var client = new HttpClient<List<Role>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取指定角色的成员
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>成员集合</returns>
        public List<Member> getRoleMember(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<List<Member>>();

            return client.getData(url);
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
            var client = new HttpClient<List<User>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取指定角色的授权功能集合
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>授权功能集合</returns>
        public List<AppTree> getRoleFuncs(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/funcs";
            var client = new HttpClient<List<AppTree>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取角色可用应用集合
        /// </summary>
        /// <returns>应用集合</returns>
        public List<LookUpMember> getRoleApps()
        {
            var url = $"{service}/v1.0/apps";
            var client = new HttpClient<List<LookUpMember>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取角色可选用户成员
        /// </summary>
        /// <returns>用户成员集合</returns>
        public List<Member> getMemberOfUser(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/users/other";
            var client = new HttpClient<List<Member>>();

            return client.getData(url);
        }

        /// <summary>
        /// 新增角色信息
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>角色ID</returns>
        public string addRole(Role role)
        {
            if (role == null) return null;

            var msg = $"新建角色【{role.name}】失败！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<string>();

            return client.commit(url, role, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新角色信息
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateRole(Role role)
        {
            if (role == null) return false;

            var msg = $"更新角色【{role.name}】数据失败！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<object>();

            return client.put(url, role, msg);
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteRole(Role role)
        {
            if (role == null) return false;

            var msg = $"对不起，无法删除角色【{role.name}】！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<object>();

            return client.delete(url, role.id, msg);
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

            var msg = "对不起，添加角色成员失败！";
            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<object>();

            return client.post(url, members, msg);
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

            var msg = $"对不起，无法移除角色成员【{member.name}】！";
            var url = $"{service}/v1.0/roles/{id}/members";
            var client = new HttpClient<object>();

            return client.delete(url, member, msg);
        }

        /// <summary>
        /// 设置角色功能权限
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="funcId">功能ID</param>
        /// <param name="permit">授权状态</param>
        /// <returns>是否成功</returns>
        public bool setFuncPermit(string id, string funcId, bool? permit)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(funcId)) return false;

            var msg = $"对不起，设置功能权限失败！";
            var url = $"{service}/v1.0/roles/{id}/funcs";
            var data = new Dictionary<string, object> {{"id", funcId}, {"permit", permit}};
            var client = new HttpClient<object>();

            return client.put(url, data, msg);
        }
    }
}
