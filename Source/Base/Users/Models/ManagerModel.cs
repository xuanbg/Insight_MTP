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
        public User User;

        private List<User> _Users;
        private int _UserRows = 40;
        private bool _First = true;
        private string _Key;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ManagerModel(ModuleInfo info) : base(info)
        {
            // 订阅用户列表分页控件事件
            View.TabUser.PageSizeChanged += (sender, args) => _UserRows = args.PageSize;
            View.TabUser.CurrentPageChanged += (sender, args) => LoadUsers(View.TabUser.CurrentPage, args.RowHandle);
            View.TabUser.TotalRowsChanged += (sender, args) => View.GdvUser.FocusedRowHandle = args.RowHandle;

            // 订阅界面事件
            View.GdvUser.FocusedRowObjectChanged += (sender, args) => UserChanged(args.FocusedRowHandle);
            View.Search.Click += (sender, args) => LoadUsers();
            View.KeyInput.Properties.Click += (sender, args) => View.KeyInput.EditValue = null;
            View.KeyInput.EditValueChanged += (sender, args) => _Key = View.KeyInput.Text.Trim();
            View.KeyInput.KeyPress += (sender, args) =>
            {
                if (args.KeyChar != 13) return;

                LoadUsers();
            };

            // 设置界面样式
            Format.GridFormat(View.GdvUser);
            Format.TreeFormat(View.TreAction, NodeIconType.NodeType);
            Format.TreeFormat(View.TreData, NodeIconType.NodeType);
        }

        /// <summary>
        /// 刷新用户列表
        /// </summary>
        public void Refresh()
        {
            LoadUsers(View.TabUser.CurrentPage, View.TabUser.FocusedRowHandle);
        }

        /// <summary>
        /// 加载用户列表数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="handel">当前焦点行</param>
        public void LoadUsers(int page = 1, int handel = 0)
        {
            ShowWaitForm();
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users?rows={_UserRows}&page={page}&key={_Key}";
            var client = new HttpClient<List<User>>(Params.Token);
            if (!client.Get(url))
            {
                CloseWaitForm();
                return;
            }

            _Users = client.Data;
            View.TabUser.TotalRows = int.Parse(client.Option.ToString());
            View.GrdUser.DataSource = _Users;
            View.GdvUser.FocusedRowHandle = handel;
            CloseWaitForm();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user">UserInfo</param>
        public void AddUser(User user)
        {
            _Users.Add(user);

            View.TabUser.AddItems();
            View.GdvUser.RefreshData();
        }

        /// <summary>
        /// 更新用户数据
        /// </summary>
        /// <param name="user">UserInfo</param>
        public void Update(User user)
        {
            User.name = user.name;
            User.description = user.description;
            View.GdvUser.RefreshData();
        }

        /// <summary>
        /// 删除当前选中用户
        /// </summary>
        public void DeleteUser()
        {
            var msg = $"您确定要删除用户【{User.loginName}】吗？\r\n用户删除后将无法恢复！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，无法删除用户【{User.loginName}】！\r\n如果您想禁止该用户登录系统，请使用封禁功能。";
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users/{User.id}";
            var client = new HttpClient<object>(Params.Token);
            if (!client.Delete(url, null, msg))
            {
                CloseWaitForm();
                return;
            }

            _Users.Remove(User);
            View.TabUser.RemoveItems();
            View.GdvUser.RefreshData();
            CloseWaitForm();
        }

        /// <summary>
        /// 封禁/解封当前选中用户
        /// </summary>
        /// <param name="status">用户状态</param>
        public void SetStatus(bool status)
        {
            var key = status ? "解封" : "封禁";
            var action = status ? "即可正常" : "将无法";
            var msg = $"您确定要{key}用户【{User.loginName}】吗？\r\n用户{key}后{action}登录系统！";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users/{User.loginName}/validity";
            var dict = new Dictionary<string, object> {{"validity", status}};
            var client = new HttpClient<object>(Params.Token);
            if (!client.Put(url, dict))
            {
                CloseWaitForm();
                return;
            }

            User.validity = status;
            View.GdvUser.RefreshData();
            RefreshToolBar();
            CloseWaitForm();
        }

        /// <summary>
        /// 重置当前选中用户的密码
        /// </summary>
        public void Reset()
        {
            var msg = $"您确定要重置用户【{User.loginName}】的密码为 123456 吗？";
            if (!Messages.ShowConfirm(msg)) return;

            ShowWaitForm();
            msg = $"对不起，用户【{User.loginName}】的密码重置失败。";
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users/{User.loginName}/signature";
            var publicKey = Util.Base64Decode(Util.GetAppSetting("RSAKey"));
            var key = Util.Encrypt(publicKey, Util.Hash("123456"));
            var dict = new Dictionary<string, object> {{"password", key}};
            var client = new HttpClient<object>(Params.Token);
            if (!client.Put(url, dict, msg))
            {
                CloseWaitForm();
                return;
            }

            CloseWaitForm();
            Messages.ShowMessage($"用户【{User.loginName}】的密码已经重置。");
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void RefreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["EditUser"] = !User?.builtIn ?? false,
                ["DeleteUser"] = !User?.builtIn ?? false,
                ["Banned"] = (!User?.builtIn ?? false) && (User?.validity ?? false),
                ["Release"] = !User?.validity ?? false,
                ["Reset"] = !User?.builtIn ?? false
            };
            SwitchItemStatus(dict);
        }

        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="index">List下标</param>
        private void UserChanged(int index)
        {
            View.TabUser.FocusedRowHandle = index;
            User = index < 0 ? null : _Users[index];
            if (User != null && (User.Actions == null || User.Datas == null)) GetUser();

            View.TreAction.DataSource = User?.Actions;
            View.TreAction.ExpandToLevel(0);
            View.TreData.DataSource = User?.Datas;
            View.TreData.ExpandToLevel(0);

            RefreshToolBar();

            if (!_First) return;

            View.tabPermission.SelectedTabPageIndex = 0;
            _First = false;
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        private void GetUser()
        {
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users/{User.id}";
            var client = new HttpClient<User>(Params.Token);
            if (!client.Get(url)) return;

            User.Actions = client.Data.Actions;
            User.Datas = client.Data.Datas;
        }
    }
}