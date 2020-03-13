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

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            init(view.gdvRole, "editItem", view.ppcRole);
            initTree(view.treMember, "memberChanged");
            initGrid(view.gdvUser, null, null, view.ppcUser);
            initTree(view.treAction);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getRoles(keyWord, tab.page, tab.size);
            list = result.data;
            closeWaitForm();
            if (!result.success) return;

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdRole.DataSource = list;
            view.gdvRole.FocusedRowHandle = handle;
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
                tab.focusedRowHandle = index;
                handle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.members == null || !item.members.Any())
                    {
                        item.members = dataModel.getRoleMember(item.id);
                        if (item.members.Any(i => i.type == 1)) item.members.AddRange(new List<Member> {new Member {id = "1", type = 0, name = "用户"}});
                        
                        if (item.members.Any(i => i.type == 2)) item.members.AddRange(new List<Member> {new Member {id = "2", type = 0, name = "用户组"}});

                        if (item.members.Any(i => i.type == 3)) item.members.AddRange(new List<Member> {new Member {id = "3", type = 0, name = "岗位"}});
                    }

                    if (item.users == null || !item.users.Any())
                    {
                        var result = dataModel.getMemberUsers(item.id, view.ppcUser.page, view.ppcUser.size);
                        if (result.success)
                        {
                            item.users = result.data;
                            view.ppcUser.totalRows = int.Parse(result.option.ToString());
                        }
                    }

                    if (item.funcs == null || !item.funcs.Any())
                    {
                        item.funcs = dataModel.getRoleFuncs(item.id);
                    }
                }
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
        /// 刷新树数据
        /// </summary>
        public void refreshTree()
        {
            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvUser.RefreshData();
            refreshToolBar();
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
                ["removeMember"] = member != null && member.type > 0,
                ["setFunc"] = item != null,
                ["setData"] = item != null,
            };
            switchItemStatus(dict);
        }
    }
}