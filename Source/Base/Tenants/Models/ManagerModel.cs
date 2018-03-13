using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class ManagerModel : MdiModel<Manager>
    {
        public Tenant item;

        private List<Tenant> list;
        private int rows = 20;
        private string key;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(Navigation info) : base(info)
        {
            // 订阅租户列表分页控件事件
            view.tabTenant.PageSizeChanged += (sender, args) => rows = args.PageSize;
            view.tabTenant.CurrentPageChanged += (sender, args) => LoadData(view.tabTenant.CurrentPage, args.RowHandle);
            view.tabTenant.TotalRowsChanged += (sender, args) => view.gdvTenant.FocusedRowHandle = args.RowHandle;

            // 订阅用户列表分页控件事件
            view.tabUser.PageSizeChanged += (sender, args) => rows = args.PageSize;
            view.tabUser.CurrentPageChanged += (sender, args) => LoadData(view.tabUser.CurrentPage, args.RowHandle);
            view.tabUser.TotalRowsChanged += (sender, args) => view.gdvUser.FocusedRowHandle = args.RowHandle;

            // 订阅界面事件
            view.gdvTenant.FocusedRowObjectChanged += (sender, args) => ItemChanged(args.FocusedRowHandle);
            view.Search.Click += (sender, args) => LoadData();
            view.KeyInput.Properties.Click += (sender, args) => view.KeyInput.EditValue = null;
            view.KeyInput.EditValueChanged += (sender, args) => key = view.KeyInput.Text.Trim();
            view.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                LoadData();
            };

            // 设置界面样式
            Format.GridFormat(view.gdvTenant);
            Format.GridFormat(view.gdvApp);
            Format.GridFormat(view.gdvUser);
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void Refresh()
        {
            LoadData(view.tabTenant.CurrentPage, view.tabTenant.FocusedRowHandle);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadData(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{server}/tenantapi/v1.0/tenants?rows={rows}&page={page}&key={key}";
            var client = new HttpClient<List<Tenant>>(token);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            list = client.data;
            view.tabTenant.TotalRows = int.Parse(client.option.ToString());
            view.grdTenant.DataSource = list;
            view.gdvTenant.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data"></param>
        public void AddItem(Tenant data)
        {
            list.Add(data);

            view.tabTenant.AddItems();
            view.gdvTenant.RefreshData();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="data">UserInfo</param>
        public void Update(Tenant data)
        {
            Util.CopyValue(data, item);
        }

        /// <summary>
        /// 删除当前选中数据
        /// </summary>
        public void DeleteItem()
        {
            var msg = $"您确定要删除租户【{item.name}】吗？\r\n租户删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法租除用户【{item.name}】！";
            var url = $"{server}/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<object>(token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            list.Remove(item);
            view.tabTenant.RemoveItems();
            view.gdvTenant.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void RefreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editTenant"] = item != null,
                ["deleteTenant"] = item != null,
                ["bindApp"] = item != null,
                ["extend"] = item != null
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void ItemChanged(int index)
        {
            view.tabTenant.FocusedRowHandle = index;
            item = index < 0 ? null : list[index];
            if (item != null && (item.apps == null || item.users == null)) GetDetail();

            view.grdApp.DataSource = item?.apps;
            view.grdUser.DataSource = item?.users;

            RefreshToolBar();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        private void GetDetail()
        {
            var url = $"{server}/tenantapi/v1.0/tenants/{item.id}";
            var client = new HttpClient<Tenant>(token);
            if (!client.Get(url)) return;

            item.apps = client.data.apps;
            item.users = client.data.users;
        }
    }
}