using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.Views;
using Insight.Base.BaseForm.ViewModels;
using Insight.Base.BaseForm.Controls;
using Insight.Base.BaseForm.Utils;

namespace Insight.MTP.Client.Setting.Roles.ViewModels
{
    public class MemberModel : BaseDialogModel<Member, MemberDialog>
    {
        public List<Member> members;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="members">可选成员列表</param>
        /// <param name="title">View标题</param>
        public MemberModel(List<Member> members, string title) : base(title)
        {
            view.grdUser.DataSource = members;
            Format.gridFormat(view.gdvUser);
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            var users = from r in view.gdvUser.GetSelectedRows()
                select (Member) view.gdvUser.GetRow(r);
            members = users.ToList();
            if (view.gdvUser.RowCount > 0 && !members.Any())
            {
                Messages.showWarning("请选择成员！");
                return;
            }

            base.confirm();
        }
    }
}
