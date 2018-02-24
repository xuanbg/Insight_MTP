using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Base.Roles.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Roles.Models
{
    public class ManagerModel : MdiModel<Manager>
    {
        public Role role;
        public RoleMember member;

        private List<Role> roles;
        private List<MemberUser> memberUsers;
        private bool first = true;
        private int pageRows = 20;
        private int userRows = 20;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(Navigation info) : base(info)
        {
            // 订阅角色列表分页控件事件
            view.TabRole.PageSizeChanged += (sender, args) => pageRows = args.PageSize;
            view.TabRole.CurrentPageChanged += (sender, args) => LoadRoles(view.TabRole.CurrentPage, args.RowHandle);
            view.TabRole.TotalRowsChanged += (sender, args) => view.GdvRole.FocusedRowHandle = args.RowHandle;

            // 订阅角色成员用户列表分页控件事件
            view.TabUser.PageSizeChanged += (sender, args) => userRows = args.PageSize;
            view.TabUser.CurrentPageChanged += (sender, args) => GetMemberUsers(view.TabUser.CurrentPage, args.RowHandle);
            view.TabUser.TotalRowsChanged += (sender, args) => view.GdvUser.FocusedRowHandle = args.RowHandle;

            // 订阅界面鼠标点击事件
            view.GdvRole.FocusedRowObjectChanged += (sender, args) => RoleChanged(args.FocusedRowHandle);
            view.GdvUser.FocusedRowObjectChanged += (sender, args) => view.TabUser.FocusedRowHandle = args.FocusedRowHandle;
            view.TreMember.FocusedNodeChanged += (sender, args) => MemberChanged(args.Node);

            // 设置界面样式
            Format.GridFormat(view.GdvRole);
            Format.GridFormat(view.GdvUser);
            Format.TreeFormat(view.TreMember, NodeIconType.OnlyLevel0);
            Format.TreeFormat(view.TreAction, NodeIconType.NodeType);
            Format.TreeFormat(view.TreData, NodeIconType.NodeType);
        }

        /// <summary>
        /// 刷新角色列表
        /// </summary>
        public void Refresh()
        {
            LoadRoles(view.TabRole.CurrentPage, view.TabRole.FocusedRowHandle);
        }

        /// <summary>
        /// 加载角色列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadRoles(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{server}/roleapi/v1.0/roles?rows={pageRows}&page={page}";
            var client = new HttpClient<List<Role>>(token);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            roles = client.data;
            view.TabRole.TotalRows = int.Parse(client.option.ToString());
            view.GrdRole.DataSource = roles;
            view.GdvRole.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增角色到角色列表
        /// </summary>
        /// <param name="data">RoleInfo</param>
        public void AddRole(Role data)
        {
            roles.Add(data);

            view.TabRole.AddItems();
            view.GrdRole.RefreshDataSource();
        }

        /// <summary>
        /// 删除当前所选角色
        /// </summary>
        public void RoleDelete()
        {
            var msg = $"您确定要删除角色【{role.name}】吗？\r\n角色删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            var url = $"{server}/roleapi/v1.0/roles/{role.id}";
            msg = $"对不起，角色【{role.name}】删除失败！如多次删除失败，请联系管理员。";
            var client = new HttpClient<object>(token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            roles.Remove(role);

            view.TabRole.RemoveItems();
            view.GdvRole.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 删除当前所选角色成员
        /// </summary>
        public void MemberRemove()
        {
            var msg = $"您确定要移除角色成员【{member.name}】吗？\r\n角色成员被移除后相应用户将失去该角色赋予的权限！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，角色成员【{member.name}】移除失败！如多次移除失败，请联系管理员。";
            var url = $"{server}/roleapi/v1.0/roles/members/{member.id}";
            var client = new HttpClient<Role>(token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            UpdateMember(client.data);
            CloseWaitForm();
        }

        /// <summary>
        /// 更新当前所选角色数据
        /// </summary>
        /// <param name="data">RoleInfo</param>
        public void UpdatePerm(Role data)
        {
            role.name = data.name;
            role.remark = data.remark;

            role.funcs.Clear();
            role.funcs.AddRange(data.funcs);

            role.datas.Clear();
            role.datas.AddRange(data.datas);

            RefreshPerm();
        }

        /// <summary>
        /// 更新当前所选角色数据
        /// </summary>
        /// <param name="data">RoleInfo</param>
        public void UpdateMember(Role data)
        {
            role.members.Clear();
            role.members.AddRange(data.members);

            view.TreMember.RefreshDataSource();
            view.TreMember.ExpandAll();
            view.TreMember.MoveFirst();

            RefreshToolBar();
            GetMemberUsers();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        /// <param name="type">角色类型</param>
        private void RefreshToolBar(int? type = null)
        {
            var dict = new Dictionary<string, bool>
            {
                ["deleteRole"] = !role.isBuiltin,
                ["addRoleMember"] = !role.isBuiltin,
                ["removeRoleMember"] = !role.isBuiltin && type == 0
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 刷新权限
        /// </summary>
        private void RefreshPerm()
        {
            view.TreAction.RefreshDataSource();
            view.TreAction.ExpandToLevel(0);

            view.TreData.RefreshDataSource();
            view.TreData.ExpandToLevel(0);
        }

        /// <summary>
        /// 根据ID获取角色数据
        /// </summary>
        /// <param name="index">List下标</param>
        private void RoleChanged(int index)
        {
            view.TabRole.FocusedRowHandle = index;

            role = roles[index];
            if (role.funcs == null || role.datas == null || role.members == null) GetRole();

            view.TreAction.DataSource = role.funcs;
            view.TreAction.ExpandToLevel(0);
            view.TreData.DataSource = role.datas;
            view.TreData.ExpandToLevel(0);
            view.TreMember.DataSource = role.members;
            view.TreMember.ExpandAll();
            view.TreMember.MoveFirst();

            GetMemberUsers();
            view.GrdUser.DataSource = memberUsers;

            RefreshToolBar();

            if (!first) return;

            view.tabPermission.SelectedTabPageIndex = 0;
            first = false;
        }

        /// <summary>
        /// 切换角色成员
        /// </summary>
        private void MemberChanged(TreeListNode node)
        {
            if (node == null) return;

            var type = (int) node.GetValue("NodeType");
            RefreshToolBar(type);
            member = role.members.Single(m => m.id == node.GetValue("ID").ToString());
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        private void GetRole()
        {
            var url = $"{server}/roleapi/v1.0/roles/{role.id}";
            var client = new HttpClient<Role>(token);
            if (!client.Get(url)) return;

            role.funcs = client.data.funcs;
            role.datas = client.data.datas;
            role.members = client.data.members;
        }

        /// <summary>
        /// 获取角色成员用户
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="handel">当前焦点行</param>
        private void GetMemberUsers(int page = 1, int handel = 0)
        {
            var url = $"{server}/roleapi/v1.0/roles/{role.id}/users?rows={userRows}&page={page}";
            var client = new HttpClient<List<MemberUser>>(token);
            if (!client.Get(url)) return;

            memberUsers = client.data;
            view.TabUser.TotalRows = int.Parse(client.option.ToString());
            view.GrdUser.DataSource = memberUsers;
            view.GdvUser.FocusedRowHandle = handel;
        }
    }
}