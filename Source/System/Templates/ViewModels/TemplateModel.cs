using System;
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

            view.lueType.EditValue = item.type;
            view.txtTag.EditValue = item.tag;
            view.spiExpire.EditValue = item.expire;
            view.txtTitle.EditValue = item.title;
            view.memContent.EditValue = item.content;
            view.memRemark.EditValue = item.remark;

            view.lueType.EditValueChanged += (sender, args) => item.type =  Convert.ToInt32(view.lueType.EditValue);
            view.txtTag.EditValueChanged += (sender, args) => item.tag = view.txtTag.Text.Trim();
            view.spiExpire.EditValueChanged += (sender, args) => item.expire = (int?) view.spiExpire.Value;
            view.txtTitle.EditValueChanged += (sender, args) => item.title = view.txtTitle.Text.Trim();
            view.memContent.EditValueChanged += (sender, args) =>
            {
                var text = view.memContent.Text.Trim();
                item.content = string.IsNullOrEmpty(text) ? null : text;
            };
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
            if (item.type == 0)
            {
                Messages.showWarning("必须选择消息发送类型！");
                view.lueType.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.tag))
            {
                Messages.showWarning("必须输入消息标签！");
                view.txtTag.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.title))
            {
                Messages.showWarning("必须输入模板标题！");
                view.txtTitle.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.content))
            {
                Messages.showWarning("必须输入模板文案！");
                view.memContent.Focus();
                return;
            }

            base.confirm();
        }
    }
}
