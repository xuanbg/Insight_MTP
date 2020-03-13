using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.System.Roles.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.System.Roles.ViewModels
{
    public class WizardModel : BaseWizardModel<Role, Wizard>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public WizardModel(Role data, string title) : base(title)
        {
            item = data;
            
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {

            base.confirm();
        }
    }
}
