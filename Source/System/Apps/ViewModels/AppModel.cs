using System;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Setting.Apps.ViewModels
{
    public class AppModel : BaseDialogModel<App, AppDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public AppModel(App data, string title) : base(title)
        {
            item = data;

            view.txtName.EditValue = item.name;
            view.txtAlias.EditValue = item.alias;
            view.txtHost.EditValue = item.domain;
            view.txtTokenLife.EditValue = item.tokenLife / 1000;
            view.txtPermitLife.EditValue = item.permitLife / 1000;
            view.spiIndex.EditValue = item.index;
            view.cheSigninOne.Checked = item.signinOne;
            view.cheAutoRefresh.Checked = item.autoRefresh;

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => item.alias = view.txtAlias.Text.Trim();
            view.txtHost.EditValueChanged += (sender, args) => item.domain = view.txtHost.Text.Trim();
            view.txtPermitLife.EditValueChanged += (sender, args) => item.permitLife = 1000 * Convert.ToInt32(view.txtPermitLife.Text.Trim());
            view.txtTokenLife.EditValueChanged += (sender, args) => item.tokenLife = 1000 * Convert.ToInt32(view.txtTokenLife.Text.Trim());
            view.spiIndex.ValueChanged += (sender, args) => item.index = (int) view.spiIndex.Value;
            view.cheSigninOne.CheckedChanged += (sender, args) => item.signinOne = view.cheSigninOne.Checked;
            view.cheAutoRefresh.CheckedChanged += (sender, args) => item.autoRefresh = view.cheAutoRefresh.Checked;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入应用名称！");
                view.txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.alias))
            {
                Messages.showWarning("必须输入简称！");
                view.txtAlias.Focus();
                return;
            }

            base.confirm();
        }
    }
}
