using System;
using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Dialogs;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Models
{
    public class MemberModel
    {
        public Member view;
        public List<string> selectedList;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title">View标题</param>
        public MemberModel(string title)
        {
            view = new Member {Text = title};

            Format.GridFormat(view.GdvSelect, 0);
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        public bool InputExamine()
        {
            selectedList = (from i in view.GdvSelect.GetSelectedRows()
                            let g = (LookUpMember)view.GdvSelect.GetRow(i)
                            select g.id).ToList();
            if (selectedList.Any()) return true;

            Messages.ShowWarning("当前未选中任何成员！");
            return false;
        }
    }
}