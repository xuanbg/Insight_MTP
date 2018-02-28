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
    public class WizardModel: BaseModel
    {
        public Wizard view;

        private readonly Role role;
        private List<LookUpMember> apps;
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
            view.PagHome.AllowNext = view.NameInput.EditValue != null;

            // 订阅控件事件实现数据双向绑定
            view.NameInput.EditValueChanged += (sender, args) =>
            {
                role.name = view.NameInput.Text.Trim();
                view.PagHome.AllowNext = view.NameInput.EditValue != null;
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
            view.Shown += (sender, args) => view.NameInput.Focus();
            view.WizRole.NextClick += (sender, args) => InitTree(args.Page.Name);

            Init();
        }

        /// <summary>
        /// 保存角色
        /// </summary>
        public Role AddRole()
        {
            const string msg = "角色权限保存失败！如多次失败，请联系管理员。";
            role.appName = apps.SingleOrDefault(i => i.id == role.appId)?.alias;

            var url = $"{server}/roleapi/v1.0/roles";
            var dict = new Dictionary<string, object> {{"info", role}};
            var client = new HttpClient<Role>(token);

            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        internal Role EditRole()
        {
            const string msg = "角色权限更新失败！如多次失败，请联系管理员。";
            role.appName = apps.SingleOrDefault(i => i.id == role.appId)?.alias;

            var url = $"{server}/roleapi/v1.0/roles/{role.id}";
            var dict = new Dictionary<string, object> {{"info", role}};
            var client = new HttpClient<Role>(token);

            return client.Put(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void Init()
        {
            var url = $"{server}/appapi/v1.0/apps";
            var client = new HttpClient<List<LookUpMember>>(token);
            if (!client.Get(url)) return;

            apps = client.data;
            Format.InitLookUpEdit(view.lueApp, apps);
        }

        /// <summary>
        /// 初始化权限树
        /// </summary>
        /// <param name="page"></param>
        private void InitTree(string page)
        {
            if (page != "PagHome") return;

            var url = $"{server}/roleapi/v1.0/roles/{role.id}/allperm?appid={role.appId}";
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

            RefreshTree(view.TreFuncModule, view.TreFunc, funcModules, funcs, role.funcs);
            RefreshTree(view.TreDataModule, view.TreData, dataModules, datas, role.datas);
        }

        /// <summary>
        /// 根据当前权限刷新权限树
        /// </summary>
        /// <param name="moduleTree">模块树</param>
        /// <param name="tree">权限树</param>
        /// <param name="modules">模块数据集</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void RefreshTree(TreeList moduleTree, TreeList tree, List<AppTree> modules, List<AppTree> source, List<AppTree> target)
        {
            moduleTree.ExpandToLevel(0);
            foreach (var module in modules.Where(m => m.permit.HasValue && m.permit.Value))
            {
                var node = moduleTree.FindNodeByKeyID(module.id);
                moduleTree.SetNodeCheckState(node, CheckState.Checked, true);
                AddParent(module.id, source, target);
                AddItem(module.id, source, target);
            }

            tree.RefreshDataSource();
            var first = tree.Nodes.FirstNode;
            tree.FocusedNode = first;
            tree.ExpandToLevel(0);
            tree.Refresh();

            RefreshCheckState(tree, target);
        }

        /// <summary>
        /// 改变业务模块选中状态后刷新功能操作树
        /// </summary>
        /// <param name="e">NodeEventArgs</param>
        /// <param name="tree">TreeList</param>
        /// <param name="source">数据来源</param>
        /// <param name="target">目标集合</param>
        private static void ModuleTreeChanged(NodeEventArgs e, TreeList tree, List<AppTree> source, List<AppTree> target)
        {
            var id = e.Node.GetValue("id").ToString();
            ChangeNodes(id, source, target, e.Node.Checked);
            tree.RefreshDataSource();

            var node = tree.Nodes.FirstNode;
            tree.FocusedNode = node;
            tree.ExpandToLevel(0);
            tree.Refresh();
            if (!e.Node.Checked) return;

            RefreshCheckState(tree, target);
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
                case CheckState.Indeterminate:
                    item.nodeType = 3;
                    item.permit = false;
                    item.remark = "拒绝";
                    break;
                case CheckState.Checked:
                    item.nodeType = 4;
                    item.permit = true;
                    item.remark = "允许";
                    break;
                case CheckState.Unchecked:
                    item.nodeType = 5;
                    item.permit = null;
                    item.remark = null;
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
                AddParent(id, source, target);
                AddItem(id, source, target);
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

            AddParent(item.parentId, source, target);
            target.Add(item);
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

            target.RemoveAll(i => i.id == id);
            RemoveParent(item.parentId, source, target);
        }
    }
}
