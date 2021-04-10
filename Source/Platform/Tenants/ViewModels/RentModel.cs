using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class RentModel : BaseDialogModel<TenantApp, RentDialog>
    {
        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public RentModel(TenantApp data, string title) : base(title)
        {
            item = data;

            view.datRent.EditValue = item.expireDate;

            view.datRent.EditValueChanged += (sender, args) => item.expireDate = view.datRent.DateTime;
        }
    }
}
