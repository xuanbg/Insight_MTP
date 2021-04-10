using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Data.Dicts.Views;

namespace Insight.MTP.Client.Data.Dicts.ViewModels
{
    public class DictModel : BaseDialogModel<DictDto, DictDialog>
    {

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">Template</param>
        /// <param name="apps">可选应用集合</param>
        /// <param name="title">view标题</param>
        public DictModel(DictDto data, List<LookUpMember> apps, string title) : base(title)
        {
            item = data;

            view.lueApp.EditValue = item.appId;
            view.txtCode.EditValue = item.code;
            view.txtName.EditValue = item.name;
            view.mmeRemark.EditValue = item.remark;

            view.lueApp.EditValueChanged += (sender, args) =>
            {
                item.appId = view.lueApp.EditValue.ToString();
                item.appName = view.lueApp.Text;
            };
            view.txtCode.EditValueChanged += (sender, args) => item.code = view.txtCode.Text.Trim();
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.mmeRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.mmeRemark.EditValue?.ToString().Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            Format.initLookUpEdit(view.lueApp, apps);
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.code))
            {
                Messages.showWarning("请输入编码！");
                view.txtCode.Select();
                return;
            }

            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("请输入名称！");
                view.txtName.Select();
                return;
            }

            base.confirm();
        }
    }
}