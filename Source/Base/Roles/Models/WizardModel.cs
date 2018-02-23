using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Base.Roles.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;

namespace Insight.MTP.Client.Base.Roles.Models
{
    public class WizardModel
    {
        public Wizard view;

        private readonly Role role;
        private List<RoleAction> modules;
        private List<RoleAction> _Actions;
        private List<RoleData> dataModules;
        private List<RoleData> _Datas;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="role">RoleInfo</param>
        /// <param name="title">View标题</param>
        public WizardModel(Role role, string title)
        {
            this.role = role;
            this.role.Actions = new List<RoleAction>();
            this.role.Datas = new List<RoleData>();

            // 构造Wizard视图并设置控件样式
            view = new Wizard
            {
                Text = title,
                NameInput = {EditValue = role.Name},
                Description = {EditValue = role.Description}
            };
            view.PagInfo.AllowNext = view.NameInput.EditValue != null;

            // 订阅控件事件实现数据双向绑定
            view.NameInput.EditValueChanged += (sender, args) =>
            {
                this.role.Name = view.NameInput.Text.Trim();
                view.PagInfo.AllowNext = view.NameInput.EditValue != null;
            };
            view.Description.EditValueChanged += (sender, args) =>
            {
                var text = view.Description.EditValue?.ToString().Trim();
                this.role.Description = string.IsNullOrEmpty(text) ? null : text;
            };
            view.TreModule.NodeChanged += (sender, args) => ModuleTreeChanged(args);
            view.TreAction.AfterCheckNode += (sender, args) => SetAction(args.Node);
            view.TreDataModule.NodeChanged += (sender, args) => DataTreeChanged(args);
            view.TreDataPerm.AfterCheckNode += (sender, args) => SetData(args.Node);
            view.Shown += (sender, args) =>
            {
                view.NameInput.Focus();
                RefreshTree();
            };

            // 初始化TreeList控件
            InitTree();
        }

