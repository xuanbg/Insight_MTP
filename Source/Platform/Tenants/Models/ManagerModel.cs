using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class ManagerModel : BaseMdiModel<Tenant, Manager>
    {

        public int rows = 20;
        public int total;
        public string key;

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void loadData(int page = 1, int handel = 0)
        {
            var url = $"/tenantapi/v1.0/tenants";
            var dict = new Dictionary<string, object>
            {
                {"key", key},
                {"page", page},
                {"rows", rows}
            };
            var client = new HttpClient<List<Tenant>>();
            if (!client.get(url, dict))
            {
                return;
            }
            total = int.Parse(client.option.ToString());
            list = client.data;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data"></param>
        public void addItem(Tenant data)
        {
            list.Add(data);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">UserInfo</param>
        public void update(Tenant data)
        {
            Util.copyValue(data, item);
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除租户【{item.name}】吗？\r\n租户删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            msg = $"对不起，无法租除用户【{item.name}】！";
            var url = $"/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<object>();
            if (!client.delete(url, null, msg))
            {
                return;
            }

            list.Remove(item);
            //view.tabTenant.removeItems();
            //view.gdvTenant.RefreshData();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        public void getDetail()
        {
            var url = $"/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<Tenant>();
            if (!client.get(url)) return;

            item.apps = client.data.apps;
            item.users = client.data.users;
        }
    }
}