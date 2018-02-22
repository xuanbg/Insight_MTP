using System;
using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Base.Roles.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Roles.Models
{
    public class MemberModel
    {
        public Member View = new Member();

        private readonly Role _Role;
        private List<RoleMember> _Members;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="role">角色对象</param>
        public MemberModel(Role role)
        {
            _Role = role;

            View.treOrg.DataSource = OtherTitles(role.ID);
            Format.TreeFormat(View.treOrg, NodeIconType.Organization);

            View.grdGroup.DataSource = OtherGroups(role.ID);
            Format.GridFormat(View.gdvGroup, 0);

            View.grdUser.DataSource = OtherUsers(role.ID);
            Format.GridFormat(View.gdvUser, 0);
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Role Save()
        {
            var mt = from node in View.treOrg.GetAllCheckedNodes().Where(n => (int)n.GetValue("NodeType") == 3)
                     let p = Guid.Parse("00000000-0000-0000-0000-000000000003")
                     let t = (TitleMember)View.treOrg.GetDataRecordByNode(node)
                     select new RoleMember { ID = Guid.NewGuid(), ParentId = p, MemberId = t.ID, NodeType = 3, Name = t.Name };
            var mg = from list in View.gdvGroup.GetSelectedRows()
                     let p = Guid.Parse("00000000-0000-0000-0000-000000000002")
                     let g = (MemberUser)View.gdvGroup.GetRow(list)
                     select new RoleMember { ID = Guid.NewGuid(), ParentId = p, MemberId = g.ID, NodeType = 2, Name = g.Name };
            var ug = from list in View.gdvUser.GetSelectedRows()
                     let p = Guid.Parse("00000000-0000-0000-0000-000000000001")
                     let u = (MemberUser)View.gdvUser.GetRow(list)
                     select new RoleMember { ID = Guid.NewGuid(), ParentId = p, MemberId = u.ID, NodeType = 1, Name = u.Name };

            _Members = mt.Union(mg).Union(ug).ToList();
            const string msg = "当前未选择任何角色成员！您确定要离开此界面吗？";
            if (_Members.Count == 0 && Messages.ShowConfirm(msg)) return null;

            var url = $"{Params.tokenHelper.BaseServer}/roleapi/v1.0/roles/{_Role.ID}/members";
            var dict = new Dictionary<string, object> {{"members", _Members}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Post(url, dict) ? client.Data : null;
        }

        /// <summary>
        /// 加载非角色成员职位数据
        /// </summary>
        /// <param name="id">角色ID</param>
        private List<TitleMember> OtherTitles(Guid id)
        {
            var url = Params.tokenHelper.BaseServer + $"/roleapi/v1.0/roles/{id}/othertitles";
            var client = new HttpClient<List<TitleMember>>(Params.tokenHelper);
            return client.Get(url) ? client.Data : new List<TitleMember>();
        }

        /// <summary>
        /// 加载非角色成员用户组列表数据
        /// </summary>
        /// <param name="id">角色ID</param>
        private List<MemberUser> OtherGroups(Guid id)
        {
            var url = Params.tokenHelper.BaseServer + $"/roleapi/v1.0/roles/{id}/othergroups";
            var client = new HttpClient<List<MemberUser>>(Params.tokenHelper);
            return client.Get(url) ? client.Data : new List<MemberUser>();
        }

        /// <summary>
        /// 加载非角色成员用户列表数据
        /// </summary>
        /// <param name="id">角色ID</param>
        private List<MemberUser> OtherUsers(Guid id)
        {
            var url = Params.tokenHelper.BaseServer + $"/roleapi/v1.0/roles/{id}/otherusers";
            var client = new HttpClient<List<MemberUser>>(Params.tokenHelper);
            return client.Get(url) ? client.Data : new List<MemberUser>();
        }
    }
}
