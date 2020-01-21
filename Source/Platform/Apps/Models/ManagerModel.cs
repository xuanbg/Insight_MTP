using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Apps.Models
{
    public class ManagerModel : BaseMdiModel<App, Manager>
    {
        public Navigation nav;
        public Function fun;

        /// <summary>
        /// 构造ff
        /// </summary>
        public ManagerModel()
        {
            // 订阅界面事件
            view.gdvApp.DoubleClick += (sender, args) => callback("editApp");
            view.TreNav.DoubleClick += (sender, args) => callback("editNav");
            view.gdvFunc.DoubleClick += (sender, args) => callback("editFun");

            view.gdvApp.FocusedRowObjectChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            view.TreNav.FocusedNodeChanged += (sender, args) => navChanged(args.Node);
            view.gdvFunc.FocusedRowObjectChanged += (sender, args) => funChanged(args.FocusedRowHandle);

            // 设置界面样式
            Format.gridFormat(view.gdvApp);
            Format.treeFormat(view.TreNav);
            Format.gridFormat(view.gdvFunc);

        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        public void loadData()
        {
            showWaitForm();
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = handle;
            closeWaitForm();
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


        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void itemChanged(int index)
        {
            handle = index;
            item = index < 0 ? null : list[index];
            if (item != null && item.navs == null) getDetail();

            view.TreNav.DataSource = item?.navs;
            view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
            view.TreNav.ExpandAll();
            if (!(item?.navs?.Any() ?? false)) nav = null;

            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        private void navChanged(TreeListNode node)
        {
            if (node != null)
            {
                var id = node.GetValue("id").ToString();
                nav = item.navs.SingleOrDefault(m => m.id == id);
                if (node.HasChildren) fun = null;
                else if (nav != null) getFuns(id);
            }

            view.grdFunc.DataSource = nav?.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void funChanged(int index)
        {
            fun = index < 0 ? null : nav.functions[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editApp"] = item != null,
                ["deleteApp"] = item != null,
                ["newNav"] = item != null,
                ["editNav"] = nav != null,
                ["deleteNav"] = nav != null,
                ["newFun"] = nav != null,
                ["editFun"] = fun != null,
                ["deleteFun"] = fun != null,
            };
            switchItemStatus(dict);
        }

    }
}