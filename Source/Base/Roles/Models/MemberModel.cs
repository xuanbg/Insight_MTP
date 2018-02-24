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
        public Member view = new Member();

        private readonly Role role;
        private List<RoleMember> members;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="role">角色对象</param>
        public MemberModel(Role role)
        {
            this.role = role;

            view.treOrg.DataSource = OtherTitles(role.id);
            Format.TreeFormat(view.treOrg, NodeIconType.Organization);

            view.grdGroup.DataSource = OtherGroups(role.id);
            Format.GridFormat(view.gdvGroup, 0);

            view.grdUser.DataSource = OtherUsers(role.id);
            Format.GridFormat(view.gdvUser, 0);
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Role Save()
        {
            var mt = from node in view.treOrg.GetAllCheckedNodes().Where(n => (int)n.GetValue("NodeType") == 3)
                     let p = "00000000-0000-0000-0000-000000000003"
                     let t = (TitleMember)view.treOrg.GetDataRecordByNode(node)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = t.id, nodeType = 3, name = t.name };
            var mg = from list in view.gdvGroup.GetSelectedRows()
                     let p = "00000000-0000-0000-0000-000000000002"
                     let g = (MemberUser)view.gdvGroup.GetRow(list)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = g.id, nodeType = 2, name = g.Name };
            var ug = from list in view.gdvUser.GetSelectedRows()
                     let p = "00000000-0000-0000-0000-000000000001"
                     let u = (MemberUser)view.gdvUser.GetRow(list)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = u.id, nodeType = 1, name = u.Name };

            members = mt.Union(mg).Union(ug).ToList();
            const string msg = "当前未选择任何角色成员！您确定要离开此界面吗？";
            if (members.Count == 0 && Messages.ShowConfirm(msg)) return null;

            var url = $"{Params.server}/roleapi/v1.0/roles/{role.id}/members";
            var dict = new Dictionary<string, object> {{"members", members}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Post(url, dict) ? client.data : null;
        }

        /// <summary>
        /// 加载非角色成员职位数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<TitleMember> OtherTitles(string id)
        {
            var url = Params.server + $"/roleapi/v1.0/roles/{id}/othertitles";
            var client = new HttpClient<List<TitleMember>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<TitleMember>();
        }

        /// <summary>
        /// 加载非角色成员用户组列表数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<MemberUser> OtherGroups(string id)
        {
            var url = Params.server + $"/roleapi/v1.0/roles/{id}/othergroups";
            var client = new HttpClient<List<MemberUser>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<MemberUser>();
        }

        /// <summary>
        /// 加载非角色成员用户列表数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<MemberUser> OtherUsers(string id)
        {
            var url = Params.server + $"/roleapi/v1.0/roles/{id}/otherusers";
            var client = new HttpClient<List<MemberUser>>(Params.tokenHelper);
            return client.Get(url) ? client.data : new List<MemberUser>();
        }
    }
}
