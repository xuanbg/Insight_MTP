using System.Collections.Generic;
using Insight.MTP.Client.Base.Users.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Users.Models
{
    public class UserModel
    {
        public UserDialog view;

        private readonly User user;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="user">UserInfo</param>
        /// <param name="title">View标题</param>
        public UserModel(User user, string title)
        {
            this.user = user;
            view = new UserDialog
            {
                Text = title,
                UserName = {EditValue = this.user.name},
                LoginName = {EditValue = this.user.account},
                Description = {EditValue = this.user.remark}
            };

            // 订阅控件事件实现数据双向绑定
            view.UserName.EditValueChanged += (sender, args) => this.user.name = view.UserName.Text.Trim();
            view.LoginName.EditValueChanged += (sender, args) => this.user.account = view.LoginName.Text.Trim();
            view.Description.EditValueChanged += (sender, args) =>
            {
                var text = view.Description.EditValue?.ToString().Trim();
                this.user.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        public User AddUser()
        {
            if (!InputExamine()) return null;

            var msg = $"新建用户【{user.name}】失败！";
            var url = $"{Params.server}/userapi/v1.0/users";
            var dict = new Dictionary<string, object> {{"user", user}};
            var client = new HttpClient<User>(Params.tokenHelper);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        public User EditUser()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新用户【{user.name}】的任何信息！";
            var url = $"{Params.server}/userapi/v1.0/users/{user.id}";
            var dict = new Dictionary<string, object> {{"user", user}};
            var client = new HttpClient<User>(Params.tokenHelper);
            return client.Put(url, dict, msg) ? user : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private bool InputExamine()
        {
            if (string.IsNullOrEmpty(user.name))
            {
                Messages.ShowWarning("必须输入用户名！用户名一般是用户的姓名。");
                view.UserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(user.account))
            {
                Messages.ShowWarning("必须输入登录名！登录名只能是英文字母组成。");
                view.LoginName.Focus();
                return false;
            }

            return true;
        }
    }
}
