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
        public UserDialog View;

        private readonly User _User;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="user">UserInfo</param>
        /// <param name="title">View标题</param>
        public UserModel(User user, string title)
        {
            _User = user;
            View = new UserDialog
            {
                Text = title,
                UserName = {EditValue = _User.name},
                LoginName = {EditValue = _User.account},
                Description = {EditValue = _User.remark}
            };

            // 订阅控件事件实现数据双向绑定
            View.UserName.EditValueChanged += (sender, args) => _User.name = View.UserName.Text.Trim();
            View.LoginName.EditValueChanged += (sender, args) => _User.account = View.LoginName.Text.Trim();
            View.Description.EditValueChanged += (sender, args) =>
            {
                var text = View.Description.EditValue?.ToString().Trim();
                _User.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        public User AddUser()
        {
            if (!InputExamine()) return null;

            var msg = $"新建用户【{_User.name}】失败！";
            var url = $"{Params.tokenHelper.baseServer}/userapi/v1.0/users";
            var dict = new Dictionary<string, object> {{"user", _User}};
            var client = new HttpClient<User>(Params.tokenHelper);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        public User EditUser()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新用户【{_User.name}】的任何信息！";
            var url = $"{Params.tokenHelper.baseServer}/userapi/v1.0/users/{_User.id}";
            var dict = new Dictionary<string, object> {{"user", _User}};
            var client = new HttpClient<User>(Params.tokenHelper);
            return client.Put(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private bool InputExamine()
        {
            if (string.IsNullOrEmpty(_User.name))
            {
                Messages.ShowWarning("必须输入用户名！用户名一般是用户的姓名。");
                View.UserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(_User.account))
            {
                Messages.ShowWarning("必须输入登录名！登录名只能是英文字母组成。");
                View.LoginName.Focus();
                return false;
            }

            return true;
        }
    }
}
