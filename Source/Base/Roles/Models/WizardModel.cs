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
        public Wizard View;

        private readonly Role _Role;
        private List<RoleAction> _Modules;
        private List<RoleAction> _Actions;
        private List<RoleData> _DataModules;
        private List<RoleData> _Datas;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="role">RoleInfo</param>
        /// <param name="title">View标题</param>
        public WizardModel(Role role, string title)
        {
            _Role = role;
            _Role.Actions = new List<RoleAction>();
            _Role.Datas = new List<RoleData>();

            // 构造Wizard视图并设置控件样式
            View = new Wizard
            {
                Text = title,
                NameInput = {EditValue = role.Name},
                Description = {EditValue = role.Description}
            };
            View.PagInfo.AllowNext = View.NameInput.EditValue != null;

            // 订阅控件事件实现数据双向绑定
            View.NameInput.EditValueChanged += (sender, args) =>
            {
                _Role.Name = View.NameInput.Text.Trim();
                View.PagInfo.AllowNext = View.NameInput.EditValue != null;
            };
            View.Description.EditValueChanged += (sender, args) =>
            {
                var text = View.Description.EditValue?.ToString().Trim();
                _Role.Description = string.IsNullOrEmpty(text) ? null : text;
            };
            View.TreModule.NodeChanged += (sender, args) => ModuleTreeChanged(args);
            View.TreAction.AfterCheckNode += (sender, args) => SetAction(args.Node);
            View.TreDataModule.NodeChanged += (sender, args) => DataTreeChanged(args);
            View.TreDataPerm.AfterCheckNode += (sender, args) => SetData(args.Node);
            View.Shown += (sender, args) =>
            {
                View.NameInput.Focus();
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
            var url = $"{Params.tokenHelper.baseServer}/roleapi/v1.0/roles";
            var dict = new Dictionary<string, object> {{"role", _Role}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        internal Role EditRole()
        {
            var msg = "角色权限更新失败！如多次失败，请联系管理员。";
            var url = $"{Params.tokenHelper.baseServer}/roleapi/v1.0/roles/{_Role.ID}";
            var dict = new Dictionary<string, object> {{"role", _Role}};
            var client = new HttpClient<Role>(Params.tokenHelper);
            return client.Put(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 根据当前权限刷新权限树
        /// </summary>
        public void RefreshTree()
        {
            // 设置ModuleTree和ActionTree选中状态
            View.TreModule.ExpandToLevel(0);
            foreach (var module in _Modules.Where(m => m.Permit == 1))
            {
                var node = View.TreModule.FindNodeByKeyID(module.ID);
                View.TreModule.SetNodeCheckState(node, CheckState.Checked, true);
            }
            View.TreAction.ExpandToLevel(0);
            View.TreAction.MoveFirst();

            // 设置DataTree和DataPermTree选中状态
            View.TreDataModule.ExpandToLevel(0);
            foreach (var module in _DataModules.Where(m => m.Permit == 1))
            {
                var node = View.TreDataModule.FindNodeByKeyID(module.ID);
                View.TreDataModule.SetNodeCheckState(node, CheckState.Checked, true);
            }
            View.TreDataPerm.ExpandToLevel(0);
            View.TreDataPerm.MoveFirst();
        }

        /// <summary>
        /// 初始化权限树
        /// </summary>
        private void InitTree()
        {
            // 加载数据
            var url = $"{Params.tokenHelper.baseServer}/roleapi/v1.0/roles/{_Role.ID}/allperm";
            var client = new HttpClient<Role>(Params.tokenHelper);
            if (!client.Get(url)) return;

            _Actions = client.data.Actions;
            _Modules = _Actions.Where(a => a.NodeType < 2).ToList();
            _Datas = client.data.Datas;
            _DataModules = _Datas.Where(d => d.NodeType < 2).ToList();

            // 绑定数据源，设置TreeList样式
            View.TreModule.DataSource = _Modules;
            Format.TreeFormat(View.TreModule, NodeIconType.NodeType);

            View.TreAction.DataSource = _Role.Actions;
            Format.TreeFormat(View.TreAction, NodeIconType.NodeType);

            View.TreDataModule.DataSource = _DataModules;
            Format.TreeFormat(View.TreDataModule, NodeIconType.NodeType);

            View.TreDataPerm.DataSource = _Role.Datas;
            Format.TreeFormat(View.TreDataPerm, NodeIconType.NodeType);
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

            View.TreAction.Refresh();
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

            View.TreDataPerm.Refresh();
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
            foreach (var action in _Role.Actions.Where(a => a.ParentId == id))
            {
                var node = View.TreAction.FindNodeByKeyID(action.ID);
                var state = action.Permit.HasValue
                    ? (action.Permit == 1 ? CheckState.Checked : CheckState.Indeterminate)
                    : CheckState.Unchecked;
                View.TreAction.SetNodeCheckState(node, state, true);
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
            foreach (var data in _Role.Datas.Where(a => a.ParentId == id))
            {
                var node = View.TreDataPerm.FindNodeByKeyID(data.ID);
                var state = data.Permit.HasValue
                    ? (data.Permit == 1 ? CheckState.Checked : CheckState.Indeterminate)
                    : CheckState.Unchecked;
                View.TreDataPerm.SetNodeCheckState(node, state, true);
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
                if (_Role.Actions.All(g => g.ID != group.ID)) _Role.Actions.Add(group);

                if (_Role.Actions.All(m => m.ID != module.ID)) _Role.Actions.Add(module);

                _Role.Actions.AddRange(actions.Where(action => _Role.Actions.All(a => a.ID != action.ID)));
            }
            else
            {
                _Role.Actions.RemoveAll(a => a.ParentId == id);
                _Role.Actions.Remove(module);
                if (_Role.Actions.All(a => a.ParentId != group.ID)) _Role.Actions.Remove(group);
            }
            View.TreAction.RefreshDataSource();
            View.TreAction.ExpandToLevel(0);
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
                if (_Role.Datas.All(g => g.ID != group.ID)) _Role.Datas.Add(group);

                if (_Role.Datas.All(m => m.ID != module.ID)) _Role.Datas.Add(module);

                _Role.Datas.AddRange(datas.Where(data => _Role.Datas.All(d => d.ID != data.ID)));
            }
            else
            {
                _Role.Datas.RemoveAll(a => a.ParentId == id);
                _Role.Datas.Remove(module);
                if (_Role.Datas.All(a => a.ParentId != group.ID)) _Role.Datas.Remove(group);
            }
            View.TreDataPerm.RefreshDataSource();
            View.TreDataPerm.ExpandToLevel(0);
        }
    }
}
