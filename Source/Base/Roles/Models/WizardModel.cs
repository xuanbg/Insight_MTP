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
        private List<AppTree> modules;
        private List<AppTree> actions;
        private List<AppTree> dataModules;
        private List<AppTree> datas;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="role">RoleInfo</param>
        /// <param name="title">View标题</param>
        public WizardModel(Role role, string title)
        {
            this.role = role;
            this.role.funcs = new List<AppTree>();
            this.role.datas = new List<AppTree>();

            // 构造Wizard视图并设置控件样式
            view = new Wizard
            {
                Text = title,
                NameInput = {EditValue = role.name},
                Description = {EditValue = role.remark}
            };
            view.PagInfo.AllowNext = view.NameInput.EditValue != null;

            // 订阅控件事件实现数据双向绑定
            view.NameInput.EditValueChanged += (sender, args) =>
            {
                this.role.name = view.NameInput.Text.Trim();
                view.PagInfo.AllowNext = view.NameInput.EditValue != null;
            };
            view.Description.EditValueChanged += (sender, args) =>
            {
                var text = view.Description.EditValue?.ToString().Trim();
                this.role.remark = string.IsNullOrEmpty(text) ? null : text;
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
            var url = $"{Params.server}/roleapi/v1.0/roles/{role.id}";
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
            foreach (var module in modules.Where(m => m.permit.HasValue && m.permit.Value))
            {
                var node = view.TreModule.FindNodeByKeyID(module.id);
                view.TreModule.SetNodeCheckState(node, CheckState.Checked, true);
            }
            view.TreAction.ExpandToLevel(0);
            view.TreAction.MoveFirst();

            // 设置DataTree和DataPermTree选中状态
            view.TreDataModule.ExpandToLevel(0);
            foreach (var module in dataModules.Where(m => m.permit.HasValue && m.permit.Value))
            {
                var node = view.TreDataModule.FindNodeByKeyID(module.id);
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
            var url = $"{Params.server}/roleapi/v1.0/roles/{role.id}/allperm";
            var client = new HttpClient<Role>(Params.tokenHelper);
            if (!client.Get(url)) return;

            actions = client.data.funcs;
            modules = actions.Where(a => a.nodeType < 2).ToList();
            datas = client.data.datas;
            dataModules = datas.Where(d => d.nodeType < 2).ToList();

            // 绑定数据源，设置TreeList样式
            view.TreModule.DataSource = modules;
            Format.TreeFormat(view.TreModule, NodeIconType.NodeType);

            view.TreAction.DataSource = role.funcs;
            Format.TreeFormat(view.TreAction, NodeIconType.NodeType);

            view.TreDataModule.DataSource = dataModules;
            Format.TreeFormat(view.TreDataModule, NodeIconType.NodeType);

            view.TreDataPerm.DataSource = role.datas;
            Format.TreeFormat(view.TreDataPerm, NodeIconType.NodeType);
        }

        /// <summary>
        /// 设置操作权限
        /// </summary>
        /// <param name="node">TreeListNode</param>
        private void SetAction(TreeListNode node)
        {
            // 根据节点类型获取需改变节点列表
            IEnumerable<AppTree> list;
            var id = node.GetValue("id").ToString();
            switch ((int)node.GetValue("NodeType"))
            {
                case 0:
                    var ids = actions.Where(a => a.parentId == id).Select(a => a.id);
                    list = actions.Where(a => ids.Any(i => i == a.parentId));
                    break;
                case 1:
                    list = actions.Where(a => a.parentId == id);
                    break;
                default:
                    list = new List<AppTree> {actions.Single(a => a.id == id)};
                    break;
            }

            // 遍历列表更改权限状态
            foreach (var action in list)
            {
                switch (node.CheckState)
                {
                    case CheckState.Unchecked:
                        action.permit = null;
                        action.remark = null;
                        break;
                    case CheckState.Indeterminate:
                        action.permit = false;
                        action.remark = "拒绝";
                        break;
                    case CheckState.Checked:
                        action.permit = true;
                        action.remark = "允许";
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
            IEnumerable<AppTree> list;
            var id = node.GetValue("id").ToString();
            switch ((int)node.GetValue("NodeType"))
            {
                case 0:
                    var ids = datas.Where(a => a.parentId == id).Select(a => a.id);
                    list = datas.Where(a => ids.Any(i => i == a.parentId));
                    break;
                case 1:
                    list = datas.Where(a => a.parentId == id);
                    break;
                default:
                    list = new List<AppTree> {datas.Single(a => a.id == id)};
                    break;
            }

            // 遍历列表更改权限状态
            foreach (var data in list)
            {
                switch (node.CheckState)
                {
                    case CheckState.Unchecked:
                        data.permit = null;
                        data.remark = null;
                        break;
                    case CheckState.Indeterminate:
                        data.permit = false;
                        data.remark = "只读";
                        break;
                    case CheckState.Checked:
                        data.permit = true;
                        data.remark = "读写";
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
            var id = e.Node.GetValue("id").ToString();
            RefreshActions(id, e.Node.Checked);
            if (!e.Node.Checked) return;

            // 根据现已权限设置权限树节点状态
            foreach (var action in role.funcs.Where(a => a.parentId == id))
            {
                var node = view.TreAction.FindNodeByKeyID(action.id);
                var state = action.permit.HasValue
                    ? (action.permit.Value ? CheckState.Checked : CheckState.Indeterminate)
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
            var id = e.Node.GetValue("id").ToString();
            RefreshDatas(id, e.Node.Checked);
            if (!e.Node.Checked) return;

            // 根据现已权限设置权限树节点状态
            foreach (var data in role.datas.Where(a => a.parentId == id))
            {
                var node = view.TreDataPerm.FindNodeByKeyID(data.id);
                var state = data.permit.HasValue
                    ? (data.permit.Value ? CheckState.Checked : CheckState.Indeterminate)
                    : CheckState.Unchecked;
                view.TreDataPerm.SetNodeCheckState(node, state, true);
            }
        }

        /// <summary>
        /// 刷新操作资源树
        /// </summary>
        /// <param name="id">模块id</param>
        /// <param name="add">是否增加</param>
        private void RefreshActions(string id, bool add)
        {
            var module = actions.Single(m => m.id == id);
            var group = actions.Single(g => g.id == module.parentId);
            var funcs = actions.Where(a => a.parentId == id);
            if (add)
            {
                if (role.funcs.All(g => g.id != group.id)) role.funcs.Add(group);

                if (role.funcs.All(m => m.id != module.id)) role.funcs.Add(module);

                role.funcs.AddRange(funcs.Where(action => role.funcs.All(a => a.id != action.id)));
            }
            else
            {
                role.funcs.RemoveAll(a => a.parentId == id);
                role.funcs.Remove(module);
                if (role.funcs.All(a => a.parentId != group.id)) role.funcs.Remove(group);
            }
            view.TreAction.RefreshDataSource();
            view.TreAction.ExpandToLevel(0);
        }

        /// <summary>
        /// 刷新数据资源树
        /// </summary>
        /// <param name="id">模块id</param>
        /// <param name="add">是否增加</param>
        private void RefreshDatas(string id, bool add)
        {
            var module = datas.Single(m => m.id == id);
            var group = datas.Single(g => g.id == module.parentId);
            var dataList = datas.Where(d => d.parentId == id);
            if (add)
            {
                if (role.datas.All(g => g.id != group.id)) role.datas.Add(group);

                if (role.datas.All(m => m.id != module.id)) role.datas.Add(module);

                role.datas.AddRange(dataList.Where(data => role.datas.All(d => d.id != data.id)));
            }
            else
            {
                role.datas.RemoveAll(a => a.parentId == id);
                role.datas.Remove(module);
                if (role.datas.All(a => a.parentId != group.id)) role.datas.Remove(group);
            }
            view.TreDataPerm.RefreshDataSource();
            view.TreDataPerm.ExpandToLevel(0);
        }
    }
}
