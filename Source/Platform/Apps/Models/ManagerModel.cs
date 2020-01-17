using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Platform.Apps.Models
{
    public class ManagerModel : BaseMdiModel<App, Manager>
    {
        public Navigation nav;
        public Function fun;


        /// <summary>
        /// 加载列表数据
        /// </summary>
        public void loadData()
        {
            var url = $"/base/resource/v1.0/apps";
            var client = new HttpClient<List<App>>();
            if (!client.get(url))
            {
                return;
            }

            list = client.data;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">App</param>
        public void addItem(App data)
        {
            list.Add(data);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">App</param>
        public void update(App data)
        {
            Util.copyValue(data, item);
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void addItem(Navigation data)
        {
            item.navs.Add(data);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void update(Navigation data)
        {
            Util.copyValue(data, nav);
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">Function</param>
        public void addItem(Function data)
        {
            nav.functions.Add(data);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">Function</param>
        public void update(Function data)
        {
            Util.copyValue(data, fun);
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除应用【{item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            msg = $"对不起，无法删除应用【{item.name}】！";
            var url = $"/appapi/v1.0/apps/{item.id}";
            var client = new HttpClient<object>();
            if (!client.delete(url, null, msg))
            {
                return;
            }

            list.Remove(item);
            //view.gdvApp.RefreshData();
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void deleteNav()
        {
            var msg = $"您确定要删除导航【{nav.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            msg = $"对不起，无法删除导航【{nav.name}】！";
            var url = $"/appapi/v1.0/apps/navigations/{nav.id}";
            var client = new HttpClient<object>();
            if (!client.delete(url, null, msg))
            {
                return;
            }

            item.navs.Remove(nav);
            //view.TreNav.RefreshDataSource();
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void deleteFun()
        {
            var msg = $"您确定要删除功能【{fun.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            msg = $"对不起，无法删除功能【{fun.name}】！";
            var url = $"/appapi/v1.0/apps/navigations/functions/{fun.id}";
            var client = new HttpClient<object>();
            if (!client.delete(url, null, msg))
            {
                return;
            }

            nav.functions.Remove(fun);
            //view.gdvFunc.RefreshData();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        public void getDetail()
        {
            var url = $"/appapi/v1.0/apps/{item.id}/navigations";
            var client = new HttpClient<List<Navigation>>();
            if (!client.get(url)) return;

            item.navs = client.data;
        }

        /// <summary>
        /// 获取模块功能
        /// </summary>
        /// <param name="id">导航ID</param>
        public void getFuns(string id)
        {
            var url = $"/appapi/v1.0/apps/navigations/{id}/functions";
            var client = new HttpClient<List<Function>>();
            if (!client.get(url)) return;

            nav.functions = client.data;
        }
    }
}