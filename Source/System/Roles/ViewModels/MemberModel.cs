using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Roles.ViewModels
{
    public class MemberModel : BaseDialogModel<Member, MemberDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public MemberModel(Member data, string title) : base(title)
        {
            item = data;

        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {

            base.confirm();
        }
    }
}
