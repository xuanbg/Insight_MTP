using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Apps.ViewModels
{
    public class ManagerModel : BaseMdiModel<App, Manager>
    {
        private readonly DataModel dataModel = new DataModel();
        private int rows = 20;
        private string key;

        public Navigation nav;
        public Function fun;

        /// <summary>
        /// 构造ff
        /// </summary>
        public ManagerModel()
        {
            tab = view.pccApp;

            // 订阅界面事件
            view.gdvApp.DoubleClick += (sender, args) => callback("editApp");
            view.TreNav.DoubleClick += (sender, args) => callback("editNav");
            view.gdvFunc.DoubleClick += (sender, args) => callback("editFun");

            //view.gdvApp.FocusedRowObjectChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            view.gdvApp.FocusedRowChanged += (sender, args) => itemChanged(args.FocusedRowHandle);
            view.TreNav.FocusedNodeChanged += (sender, args) => navChanged(args.Node);
            view.gdvFunc.FocusedRowObjectChanged += (sender, args) => funChanged(args.FocusedRowHandle);

            view.Search.Click += (sender, args) => loadData();
            view.KeyInput.Properties.Click += (sender, args) => view.KeyInput.EditValue = null;
            view.KeyInput.EditValueChanged += (sender, args) => key = view.KeyInput.EditValue as string;
            view.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                loadData();
            };

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
            var result = dataModel.getApps(key, tab.currentPage, rows);
            list = result.data;
            closeWaitForm();

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = tab.focusedRowHandle;
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
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
                nav = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.navs == null)
                    {
                        item.navs = dataModel.getNavs(item.id);
                    }
                }
            }

            view.TreNav.DataSource = item?.navs;
            view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
            view.TreNav.ExpandAll();

            refreshToolBar();
        }

        /// <summary>
        /// 导航节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        private void navChanged(TreeListNode node)
        {
            var id = node.GetValue("id").ToString();
            nav = item.navs.SingleOrDefault(m => m.id == id);
            if (nav == null) return;

            if (node.HasChildren)
            {
                fun = null;
            }
            else if (nav.functions == null)
            {
                nav.functions = dataModel.getFuncs(nav.id);
            }

            view.grdFunc.DataSource = nav.functions;
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
                ["newNav"] = item != null && (nav == null || nav.type == 1),
                ["editNav"] = nav != null,
                ["deleteNav"] = nav != null,
                ["newFun"] = nav != null && nav.type == 2,
                ["editFun"] = fun != null,
                ["deleteFun"] = fun != null,
            };
            switchItemStatus(dict);
        }
    }
}