using System.Collections.Generic;
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
                {"all", true},
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<Role>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取指定角色的成员集合
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>授权功能集合</returns>
        public List<Member> getRoleMember(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/functions";
            var client = new HttpClient<List<Member>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取指定角色的授权功能集合
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>授权功能集合</returns>
        public List<User> getMemberUsers(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/functions";
            var client = new HttpClient<List<User>>();

            return client.getData(url);
        }

        /// <summary>
        /// 获取指定角色的授权功能集合
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <returns>授权功能集合</returns>
        public List<AppTree> getRoleFuncs(string id)
        {
            var url = $"{service}/v1.0/roles/{id}/functions";
            var client = new HttpClient<List<AppTree>>();

            return client.getData(url);
        }

        /// <summary>
        /// 新增角色信息
        /// </summary>
        /// <param name="role">角色实体对象</param>
        /// <returns>角色ID</returns>
        public string addRole(Role role)
        {
            var msg = $"新建角色【{role.name}】失败！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<string>();

            return client.commit(url, role, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新角色信息
        /// </summary>
        /// <param name="user">角色实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateRole(Role user)
        {
            var msg = $"更新角色【{user.name}】数据失败！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<object>();

            return client.put(url, user, msg);
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="user">角色实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteRole(Role user)
        {
            var msg = $"对不起，无法删除角色【{user.name}】！";
            var url = $"{service}/v1.0/roles";
            var client = new HttpClient<object>();

            return client.delete(url, user.id, msg);
        }

    }
}
