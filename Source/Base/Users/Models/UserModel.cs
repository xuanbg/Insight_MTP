using System.Collections.Generic;
using Insight.MTP.Client.Base.Users.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Users.Models
{
    public class UserModel : BaseModel
    {
        public UserDialog view;

        private readonly User user;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public UserModel(User data, string title)
        {
            user = data;
            view = new UserDialog
            {
                Text = title,
                txtName = {EditValue = data.name},
                txtAccount = {EditValue = data.account},
                txtMobile = {EditValue = data.mobile},
                txtEmail = {EditValue = data.email},
                memRemark = {EditValue = data.remark}
            };

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => user.name = view.txtName.Text.Trim();
            view.txtAccount.EditValueChanged += (sender, args) => user.account = view.txtAccount.Text.Trim();
            view.txtMobile.EditValueChanged += (sender, args) => user.mobile = view.txtMobile.Text.Trim();
            view.txtEmail.EditValueChanged += (sender, args) => user.email = view.txtEmail.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                user.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        public User AddUser()
        {
            if (!InputExamine()) return null;

            var msg = $"新建用户【{user.name}】失败！";
            var url = $"{server}/userapi/v1.0/users";
            var dict = new Dictionary<string, object> {{"user", user}};
            var client = new HttpClient<User>(token);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        public User EditUser()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新用户【{user.name}】的任何信息！";
            var url = $"{server}/userapi/v1.0/users/{user.id}";
            var dict = new Dictionary<string, object> {{"user", user}};
            var client = new HttpClient<User>(token);
            return client.Put(url, dict, msg) ? user : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool InputExamine()
        {
            if (string.IsNullOrEmpty(user.name))
            {
                Messages.ShowWarning("必须输入用户名！用户名一般是用户的姓名。");
                view.txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(user.account))
            {
                Messages.ShowWarning("必须输入登录名！登录名只能是英文字母组成。");
                view.txtAccount.Focus();
                return false;
            }

            return true;
        }
    }
}
