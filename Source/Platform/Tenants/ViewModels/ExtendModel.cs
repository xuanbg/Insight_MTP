using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class ExtendModel : BaseDialogModel<object, ExtendDialog>
    {

        private readonly Tenant tenant;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public ExtendModel(Tenant data, string title) : base(title)
        {
            tenant = data;
        }
        
    }
}
