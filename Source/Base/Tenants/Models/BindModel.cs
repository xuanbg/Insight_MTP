using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Controls;
using Insight.Utils.Models;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class BindModel : BaseModel
    {
        public BindDialog view;

        private readonly Tenant tenant;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data"></param>
        /// <param name="title"></param>
        public BindModel(Tenant data, string title)
        {
            tenant = data;
            view = new BindDialog {Text = title};

            Format.gridFormat(view.gdvApp, 0);
            getApps();
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Tenant save()
        {
            const string msg = "更新绑定应用失败！";

            var list = from r in view.gdvApp.GetSelectedRows()
                       select (App)view.gdvApp.GetRow(r);
            tenant.apps = list.ToList();

            var url = $"{baseServer}/tenantapi/v1.0/tenants/{tenant.id}/apps";
            var ids = tenant.apps.Select(i => i.id);
            var dict = new Dictionary<string, object> {{"apps", ids}};
            var client = new HttpClient<object>(tokenHelper);

            return client.put(url, dict, msg) ? tenant : null;
        }

        /// <summary>
        /// 加载应用列表数据
        /// </summary>
        private void getApps()
        {
            var url = $"{baseServer}/appapi/v1.0/apps/all";
            var client = new HttpClient<List<App>>(tokenHelper);
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
