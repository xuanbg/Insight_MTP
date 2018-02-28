using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Base.Roles.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Roles.Models
{
    public class MemberModel : BaseModel
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

            view.grdUser.DataSource = OtherUsers(role.id);
            Format.GridFormat(view.gdvUser, 0);
            view.grdGroup.DataSource = OtherGroups(role.id);
            Format.GridFormat(view.gdvGroup, 0);
            view.treOrg.DataSource = OtherTitles(role.id);
            Format.TreeFormat(view.treOrg, NodeIconType.Organization);
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Role Save()
        {
            var mu = from list in view.gdvUser.GetSelectedRows()
                     let p = "00000000-0000-0000-0000-000000000001"
                     let u = (MemberUser)view.gdvUser.GetRow(list)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = u.id, memberType = 1, nodeType = 1, name = u.name };
            var mg = from list in view.gdvGroup.GetSelectedRows()
                     let p = "00000000-0000-0000-0000-000000000002"
                     let g = (MemberUser)view.gdvGroup.GetRow(list)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = g.id, memberType = 2, nodeType = 2, name = g.name };
            var mt = from node in view.treOrg.GetAllCheckedNodes().Where(n => (int)n.GetValue("NodeType") == 3)
                     let p = "00000000-0000-0000-0000-000000000003"
                     let t = (TitleMember)view.treOrg.GetDataRecordByNode(node)
                     select new RoleMember { id = Util.NewId(), parentId = p, memberId = t.id, memberType = 3, nodeType = 3, name = t.name };
            members = mu.Union(mg).Union(mt).ToList();

            const string msg = "当前未选择任何角色成员！您确定要离开此界面吗？";
            if (members.Count == 0 && Messages.ShowConfirm(msg)) return null;

            var url = $"{server}/roleapi/v1.0/roles/{role.id}/members";
            var dict = new Dictionary<string, object> {{"members", members}};
            var client = new HttpClient<Role>(token);
            client.Post(url, dict);

            return client.data;
        }

        /// <summary>
        /// 加载非角色成员职位数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<TitleMember> OtherTitles(string id)
        {
            var url = $"{server}/roleapi/v1.0/roles/{id}/othertitles";
            var client = new HttpClient<List<TitleMember>>(token);
            client.Get(url);

            return client.data;
        }

        /// <summary>
        /// 加载非角色成员用户组列表数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<MemberUser> OtherGroups(string id)
        {
            var url = $"{server}/roleapi/v1.0/roles/{id}/othergroups";
            var client = new HttpClient<List<MemberUser>>(token);
            client.Get(url);

            return client.data;
        }

        /// <summary>
        /// 加载非角色成员用户列表数据
        /// </summary>
        /// <param name="id">角色id</param>
        private List<MemberUser> OtherUsers(string id)
        {
            var url = $"{server}/roleapi/v1.0/roles/{id}/otherusers";
            var client = new HttpClient<List<MemberUser>>(token);
            client.Get(url);

            return client.data;
        }
    }
}
