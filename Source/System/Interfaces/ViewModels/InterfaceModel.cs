using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Interfaces.Views;

namespace Insight.MTP.Client.Setting.Interfaces.ViewModels
{
    public class InterfaceModel : BaseDialogModel<Interface, InterfaceDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public InterfaceModel(Interface data, string title) : base(title)
        {
            item = data;

            view.txtName.EditValue = item.name;
            view.cbeMethod.EditValue = item.method;
            view.txtUrl.EditValue = item.url;
            view.txtAuth.EditValue = item.authCode;
            view.memRemark.EditValue = item.remark;

            view.cheVerify.Checked = item.verify;
            view.cheLogResult.Checked = item.logResult;
            view.cheNeedToken.Checked = item.needToken;
            view.cheLimit.Checked = item.limit;

            view.panLimit.Visible = item.limit;
            view.spiGap.EditValue = item.limitGap;
            view.txtCycle.EditValue = item.limitCycle;
            view.txtMax.EditValue = item.limitMax;
            view.txtMessage.EditValue = item.message;
          
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.cbeMethod.SelectedIndexChanged += (sender, args) => item.method = view.cbeMethod.Text.Trim();
            view.txtUrl.EditValueChanged += (sender, args) => item.url = view.txtUrl.Text.Trim();
            view.txtAuth.EditValueChanged += (sender, args) => item.authCode = view.txtAuth.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            view.cheVerify.CheckedChanged += (sender, args) => item.verify = view.cheVerify.Checked;
            view.cheLogResult.CheckedChanged += (sender, args) => item.logResult = view.cheLogResult.Checked;
            view.cheNeedToken.CheckedChanged += (sender, args) => item.needToken = view.cheNeedToken.Checked;
            view.cheLimit.CheckedChanged += (sender, args) =>
            {
                var limit = view.cheLimit.Checked;
                view.panLimit.Visible = limit;
                item.limit = limit;
                if (limit) return;

                view.spiGap.EditValue = null;
                view.txtCycle.EditValue = null;
                view.txtMax.EditValue = null;
                view.txtMessage.EditValue = null;
            };

            view.spiGap.EditValueChanged += (sender, args) => item.limitGap = (int?) view.spiGap.Value;
            view.txtCycle.EditValueChanged += (sender, args) => item.limitCycle = (int?) view.txtCycle.EditValue;
            view.txtMax.EditValueChanged += (sender, args) => item.limitMax = (int?) view.txtMax.EditValue;
            view.txtMessage.EditValueChanged += (sender, args) => item.message = view.txtMessage.Text.Trim();
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入接口名称！");
                view.txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.url))
            {
                Messages.showWarning("接口URL不能为空！");
                view.txtUrl.Focus();
                return;
            }

            if (item.limit && item.limitGap == null && (item.limitMax == null || item.limitCycle == null))
            {
                Messages.showWarning("必须配置限流参数！");
                view.spiGap.Focus();
                return;
            }

            base.confirm();
        }
    }
}
