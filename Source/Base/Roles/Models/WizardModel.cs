using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Insight.MTP.Client.Base.Roles.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;

namespace Insight.MTP.Client.Base.Roles.Models
{
    public class WizardModel: DialogModel
    {
        public Wizard view;

        private readonly Role role;
        private List<AppTree> funcModules;
        private List<AppTree> funcs;
        private List<AppTree> dataModules;
        private List<AppTree> datas;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">RoleInfo</param>
        /// <param name="title">View标题</param>
        public WizardModel(Role data, string title)
        {
            role = data;
            role.funcs = new List<AppTree>();
            role.datas = new List<AppTree>();

            // 构造Wizard视图并设置控件样式
            view = new Wizard
            {
                Text = title,
                NameInput = {EditValue = data.name},
                lueApp = {EditValue = data.appId},
                Description = {EditValue = data.remark}
            };
            view.PagInfo.AllowNext = view.NameInput.EditValue != null;

            // 订阅控件事件实现数据双向绑定
            view.NameInput.EditValueChanged += (sender, args) =>
            {
                role.name = view.NameInput.Text.Trim();
                view.PagInfo.AllowNext = view.NameInput.EditValue != null;
            };
            view.lueApp.EditValueChanged += (sender, args) => role.appId = view.lueApp.EditValue.ToString();
            view.Description.EditValueChanged += (sender, args) =>
            {
                var text = view.Description.EditValue?.ToString().Trim();
                role.remark = string.IsNullOrEmpty(text) ? null : text;
            };
            view.TreFuncModule.AfterCheckNode += (sender, args) => ModuleTreeChanged(args, view.TreFunc, funcs, role.funcs);
            view.TreFunc.AfterCheckNode += (sender, args) => UpdateNodeData(args.Node, role.funcs);
            view.TreDataModule.AfterCheckNode += (sender, args) => ModuleTreeChanged(args, view.TreData, datas, role.datas);
            view.TreData.AfterCheckNode += (sender, args) => UpdateNodeData(args.Node, role.datas);
            view.Shown += (sender, args) =>
            {
                view.NameInput.Focus();
                RefreshTree(view.TreFuncModule, view.TreFunc, funcModules, funcs, role.funcs);
                RefreshTree(view.TreDataModule, view.TreData, dataModules, datas, role.datas);
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
            var url = $"{server}/roleapi/v1.0/roles";
            var dict = new Dictionary<string, object> {{"role", role}};
            var client = new HttpClient<Role>(token);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        internal Role EditRole()
        {
            var msg = "角色权限更新失败！如多次失败，请联系管理员。";
            var url = $"{server}/roleapi/v1.0/roles/{role.id}";
            var dict = new Dictionary<string, object> {{"role", role}};
            var client = new HttpClient<Role>(token);
            return client.Put(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 根据当前权限刷新权限树
        /// </summary>
        /// <param name="moduleTree"></param>
        /// <param name="tree"></param>
        /// <param name="modules"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public void RefreshTree(TreeList moduleTree, TreeList tree, List<AppTree> modules, List<AppTree> source, List<AppTree> target)
        {
            // 设置ModuleTree和ActionTree选中状态
            moduleTree.ExpandToLevel(0);
            foreach (var module in modules.Where(m => m.permit.HasValue && m.permit.Value))
            {
                var node = moduleTree.FindNodeByKeyID(module.id);
                moduleTree.SetNodeCheckState(node, CheckState.Checked, true);
                AddItem(module.id, source, target);
                AddParent(module.id, source, target);
            }

            var first = tree.Nodes.FirstNode;
            tree.RefreshDataSource();
            tree.ExpandToLevel(0);
            tree.FocusedNode = first;
            tree.Refresh();
            RefreshCheckState(tree, role.funcs);
        }

        /// <summary>
        /// 初始化权限树
        /// </summary>
        private void InitTree()
        {
            // 加载数据
            var url = $"{server}/roleapi/v1.0/roles/{role.id}/allperm";
            var client = new HttpClient<Role>(token);
            if (!client.Get(url)) return;

            funcs = client.data.funcs;
            funcModules = funcs.Where(a => a.nodeType < 3).ToList();
            datas = client.data.datas;
            dataModules = datas.Where(d => d.nodeType < 3).ToList();

            // 绑定数据源，设置TreeList样式
            view.TreFuncModule.DataSource = funcModules;
            Format.TreeFormat(view.TreFuncModule, NodeIconType.NodeType);

            view.TreFunc.DataSource = role.funcs;
            Format.TreeFormat(view.TreFunc, NodeIconType.NodeType);

            view.TreDataModule.DataSource = dataModules;
            Format.TreeFormat(view.TreDataModule, NodeIconType.NodeType);

            view.TreData.DataSource = role.datas;
            Format.TreeFormat(view.TreData, NodeIconType.NodeType);
        }

        /// <summary>
        /// 改变业务模块选中状态后刷新功能操作树
        /// </summary>
        /// <param name="e">NodeEventArgs</param>
        /// <param name="tree">TreeList</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private void ModuleTreeChanged(NodeEventArgs e, TreeList tree, List<AppTree> source, List<AppTree> target)
        {
            // 将选中模块加入权限树
            var id = e.Node.GetValue("id").ToString();
            ChangeNodes(id, source, target, e.Node.Checked);

            var node = tree.Nodes.FirstNode;
            tree.RefreshDataSource();
            tree.ExpandToLevel(0);
            tree.FocusedNode = node;
            tree.Refresh();
            if (!e.Node.Checked) return;

            RefreshCheckState(tree, role.funcs);
        }

        /// <summary>
        /// 设置操作权限
        /// </summary>
        /// <param name="node">TreeListNode</param>
        /// <param name="list">节点数据集</param>
        private static void UpdateNodeData(TreeListNode node, List<AppTree> list)
        {
            foreach (TreeListNode n in node.Nodes)
            {
                UpdateNodeData(n, list);
            }

            var id = node.GetValue("id").ToString();
            var item = list.Single(i => i.id == id);
            if (item.nodeType < 3) return;

            switch (node.CheckState)
            {
                case CheckState.Unchecked:
                    item.permit = null;
                    item.remark = null;
                    break;
                case CheckState.Indeterminate:
                    item.permit = false;
                    item.remark = "拒绝";
                    break;
                case CheckState.Checked:
                    item.permit = true;
                    item.remark = "允许";
                    break;
            }

            node.TreeList.RefreshDataSource();
        }

        /// <summary>
        /// 更新树节点
        /// </summary>
        /// <param name="id">节点id</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        /// <param name="isChecked">是否增加</param>
        private static void ChangeNodes(string id, List<AppTree> source, List<AppTree> target, bool isChecked)
        {
            if (isChecked)
            {
                AddItem(id, source, target);
                AddParent(id, source, target);
            }
            else
            {
                RemoveItem(id, source, target);
                RemoveParent(id, source, target);
            }
        }

        /// <summary>
        /// 根据节点数据集刷新对应节点的选中状态
        /// </summary>
        /// <param name="tree">TreeList</param>
        /// <param name="list">节点数据集</param>
        private static void RefreshCheckState(TreeList tree, IEnumerable<AppTree> list)
        {
            foreach (var item in list.Where(i => i.nodeType > 2))
            {
                var node = tree.FindNodeByKeyID(item.id);
                var state = item.permit == null ? CheckState.Unchecked
                    : (item.permit.Value ? CheckState.Checked : CheckState.Indeterminate);
                tree.SetNodeCheckState(node, state, true);
            }
        }

        /// <summary>
        /// 将指定ID的节点的下级节点加入到功能树
        /// </summary>
        /// <param name="id">节点ID</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void AddItem(string id, List<AppTree> source, List<AppTree> target)
        {
            foreach (var item in source.Where(i => i.parentId == id))
            {
                if (target.Any(i => i.id == item.id)) return;

                target.Add(item);
                AddItem(item.id, source, target);
            }
        }

        /// <summary>
        /// 将指定ID的节点加入到功能树
        /// </summary>
        /// <param name="id">节点ID</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void AddParent(string id, List<AppTree> source, List<AppTree> target)
        {
            var item = source.SingleOrDefault(i => i.id == id);
            if (item == null || target.Any(i => i.id == id)) return;

            target.Add(item);
            AddParent(item.parentId, source, target);
        }

        /// <summary>
        /// 将指定ID的节点的下级节点从功能树中移除
        /// </summary>
        /// <param name="id">节点ID</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void RemoveItem(string id, List<AppTree> source, List<AppTree> target)
        {
            foreach (var item in source.Where(i => i.parentId == id))
            {
                RemoveItem(item.id, source, target);
                target.RemoveAll(i => i.parentId == id);
            }
        }

        /// <summary>
        /// 将指定ID的节点从功能树中移除
        /// </summary>
        /// <param name="id">节点ID</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void RemoveParent(string id, List<AppTree> source, List<AppTree> target)
        {
            var item = source.SingleOrDefault(i => i.id == id);
            if (item == null || target.Any(i => i.parentId == id)) return;

            RemoveParent(item.parentId, source, target);
            target.RemoveAll(i => i.id == id);
        }
    }
}
