using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class BindModel : BaseDialogModel<object, BindDialog>
    {

        private readonly Tenant tenant;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data"></param>
        /// <param name="title"></param>
        public BindModel(Tenant data, string title) : base(title)
        {
            tenant = data;

            Format.gridFormat(view.gdvApp, 0);
            getApps();
        }
        
        /// <summary>
        /// 加载应用列表数据
        /// </summary>
        private void getApps()
        {
            var url = $"/appapi/v1.0/apps/all";
            var client = new HttpClient<List<App>>();
            client.get(url);

            view.grdApp.DataSource = client.data;
            for (var i = 0; i < view.gdvApp.RowCount; i++)
            {
                var row = (App) view.gdvApp.GetRow(i);
                if (tenant.apps.All(t => t.id != row.id)) continue;

                view.gdvApp.SelectRow(i);
            }
        }
    }
}
