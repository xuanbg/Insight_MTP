using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Templates.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Setting.Templates.ViewModels
{
    public class TemplateModel : BaseDialogModel<MessageTemp, TemplateDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public TemplateModel(MessageTemp data, string title) : base(title)
        {
            item = data;

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
            if (string.IsNullOrEmpty(item.title))
            {
                Messages.showWarning("必须输入接口名称！");
                view.txtName.Focus();
                return;
            }


            base.confirm();
        }
    }
}
