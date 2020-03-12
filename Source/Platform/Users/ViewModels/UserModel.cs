using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Entity;

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
            
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入功能名称！");
                view.txtName.Focus();
                return;
            }

            base.confirm();
        }
    }
}
