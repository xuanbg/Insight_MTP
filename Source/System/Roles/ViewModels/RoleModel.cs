using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.Views;
using System.Collections.Generic;

namespace Insight.MTP.Client.Setting.Roles.ViewModels
{
    public class RoleModel : BaseDialogModel<Role, RoleDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="apps">可选应用集合</param>
        /// <param name="title">View标题</param>
        public RoleModel(Role data, List<LookUpMember> apps, string title) : base(title)
        {
            item = data;
            Format.initLookUpEdit(view.lueApp, apps);

            view.lueApp.EditValue = item.appId;
            view.txtName.EditValue = item.name;
            view.memRemark.EditValue = item.remark;

            view.lueApp.EditValueChanged += (sender, args) =>
            {
                item.appId = view.lueApp.EditValue.ToString();
                item.appName = view.lueApp.Text;
                item.builtin = item.appId != "9dd99dd9e6df467a8207d05ea5581125";
            };
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.appId))
            {
                Messages.showWarning("必须选择一个应用！");
                view.lueApp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入角色名称！");
                view.txtName.Focus();
                return;
            }

            base.confirm();
        }
    }
}
