using System;
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
        public Role Role;
        public RoleMember Member;

        private List<Role> _Roles;
        private List<MemberUser> _MemberUsers;
        private bool _First = true;
        private int _PageRows = 20;
        private int _UserRows = 20;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(ModuleInfo info) : base(info)
        {
            // 订阅角色列表分页控件事件
            View.TabRole.PageSizeChanged += (sender, args) => _PageRows = args.PageSize;
            View.TabRole.CurrentPageChanged += (sender, args) => LoadRoles(View.TabRole.CurrentPage, args.RowHandle);
            View.TabRole.TotalRowsChanged += (sender, args) => View.GdvRole.FocusedRowHandle = args.RowHandle;

            // 订阅角色成员用户列表分页控件事件
            View.TabUser.PageSizeChanged += (sender, args) => _UserRows = args.PageSize;
            View.TabUser.CurrentPageChanged += (sender, args) => GetMemberUsers(View.TabUser.CurrentPage, args.RowHandle);
            View.TabUser.TotalRowsChanged += (sender, args) => View.GdvUser.FocusedRowHandle = args.RowHandle;

            // 订阅界面鼠标点击事件
            View.GdvRole.FocusedRowObjectChanged += (sender, args) => RoleChanged(args.FocusedRowHandle);
            View.GdvUser.FocusedRowObjectChanged += (sender, args) => View.TabUser.FocusedRowHandle = args.FocusedRowHandle;
            View.TreMember.FocusedNodeChanged += (sender, args) => MemberChanged(args.Node);

            // 设置界面样式
            Format.GridFormat(View.GdvRole);
            Format.GridFormat(View.GdvUser);
            Format.TreeFormat(View.TreMember, NodeIconType.OnlyLevel0);
            Format.TreeFormat(View.TreAction, NodeIconType.NodeType);
            Format.TreeFormat(View.TreData, NodeIconType.NodeType);
        }

        /// <summary>
        /// 刷新角色列表
        /// </summary>
        public void Refresh()
        {
            LoadRoles(View.TabRole.CurrentPage, View.TabRole.FocusedRowHandle);
        }

        /// <summary>
        /// 加载角色列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadRoles(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{Params.Token.BaseServer}/roleapi/v1.0/roles?rows={_PageRows}&page={page}";
            var client = new HttpClient<List<Role>>(Params.Token);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            _Roles = client.Data;
            View.TabRole.TotalRows = int.Parse(client.Option.ToString());
            View.GrdRole.DataSource = _Roles;
            View.GdvRole.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增角色到角色列表
        /// </summary>
        /// <param name="role">RoleInfo</param>
        public void AddRole(Role role)
        {
            _Roles.Add(role);

            View.TabRole.AddItems();
            View.GrdRole.RefreshDataSource();
        }

        /// <summary>
        /// 删除当前所选角色
        /// </summary>
        public void RoleDelete()
        {
            var msg = $"您确定要删除角色【{Role.Name}】吗？\r\n角色删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            var url = $"{Params.Token.BaseServer}/roleapi/v1.0/roles/{Role.ID}";
            msg = $"对不起，角色【{Role.Name}】删除失败！如多次删除失败，请联系管理员。";
            var client = new HttpClient<object>(Params.Token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            _Roles.Remove(Role);

            View.TabRole.RemoveItems();
            View.GdvRole.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 删除当前所选角色成员
        /// </summary>
        public void MemberRemove()
        {
            var msg = $"您确定要移除角色成员【{Member.Name}】吗？\r\n角色成员被移除后相应用户将失去该角色赋予的权限！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，角色成员【{Member.Name}】移除失败！如多次移除失败，请联系管理员。";
            var url = $"{Params.Token.BaseServer}/roleapi/v1.0/roles/members/{Member.ID}";
            var client = new HttpClient<Role>(Params.Token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            UpdateMember(client.Data);
            CloseWaitForm();
        }

        /// <summary>
        /// 更新当前所选角色数据
        /// </summary>
        /// <param name="role">RoleInfo</param>
        public void UpdatePerm(Role role)
        {
            Role.Name = role.Name;
            Role.Description = role.Description;

            Role.Actions.Clear();
            Role.Actions.AddRange(role.Actions);

            Role.Datas.Clear();
            Role.Datas.AddRange(role.Datas);

            RefreshPerm();
        }

        /// <summary>
        /// 更新当前所选角色数据
        /// </summary>
        /// <param name="role">RoleInfo</param>
        public void UpdateMember(Role role)
        {
            Role.Members.Clear();
            Role.Members.AddRange(role.Members);

            View.TreMember.RefreshDataSource();
            View.TreMember.ExpandAll();
            View.TreMember.MoveFirst();

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
                ["DeleteRole"] = !Role.BuiltIn,
                ["AddMember"] = !Role.BuiltIn,
                ["Remove"] = !Role.BuiltIn && type == 0
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 刷新权限
        /// </summary>
        private void RefreshPerm()
        {
            View.TreAction.RefreshDataSource();
            View.TreAction.ExpandToLevel(0);

            View.TreData.RefreshDataSource();
            View.TreData.ExpandToLevel(0);
        }

        /// <summary>
        /// 根据ID获取角色数据
        /// </summary>
        /// <param name="index">List下标</param>
        private void RoleChanged(int index)
        {
            View.TabRole.FocusedRowHandle = index;

            Role = _Roles[index];
            if (Role.Actions == null || Role.Datas == null || Role.Members == null) GetRole();

            View.TreAction.DataSource = Role.Actions;
            View.TreAction.ExpandToLevel(0);
            View.TreData.DataSource = Role.Datas;
            View.TreData.ExpandToLevel(0);
            View.TreMember.DataSource = Role.Members;
            View.TreMember.ExpandAll();
            View.TreMember.MoveFirst();

            GetMemberUsers();
            View.GrdUser.DataSource = _MemberUsers;

            RefreshToolBar();

            if (!_First) return;

            View.tabPermission.SelectedTabPageIndex = 0;
            _First = false;
        }

        /// <summary>
        /// 切换角色成员
        /// </summary>
        private void MemberChanged(TreeListNode node)
        {
            if (node == null) return;

            var type = (int) node.GetValue("NodeType");
            RefreshToolBar(type);
            Member = Role.Members.Single(m => m.ID == (Guid) node.GetValue("ID"));
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        private void GetRole()
        {
            var url = $"{Params.Token.BaseServer}/roleapi/v1.0/roles/{Role.ID}";
            var client = new HttpClient<Role>(Params.Token);
            if (!client.Get(url)) return;

            Role.Actions = client.Data.Actions;
            Role.Datas = client.Data.Datas;
            Role.Members = client.Data.Members;
        }

        /// <summary>
        /// 获取角色成员用户
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="handel">当前焦点行</param>
        private void GetMemberUsers(int page = 1, int handel = 0)
        {
            var url = $"{Params.Token.BaseServer}/roleapi/v1.0/roles/{Role.ID}/users?rows={_UserRows}&page={page}";
            var client = new HttpClient<List<MemberUser>>(Params.Token);
            if (!client.Get(url)) return;

            _MemberUsers = client.Data;
            View.TabUser.TotalRows = int.Parse(client.Option.ToString());
            View.GrdUser.DataSource = _MemberUsers;
            View.GdvUser.FocusedRowHandle = handel;
        }
    }
}