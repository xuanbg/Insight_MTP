using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Data.Dicts.Views;

namespace Insight.MTP.Client.Data.Dicts.Models
{
    public class DictKeyModel : BaseDialogModel<DictKeyDto, DictKeyDialog>
    {

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">Template</param>
        /// <param name="title">view标题</param>
        public DictKeyModel(DictKeyDto data, string title) : base(title)
        {
            item = data;

            view.spiIndex.EditValueChanged += (sender, args) => item.index = (int) view.spiIndex.Value;
            view.txtCode.EditValueChanged += (sender, args) => item.code = view.txtCode.Text.Trim();
            view.txtValue.EditValueChanged += (sender, args) => item.value = view.txtValue.Text.Trim();
            view.mmeExtend.EditValueChanged += (sender, args) => item.extend = view.mmeExtend.EditValue;
            view.mmeRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.mmeRemark.EditValue?.ToString().Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            view.spiIndex.EditValue = item.index;
            view.txtCode.EditValue = item.code;
            view.txtValue.EditValue = item.value;
            view.mmeExtend.EditValue = item.extend;
            view.mmeExtend.EditValue = item.remark;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.value))
            {
                Messages.showWarning("请输入键值！");
                view.txtValue.Select();
                return;
            }

            base.confirm();
        }
    }
}