using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Data.Apps.Views;

namespace Insight.MTP.Client.Data.Apps.ViewModels
{
    public class FunModel : BaseDialogModel<Function, FunDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public FunModel(Function data, string title) : base(title)
        {
            item = data;

            view.comType.SelectedIndex = item.type;
            view.speIndex.EditValue = item.index;
            view.txtName.EditValue = item.name;
            view.txtAuthCode.EditValue = item.authCodes;
            view.txtMethod.EditValue = item.funcInfo.method;
            view.txtIcon.EditValue = item.funcInfo.iconUrl;
            view.chkGroup.Checked = item.funcInfo.beginGroup;
            view.chkHideText.Checked = item.funcInfo.hideText;

            view.comType.SelectedIndexChanged += (sender, args) => item.type = view.comType.SelectedIndex;
            view.speIndex.EditValueChanged += (sender, args) => item.index = (int)view.speIndex.Value;
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtAuthCode.EditValueChanged += (sender, args) => item.authCodes = view.txtAuthCode.Text.Trim();
            view.txtMethod.EditValueChanged += (sender, args) => item.funcInfo.method = view.txtMethod.Text.Trim();
            view.txtIcon.EditValueChanged += (sender, args) => item.funcInfo.iconUrl = view.txtIcon.Text.Trim();
            view.chkGroup.CheckedChanged += (sender, args) => item.funcInfo.beginGroup = view.chkGroup.Checked;
            view.chkHideText.CheckedChanged += (sender, args) => item.funcInfo.hideText = view.chkHideText.Checked;
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
