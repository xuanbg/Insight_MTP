using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Setting.Roles.ViewModels
{
    public class ManagerModel : BaseMdiModel<Role, Manager, DataModel>
    {
        public Member member;
        public AppTree func;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdRole, view.gdvRole, view.ppcRole);
            initTree(view.treMember, "memberChanged", "removeMember");
            initGrid(view.gdvUser, null, null, view.ppcUser, "getMemberUsers");
            initTree(view.treAction, "funcChanged");

            // 通过权限树点击事件循环设置功能权限状态：->1->0->null
            view.treAction.Click += (sender, args) =>
            {
                var node = view.treAction.FocusedNode;
                if (node.HasChildren) return;

                funcChanged(node);
                callback("setFunc");
            };
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getRoles(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;
            view.gdvRole.RefreshData();
            view.gdvRole.FocusedRowHandle = handle;

            refreshToolBar();
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
                member = null;
            }
            else
            {
                var id = item?.id;
                item = list[index];
                if (item.id != id) getDetail();
            }

            view.treMember.DataSource = item?.members;
            if (item?.members.Any() ?? false)
            {
                view.treMember.FocusedNode = view.treMember.Nodes.FirstNode;
                view.treMember.ExpandAll();
            }
            else
            {
                member = null;
            }

            view.grdUser.DataSource = item?.users;
            view.treAction.DataSource = item?.funcs;
            view.treAction.ExpandToLevel(1);

            refreshToolBar();
        }

        /// <summary>
        /// 获取角色明细数据
        /// </summary>
        private void getDetail()
        {
            // 读取角色成员
            if (!item.members.Any())
            {
                var members = dataModel.getRoleMember(item.id);
                if (members != null) item.members.AddRange(members);

                if (item.members.Any(i => i.type == 1)) item.members.Add(new Member { id = "1", type = 0, name = "用户" });

                if (item.members.Any(i => i.type == 2)) item.members.Add(new Member { id = "2", type = 0, name = "用户组" });

                if (item.members.Any(i => i.type == 3)) item.members.Add(new Member { id = "3", type = 0, name = "职位" });
            }

            // 读取角色成员用户
            if (!item.users.Any())
            {
                getMemberUsers();
            }

            // 读取角色权限
            if (!item.funcs.Any())
            {
                var funcs = dataModel.getRoleFuncs(item.id);
                if (funcs != null) item.funcs.AddRange(funcs);
            }
        }

        /// <summary>
        /// 成员节点改变
        /// </summary>
        /// <param name="node">导航节点</param>
        public void memberChanged(TreeListNode node)
        {
            if (node == null)
            {
                member = null;
            }
            else
            {
                var id = node.GetValue("id").ToString();
                member = item.members.SingleOrDefault(m => m.id == id);
            }

            refreshToolBar();
        }

        /// <summary>
        /// 获取角色成员用户集合
        /// </summary>
        /// <param name="handle"></param>
        public void getMemberUsers(int handle = 0)
        {
            var result = dataModel.getMemberUsers(item.id, view.ppcUser.page, view.ppcUser.size);
            if (!result.success) return;

            item.users = result.data;
            view.ppcUser.totalRows = result.total;
            view.grdUser.DataSource = item.users;
            view.gdvUser.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 选中功能列表节点改变
        /// </summary>
        /// <param name="node">功能节点</param>
        public void funcChanged(TreeListNode node)
        {
            if (node.HasChildren) return;

            var id = node.GetValue("id").ToString();
            func = item.funcs.SingleOrDefault(i => i.id == id);
        }

        /// <summary>
        /// 刷新树数据
        /// </summary>
        public void refreshTree()
        {
            view.treMember.RefreshDataSource();
            view.treMember.ExpandAll();

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvRole.RefreshData();
            refreshToolBar();
        }
        
        /// <summary>
        /// 刷新树数据
        /// </summary>
        public void refreshAction()
        {
            view.treAction.RefreshDataSource();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null,
                ["addMember"] = item != null && item.builtin,
                ["removeMember"] = member != null && member.type > 0
            };
            switchItemStatus(dict);
        }
    }
}