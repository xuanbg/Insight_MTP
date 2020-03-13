using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.System.Roles
{
    public class DataModel
    {
        private const string service = "/base/user/manage";

        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>用户集合</returns>
        public Result<List<Role>> getUsers(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/users";
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
        /// 获取指定用户的授权功能集合
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns>授权功能集合</returns>
        public List<User> getFuncs(string id)
        {
            var url = $"{service}/v1.0/users/{id}/functions";
            var client = new HttpClient<List<User>>();

            return client.getData(url);
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="role">用户实体对象</param>
        /// <returns>用户ID</returns>
        public string addUser(Role role)
        {
            var msg = $"新建用户【{role.name}】失败！";
            var url = $"{service}/v1.0/users";
            var client = new HttpClient<string>();

            return client.commit(url, role, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateUser(Role user)
        {
            var msg = $"更新用户【{user.name}】数据失败！";
            var url = $"{service}/v1.0/users";
            var client = new HttpClient<object>();

            return client.put(url, user, msg);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteUser(Role user)
        {
            var msg = $"对不起，无法删除用户【{user.name}】！";
            var url = $"{service}/v1.0/users";
            var client = new HttpClient<object>();

            return client.delete(url, user.id, msg);
        }

    }
}
