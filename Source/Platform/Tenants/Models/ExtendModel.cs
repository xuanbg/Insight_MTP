using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;

namespace Insight.MTP.Client.Base.Tenants.Models
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

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Tenant save()
        {
            var day = (int) view.speDays.Value;
            const string msg = "续租失败！";
            var url = $"/tenantapi/v1.0/tenants/{tenant.id}/expire";
            var dict = new Dictionary<string, object> {{"expire", day}};
            var client = new HttpClient<object>();

            if (!client.put(url, dict, msg)) return null;

            tenant.expireDate = tenant.expireDate.AddDays(day);

            return tenant;
        }
    }
}
