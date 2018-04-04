using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Base.Apps.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;
using Insight.Utils.Models;

namespace Insight.MTP.Client.Base.Apps.Models
{
    public class ManagerModel : MdiModel<Manager>
    {
        public App item;
        public Navigation nav;
        public Function fun;

        private List<App> list;
        private int handle;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(Navigation info) : base(info)
        {
            // 订阅界面事件
            view.gdvApp.FocusedRowObjectChanged += (sender, args) => ItemChanged(args.FocusedRowHandle);
            view.TreNav.FocusedNodeChanged += (sender, args) => NavChanged(args.Node);
            view.gdvFunc.FocusedRowObjectChanged += (sender, args) => FunChanged(args.FocusedRowHandle);

            // 设置界面样式
            Format.GridFormat(view.gdvApp);
            Format.TreeFormat(view.TreNav);
            Format.GridFormat(view.gdvFunc);
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void Refresh()
        {
            LoadData(handle);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handel">当前焦点行</param>
        public void LoadData(int handel = 0)
        {
            ShowWaitForm();
            var url = $"{appServer}/appapi/v1.0/apps/all";
            var client = new HttpClient<List<App>>(tokenHelper);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            list = client.data;
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">App</param>
        public void AddItem(App data)
        {
            list.Add(data);

            view.gdvApp.RefreshData();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">App</param>
        public void Update(App data)
        {
            Util.CopyValue(data, item);
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void AddItem(Navigation data)
        {
            item.navs.Add(data);

            view.TreNav.RefreshDataSource();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void Update(Navigation data)
        {
            Util.CopyValue(data, nav);
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data">Function</param>
        public void AddItem(Function data)
        {
            nav.funcs.Add(data);

            view.gdvFunc.RefreshData();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">Function</param>
        public void Update(Function data)
        {
            Util.CopyValue(data, fun);
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void DeleteItem()
        {
            var msg = $"您确定要删除应用【{item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除应用【{item.name}】！";
            var url = $"{appServer}/appapi/v1.0/apps/{item.id}";
            var client = new HttpClient<object>(tokenHelper);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            list.Remove(item);
            view.gdvApp.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void DeleteNav()
        {
            var msg = $"您确定要删除导航【{nav.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除导航【{nav.name}】！";
            var url = $"{appServer}/appapi/v1.0/apps/navigations/{nav.id}";
            var client = new HttpClient<object>(tokenHelper);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            item.navs.Remove(nav);
            view.TreNav.RefreshDataSource();
            CloseWaitForm();
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void DeleteFun()
        {
            var msg = $"您确定要删除功能【{fun.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除功能【{fun.name}】！";
            var url = $"{appServer}/appapi/v1.0/apps/navigations/functions/{fun.id}";
            var client = new HttpClient<object>(tokenHelper);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            nav.funcs.Remove(fun);
            view.gdvFunc.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void RefreshToolBar()
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
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void ItemChanged(int index)
        {
            handle = index;
            item = index < 0 ? null : list[index];
            if (item != null && item.navs == null) GetDetail();

            view.TreNav.DataSource = item?.navs;
            view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
            view.TreNav.ExpandAll();
            if (!(item?.navs?.Any() ?? false)) nav = null;

            RefreshToolBar();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        private void GetDetail()
        {
            var url = $"{appServer}/appapi/v1.0/apps/{item.id}/navigations";
            var client = new HttpClient<List<Navigation>>(tokenHelper);
            if (!client.Get(url)) return;

            item.navs = client.data;
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        private void NavChanged(TreeListNode node)
        {
            if (node != null)
            {
                var id = node.GetValue("id").ToString();
                nav = item.navs.SingleOrDefault(m => m.id == id);
                if (node.HasChildren) fun = null;
                else if (nav != null) GetFuns(id);
            }

            view.grdFunc.DataSource = nav?.funcs;
            RefreshToolBar();
        }

        /// <summary>
        /// 获取模块功能
        /// </summary>
        /// <param name="id">导航ID</param>
        private void GetFuns(string id)
        {
            var url = $"{appServer}/appapi/v1.0/apps/navigations/{id}/functions";
            var client = new HttpClient<List<Function>>(tokenHelper);
            if (!client.Get(url)) return;

            nav.funcs = client.data;
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void FunChanged(int index)
        {
            fun = index < 0 ? null : nav.funcs[index];

            RefreshToolBar();
        }
    }
}