        /// <summary>
        /// 保存角色
        /// </summary>
        public Role AddRole()
        {
            var msg = "角色权限保存失败！如多次失败，请联系管理员。";
            var url = $"{Params.server}/roleapi/v1.0/roles";
            var dict = new Dictionary<string, object> {{"role", role}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        internal Role EditRole()
        {
            var msg = "角色权限更新失败！如多次失败，请联系管理员。";
            var url = $"{Params.server}/roleapi/v1.0/roles/{role.ID}";
            var dict = new Dictionary<string, object> {{"role", role}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Put(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 根据当前权限刷新权限树
        /// </summary>
        public void RefreshTree()
        {
            // 设置ModuleTree和ActionTree选中状态
            view.TreModule.ExpandToLevel(0);
            foreach (var module in modules.Where(m => m.Permit == 1))
            {
                var node = view.TreModule.FindNodeByKeyID(module.ID);
                view.TreModule.SetNodeCheckState(node, CheckState.Checked, true);
            }
            view.TreAction.ExpandToLevel(0);
            view.TreAction.MoveFirst();

            // 设置DataTree和DataPermTree选中状态
            view.TreDataModule.ExpandToLevel(0);
            foreach (var module in dataModules.Where(m => m.Permit == 1))
            {
                var node = view.TreDataModule.FindNodeByKeyID(module.ID);
                view.TreDataModule.SetNodeCheckState(node, CheckState.Checked, true);
            }
            view.TreDataPerm.ExpandToLevel(0);
            view.TreDataPerm.MoveFirst();
        }

        /// <summary>
        /// 初始化权限树
        /// </summary>
        private void InitTree()
        {
            // 加载数据
            var url = $"{Params.server}/roleapi/v1.0/roles/{role.ID}/allperm";
            var client = new HttpClient<Role>(Params.tokenHelper);
            if (!client.Get(url)) return;

            _Actions = client.data.Actions;
            modules = _Actions.Where(a => a.NodeType < 2).ToList();
            _Datas = client.data.Datas;
            dataModules = _Datas.Where(d => d.NodeType < 2).ToList();

            // 绑定数据源，设置TreeList样式
            view.TreModule.DataSource = modules;
            Format.TreeFormat(view.TreModule, NodeIconType.NodeType);

            view.TreAction.DataSource = role.Actions;
            Format.TreeFormat(view.TreAction, NodeIconType.NodeType);

            view.TreDataModule.DataSource = dataModules;
            Format.TreeFormat(view.TreDataModule, NodeIconType.NodeType);

            view.TreDataPerm.DataSource = role.Datas;
            Format.TreeFormat(view.TreDataPerm, NodeIconType.NodeType);
        }

        /// <summary>
        /// 设置操作权限
        /// </summary>
        /// <param name="node">TreeListNode</param>
        private void SetAction(TreeListNode node)
        {
            // 根据节点类型获取需改变节点列表
            IEnumerable<RoleAction> list;
            var id = (Guid)node.GetValue("ID");
            switch ((int)node.GetValue("NodeType"))
            {
                case 0:
                    var ids = _Actions.Where(a => a.ParentId == id).Select(a => a.ID);
                    list = _Actions.Where(a => ids.Any(i => i == a.ParentId));
                    break;
                case 1:
                    list = _Actions.Where(a => a.ParentId == id);
                    break;
                default:
                    list = new List<RoleAction> {_Actions.Single(a => a.ID == id)};
                    break;
            }

            // 遍历列表更改权限状态
            foreach (var action in list)
            {
                switch (node.CheckState)
                {
                    case CheckState.Unchecked:
                        action.Permit = null;
                        action.Description = null;
                        break;
                    case CheckState.Indeterminate:
                        action.Permit = 0;
                        action.Description = "拒绝";
                        break;
                    case CheckState.Checked:
                        action.Permit = 1;
                        action.Description = "允许";
                        break;
                }
            }

            view.TreAction.Refresh();
        }

        /// <summary>
        /// 设置数据权限
        /// </summary>
        /// <param name="node">TreeListNode</param>
        private void SetData(TreeListNode node)
        {
            // 根据节点类型获取需改变节点列表
            IEnumerable<RoleData> list;
            var id = (Guid)node.GetValue("ID");
            switch ((int)node.GetValue("NodeType"))
            {
                case 0:
                    var ids = _Datas.Where(a => a.ParentId == id).Select(a => a.ID);
                    list = _Datas.Where(a => ids.Any(i => i == a.ParentId));
                    break;
                case 1:
                    list = _Datas.Where(a => a.ParentId == id);
                    break;
                default:
                    list = new List<RoleData> {_Datas.Single(a => a.ID == id)};
                    break;
            }

            // 遍历列表更改权限状态
            foreach (var data in list)
            {
                switch (node.CheckState)
                {
                    case CheckState.Unchecked:
                        data.Permit = null;
                        data.Description = null;
                        break;
                    case CheckState.Indeterminate:
                        data.Permit = 0;
                        data.Description = "只读";
                        break;
                    case CheckState.Checked:
                        data.Permit = 1;
                        data.Description = "读写";
                        break;
                }
            }

            view.TreDataPerm.Refresh();
        }
        
        /// <summary>
        /// 改变业务模块选中状态后刷新功能操作树
        /// </summary>
        /// <param name="e"></param>
        private void ModuleTreeChanged(NodeChangedEventArgs e)
        {
            if (e.ChangeType != NodeChangeTypeEnum.CheckedState || e.Node.ParentNode == null) return;

            // 将选中模块加入权限树
            var id = (Guid)e.Node.GetValue("ID");
            RefreshActions(id, e.Node.Checked);
            if (!e.Node.Checked) return;

            // 根据现已权限设置权限树节点状态
            foreach (var action in role.Actions.Where(a => a.ParentId == id))
            {
                var node = view.TreAction.FindNodeByKeyID(action.ID);
                var state = action.Permit.HasValue
                    ? (action.Permit == 1 ? CheckState.Checked : CheckState.Indeterminate)
                    : CheckState.Unchecked;
                view.TreAction.SetNodeCheckState(node, state, true);
            }
        }

        /// <summary>
        /// 改变业务模块选中状态后刷新数据权限树
        /// </summary>
        /// <param name="e"></param>
        private void DataTreeChanged(NodeChangedEventArgs e)
        {
            if (e.ChangeType != NodeChangeTypeEnum.CheckedState || e.Node.ParentNode == null) return;

            // 将选中模块加入权限树
            var id = (Guid)e.Node.GetValue("ID");
            RefreshDatas(id, e.Node.Checked);
            if (!e.Node.Checked) return;

            // 根据现已权限设置权限树节点状态
            foreach (var data in role.Datas.Where(a => a.ParentId == id))
            {
                var node = view.TreDataPerm.FindNodeByKeyID(data.ID);
                var state = data.Permit.HasValue
                    ? (data.Permit == 1 ? CheckState.Checked : CheckState.Indeterminate)
                    : CheckState.Unchecked;
                view.TreDataPerm.SetNodeCheckState(node, state, true);
            }
        }

        /// <summary>
        /// 刷新操作资源树
        /// </summary>
        /// <param name="id">模块ID</param>
        /// <param name="add">是否增加</param>
        private void RefreshActions(Guid id, bool add)
        {
            var module = _Actions.Single(m => m.ID == id);
            var group = _Actions.Single(g => g.ID == module.ParentId);
            var actions = _Actions.Where(a => a.ParentId == id);
            if (add)
            {
                if (role.Actions.All(g => g.ID != group.ID)) role.Actions.Add(group);

                if (role.Actions.All(m => m.ID != module.ID)) role.Actions.Add(module);

                role.Actions.AddRange(actions.Where(action => role.Actions.All(a => a.ID != action.ID)));
            }
            else
            {
                role.Actions.RemoveAll(a => a.ParentId == id);
                role.Actions.Remove(module);
                if (role.Actions.All(a => a.ParentId != group.ID)) role.Actions.Remove(group);
            }
            view.TreAction.RefreshDataSource();
            view.TreAction.ExpandToLevel(0);
        }

        /// <summary>
        /// 刷新数据资源树
        /// </summary>
        /// <param name="id">模块ID</param>
        /// <param name="add">是否增加</param>
        private void RefreshDatas(Guid id, bool add)
        {
            var module = _Datas.Single(m => m.ID == id);
            var group = _Datas.Single(g => g.ID == module.ParentId);
            var datas = _Datas.Where(d => d.ParentId == id);
            if (add)
            {
                if (role.Datas.All(g => g.ID != group.ID)) role.Datas.Add(group);

                if (role.Datas.All(m => m.ID != module.ID)) role.Datas.Add(module);

                role.Datas.AddRange(datas.Where(data => role.Datas.All(d => d.ID != data.ID)));
            }
            else
            {
                role.Datas.RemoveAll(a => a.ParentId == id);
                role.Datas.Remove(module);
                if (role.Datas.All(a => a.ParentId != group.ID)) role.Datas.Remove(group);
            }
            view.TreDataPerm.RefreshDataSource();
            view.TreDataPerm.ExpandToLevel(0);
        }
    }
}
