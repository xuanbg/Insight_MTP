using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Apps.ViewModels
{
    public class ManagerModel : BaseMdiModel<App, Manager, DataModel>
    {
        public Navigation nav;
        public Function func;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            init(view.gdvApp, "editApp", view.pccApp, view.KeyInput, view.Search);

            view.TreNav.DoubleClick += (sender, args) => callback("editNav");
            view.TreNav.FocusedNodeChanged += (sender, args) => navChanged(args.Node);
            Format.treeFormat(view.TreNav);

            view.gdvFunc.DoubleClick += (sender, args) => callback("editFun");
            view.gdvFunc.FocusedRowObjectChanged += (sender, args) => funChanged(args.FocusedRowHandle);
            Format.gridFormat(view.gdvFunc);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getApps(keyWord, tab.page, tab.size);
            list = result.data;
            closeWaitForm();

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdApp.DataSource = list;
            view.gdvApp.FocusedRowHandle = handle;
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
                nav = null;
                func = null;
                view.grdFunc.DataSource = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                handle = index;
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
            if (item?.navs.Any() ?? false)
            {
                view.TreNav.FocusedNode = view.TreNav.Nodes.FirstNode;
                view.TreNav.ExpandAll();
            }

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
                func = null;
            }
            else if (nav.functions == null)
            {
                nav.functions = dataModel.getFuncs(nav.id);
            }

            view.grdFunc.DataSource = nav.functions;
            refreshToolBar();
        }

        /// <summary>
        /// 功能列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void funChanged(int index)
        {
            func = index < 0 ? null : nav.functions[index];

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
                ["newFunc"] = nav != null && nav.type == 2,
                ["editFunc"] = func != null,
                ["deleteFunc"] = func != null,
            };
            switchItemStatus(dict);
        }

        /// <summary>
        /// 新增应用
        /// </summary>
        /// <param name="app">App</param>
        public bool addIApp(App app)
        {
            var id = dataModel.addApp(app);
            if (id == null) return false;

            list.Add(app);
            tab.addItems();

            return true;
        }

        /// <summary>
        /// 更新应用
        /// </summary>
        /// <param name="app">App</param>
        public bool updateApp(App app)
        {
            if (!dataModel.updateApp(app)) return false;

            Util.copyValue(app, item);
            return true;
        }

        /// <summary>
        /// 删除当前选中应用
        /// </summary>
        public void deleteApp()
        {
            var msg = $"您确定要删除应用【{item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteApp(item))
            {
                list.Remove(item);
            }
        }

        /// <summary>
        /// 新增导航数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void addItem(Navigation data)
        {
            item.navs.Add(data);
        }

        /// <summary>
        /// 更新导航数据
        /// </summary>
        /// <param name="data">Navigation</param>
        public void update(Navigation data)
        {
            Util.copyValue(data, nav);
        }

        /// <summary>
        /// 删除当前选中导航
        /// </summary>
        public void deleteNav()
        {
            var msg = $"您确定要删除导航【{nav.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteNav(nav))
            {
                item.navs.Remove(nav);
                tab.removeItems();
            }
        }

        /// <summary>
        /// 新增功能数据
        /// </summary>
        /// <param name="func">Function</param>
        public void addItem(Function func)
        {
            nav.functions.Add(func);
        }

        /// <summary>
        /// 更新功能数据
        /// </summary>
        /// <param name="func">Function</param>
        public void update(Function func)
        {
            Util.copyValue(func, this.func);
        }

        /// <summary>
        /// 删除当前选中功能
        /// </summary>
        public void deleteFunc()
        {
            var msg = $"您确定要删除功能【{func.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteFunc(func))
            {
                nav.functions.Remove(func);
            }
        }
    }
}