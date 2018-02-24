using System.Collections.Generic;
using Insight.MTP.Client.Base.Users.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Users.Models
{
    public class ManagerModel : MdiModel<Manager>
    {
        public User user;

        private List<User> users;
        private int userRows = 40;
        private bool first = true;
        private string key;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(Navigation info) : base(info)
        {
            // 订阅用户列表分页控件事件
            view.TabUser.PageSizeChanged += (sender, args) => userRows = args.PageSize;
            view.TabUser.CurrentPageChanged += (sender, args) => LoadUsers(view.TabUser.CurrentPage, args.RowHandle);
            view.TabUser.TotalRowsChanged += (sender, args) => view.GdvUser.FocusedRowHandle = args.RowHandle;

            // 订阅界面事件
            view.GdvUser.FocusedRowObjectChanged += (sender, args) => UserChanged(args.FocusedRowHandle);
            view.Search.Click += (sender, args) => LoadUsers();
            view.KeyInput.Properties.Click += (sender, args) => view.KeyInput.EditValue = null;
            view.KeyInput.EditValueChanged += (sender, args) => key = view.KeyInput.Text.Trim();
            view.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                LoadUsers();
            };

            // 设置界面样式
            Format.GridFormat(view.GdvUser);
            Format.TreeFormat(view.TreAction, NodeIconType.NodeType);
            Format.TreeFormat(view.TreData, NodeIconType.NodeType);
        }

        /// <summary>
        /// 刷新用户列表
        /// </summary>
        public void Refresh()
        {
            LoadUsers(view.TabUser.CurrentPage, view.TabUser.FocusedRowHandle);
        }

        /// <summary>
        /// 加载用户列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadUsers(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{Params.server}/userapi/v1.0/users?rows={userRows}&page={page}&key={key}";
            var client = new HttpClient<List<User>>(Params.tokenHelper);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            users = client.data;
            view.TabUser.TotalRows = int.Parse(client.option.ToString());
            view.GrdUser.DataSource = users;
            view.GdvUser.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="data">UserInfo</param>
        public void AddUser(User data)
        {
            users.Add(data);

            view.TabUser.AddItems();
            view.GdvUser.RefreshData();
        }

        /// <summary>
        /// 更新用户数据
        /// </summary>
        /// <param name="data">UserInfo</param>
        public void Update(User data)
        {
            user.name = data.name;
            user.remark = data.remark;
            view.GdvUser.RefreshData();
        }

        /// <summary>
        /// 删除当前选中用户
        /// </summary>
        public void DeleteUser()
        {
            var msg = $"您确定要删除用户【{user.name}】吗？\r\n用户删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除用户【{user.name}】！\r\n如果您想禁止该用户登录系统，请使用封禁功能。";
            var url = $"{Params.server}/userapi/v1.0/users/{user.id}";
            var client = new HttpClient<object>(Params.tokenHelper);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            users.Remove(user);
            view.TabUser.RemoveItems();
            view.GdvUser.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 封禁/解封当前选中用户
        /// </summary>
        /// <param name="status">用户状态</param>
        public void SetStatus(bool status)
        {
            var action = status ? "解封" : "封禁";
            var str = status ? "即可正常" : "将无法";
            var msg = $"您确定要{action}用户【{user.name}】吗？\r\n用户{action}后{str}登录系统！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            var url = $"{Params.server}/userapi/v1.0/users/{user.id}/validity";
            var dict = new Dictionary<string, object> {{"validity", status}};
            var client = new HttpClient<object>(Params.tokenHelper);
            if (!client.Put(url, dict))
            {
                CloseWaitForm();
                return;
            }

            user.isInvalid = !status;
            view.GdvUser.RefreshData();
            RefreshToolBar();
            CloseWaitForm();
        }

        /// <summary>
        /// 重置当前选中用户的密码
        /// </summary>
        public void Reset()
        {
            var msg = $"您确定要重置用户【{user.name}】的密码为 123456 吗？";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，用户【{user.name}】的密码重置失败。";
            var url = $"{Params.server}/userapi/v1.0/users/{user.id}/signature";
            var dict = new Dictionary<string, object> {{"password", Util.Hash("123456") } };
            var client = new HttpClient<object>(Params.tokenHelper);
            if (!client.Put(url, dict, msg))
            {
                CloseWaitForm();
                return;
            }

            CloseWaitForm();
            Messages.ShowMessage($"用户【{user.name}】的密码已经重置。");
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void RefreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editUser"] = !user?.isBuiltin ?? false,
                ["deleteUser"] = !user?.isBuiltin ?? false,
                ["banned"] = (!user?.isBuiltin ?? false) && (!user?.isInvalid ?? false),
                ["release"] = user?.isInvalid ?? false,
                ["reset"] = !user?.isBuiltin ?? false
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="index">List下标</param>
        private void UserChanged(int index)
        {
            view.TabUser.FocusedRowHandle = index;
            user = index < 0 ? null : users[index];
            if (user != null && (user.funcs == null || user.datas == null)) GetUser();

            view.TreAction.DataSource = user?.funcs;
            view.TreAction.ExpandToLevel(0);
            view.TreData.DataSource = user?.datas;
            view.TreData.ExpandToLevel(0);

            RefreshToolBar();

            if (!first) return;

            view.tabPermission.SelectedTabPageIndex = 0;
            first = false;
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        private void GetUser()
        {
            var url = $"{Params.server}/userapi/v1.0/users/{user.id}";
            var client = new HttpClient<User>(Params.tokenHelper);
            if (!client.Get(url)) return;

            user.funcs = client.data.funcs;
            user.datas = client.data.datas;
        }
    }
}