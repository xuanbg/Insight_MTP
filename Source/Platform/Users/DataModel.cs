using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;
using Insight.MTP.Client.Common.Entity;
using Insight.Base.BaseForm.Utils;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Users
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
        public Result<List<User>> getUsers(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/users";
            var dict = new Dictionary<string, object>
            {
                {"all", true},
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<User>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取指定用户的授权功能集合
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns>授权功能集合</returns>
        public List<AppTree> getFuncs(string id)
        {
            var url = $"{service}/v1.0/users/{id}/functions";
            var client = new HttpClient<List<AppTree>>(url);

            return client.getData();
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>用户ID</returns>
        public string addUser(User user)
        {
            if (user == null) return null;

            var url = $"{service}/v1.0/users";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, user);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否更新成功</returns>
        public bool updateUser(User user)
        {
            if (user == null) return false;

            var url = $"{service}/v1.0/users";
            var client = new HttpClient<object>(url);

            return client.put(user);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否删除成功</returns>
        public bool deleteUser(User user)
        {
            if (user == null) return false;

            var url = $"{service}/v1.0/users";
            var client = new HttpClient<object>(url);

            return client.delete(user.id);
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否成功</returns>
        public bool disableUser(User user)
        {
            if (user == null) return false;

            var url = $"{service}/v1.0/users/disable";
            var client = new HttpClient<object>(url);

            return client.put(user.id);
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否成功</returns>
        public bool enableUser(User user)
        {
            if (user == null) return false;

            var url = $"{service}/v1.0/users/enable";
            var client = new HttpClient<object>(url);

            return client.put(user.id);
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="user">用户实体对象</param>
        /// <returns>是否成功</returns>
        public bool resetPassword(User user)
        {
            if (user == null) return false;

            var url = $"{service}/v1.0/users/password";
            var data = new PasswordDto {id = user.id};
            var client = new HttpClient<object>(url);

            return client.put(data);
        }
    }
}
