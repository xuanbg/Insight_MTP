using System.Collections.Generic;
using Insight.MTP.Client.Base.Apps.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Apps.Models
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
            // 订阅界面事件
            view.GdvApp.FocusedRowObjectChanged += (sender, args) => ItemChanged(args.FocusedRowHandle);

            // 设置界面样式
            Format.GridFormat(view.GdvApp);
            Format.TreeFormat(view.TreNav);
            Format.GridFormat(view.GdvFunc);
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void Refresh()
        {
            LoadData();
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadData(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{server}/userapi/v1.0/users?rows={rows}&page={page}&key={key}";
            var client = new HttpClient<List<Tenant>>(token);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            list = client.data;
            view.GrdApp.DataSource = list;
            view.GdvApp.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="data"></param>
        public void AddItem(Tenant data)
        {
            list.Add(data);

            view.GdvApp.RefreshData();
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
            var msg = $"您确定要删除用户【{item.name}】吗？\r\n用户删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除用户【{item.name}】！\r\n如果您想禁止该用户登录系统，请使用封禁功能。";
            var url = $"{server}/userapi/v1.0/users/{item.id}";
            var client = new HttpClient<object>(token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            list.Remove(item);
            view.GdvApp.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void RefreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editApp"] = !item?.isBuiltin ?? false,
                ["deleteApp"] = !item?.isBuiltin ?? false,
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        private void ItemChanged(int index)
        {
            item = index < 0 ? null : list[index];
            if (item != null && (item.apps == null || item.users == null)) GetDetail();


            RefreshToolBar();
        }

        /// <summary>
        /// 获取明细数据
        /// </summary>
        private void GetDetail()
        {
            var url = $"{server}/userapi/v1.0/users/{item.id}";
            var client = new HttpClient<Tenant>(token);
            if (!client.Get(url)) return;

            item.apps = client.data.apps;
            item.users = client.data.users;
        }
    }
}