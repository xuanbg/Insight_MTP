using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Base.BaseForm.ViewModels;

namespace Insight.MTP.Client.Platform.Users.ViewModels
{
    public class UserModel : BaseDialogModel<User, UserDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public UserModel(User data, string title) : base(title)
        {
            item = data;

            view.txtName.EditValue = item.name;
            view.txtAccount.EditValue = item.account;
            view.txtMobile.EditValue = item.mobile;
            view.txtEmail.EditValue = item.email;
            view.memRemark.EditValue = item.remark;

            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtAccount.EditValueChanged += (sender, args) => item.account = view.txtAccount.Text.Trim();
            view.txtMobile.EditValueChanged += (sender, args) => item.mobile = view.txtMobile.Text.Trim();
            view.txtEmail.EditValueChanged += (sender, args) => item.email = view.txtEmail.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入用户名称！");
                view.txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.account))
            {
                Messages.showWarning("必须输入登录账号！");
                view.txtAccount.Focus();
                return;
            }

            base.confirm();
        }
    }
}
