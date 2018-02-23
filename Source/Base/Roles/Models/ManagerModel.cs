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
        /// <param name="role">RoleInfo</param>
        public void AddRole(Role role)
        {
            roles.Add(role);

            view.TabRole.AddItems();
            view.GrdRole.RefreshDataSource();
        }

        /// <summary>
        /// 删除当前所选角色
        /// </summary>
        public void RoleDelete()
        {
            var msg = $"您确定要删除角色【{role.Name}】吗？\r\n角色删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            var url = $"{server}/roleapi/v1.0/roles/{role.ID}";
            msg = $"对不起，角色【{role.Name}】删除失败！如多次删除失败，请联系管理员。";
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
            var msg = $"您确定要移除角色成员【{member.Name}】吗？\r\n角色成员被移除后相应用户将失去该角色赋予的权限！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，角色成员【{member.Name}】移除失败！如多次移除失败，请联系管理员。";
            var url = $"{server}/roleapi/v1.0/roles/members/{member.ID}";
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
        /// <param name="role">RoleInfo</param>
        public void UpdatePerm(Role role)
        {
            this.role.Name = role.Name;
            this.role.Description = role.Description;

            this.role.Actions.Clear();
            this.role.Actions.AddRange(role.Actions);

            this.role.Datas.Clear();
            this.role.Datas.AddRange(role.Datas);

            RefreshPerm();
        }

        /// <summary>
        /// 更新当前所选角色数据
        /// </summary>
        /// <param name="role">RoleInfo</param>
        public void UpdateMember(Role role)
        {
            this.role.Members.Clear();
            this.role.Members.AddRange(role.Members);

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
                ["deleteRole"] = !role.BuiltIn,
                ["addRoleMember"] = !role.BuiltIn,
                ["removeRoleMember"] = !role.BuiltIn && type == 0
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
            if (role.Actions == null || role.Datas == null || role.Members == null) GetRole();

            view.TreAction.DataSource = role.Actions;
            view.TreAction.ExpandToLevel(0);
            view.TreData.DataSource = role.Datas;
            view.TreData.ExpandToLevel(0);
            view.TreMember.DataSource = role.Members;
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
            member = role.Members.Single(m => m.ID == node.GetValue("ID").ToString());
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        private void GetRole()
        {
            var url = $"{server}/roleapi/v1.0/roles/{role.ID}";
            var client = new HttpClient<Role>(token);
            if (!client.Get(url)) return;

            role.Actions = client.data.Actions;
            role.Datas = client.data.Datas;
            role.Members = client.data.Members;
        }

        /// <summary>
        /// 获取角色成员用户
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="handel">当前焦点行</param>
        private void GetMemberUsers(int page = 1, int handel = 0)
        {
            var url = $"{server}/roleapi/v1.0/roles/{role.ID}/users?rows={userRows}&page={page}";
            var client = new HttpClient<List<MemberUser>>(token);
            if (!client.Get(url)) return;

            memberUsers = client.data;
            view.TabUser.TotalRows = int.Parse(client.option.ToString());
            view.GrdUser.DataSource = memberUsers;
            view.GdvUser.FocusedRowHandle = handel;
        }
    }
}