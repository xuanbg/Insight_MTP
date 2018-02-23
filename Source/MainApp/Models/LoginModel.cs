using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainApp.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainApp.Models
{
    public class LoginModel
    {
        public Login login = new Login();

        private string account = Config.UserName();
        private string password;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public LoginModel()
        {
            login.UserNameInput.EditValueChanged += (sender, args) => account = login.UserNameInput.Text.Trim();
            login.PassWordInput.EditValueChanged += (sender, args) => password = login.PassWordInput.Text;
        }

        /// <summary>
        /// 初始化默认登录用户
        /// </summary>
        public void InitUserName()
        {
            if (string.IsNullOrEmpty(account)) return;

            login.UserNameInput.EditValue = account;
            login.PassWordInput.Focus();
        }

        /// <summary>
        /// 验证用户输入，通过验证后获取用户AccessToken
        /// </summary>
        /// <returns>bool 是否登录成功</returns>
        public bool Login()
        {
            if (string.IsNullOrEmpty(account))
            {
                Messages.ShowMessage("请输入用户名！");
                login.UserNameInput.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                Messages.ShowWarning("密码不能为空！");
                login.PassWordInput.Focus();
                return false;
            }

            Params.tokenHelper.tenantId = "2564cd55-9cd3-40f0-b814-09723fd8632a";
            Params.tokenHelper.account = account;
            Params.tokenHelper.Signature(password);
            Params.tokenHelper.GetTokens();
            if (!Params.tokenHelper.success) return false;

            Params.userId = Params.tokenHelper.userId;
            Params.needChangePw = password == "123456";
            Config.SaveUserName(account);
            GetUserInfo();

            return true;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        private static void GetUserInfo()
        {
            var url = $"{Params.server}/userapi/v1.0/users/{Params.userId}";
            var client = new HttpClient<User>(Params.tokenHelper);
            if (!client.Get(url)) return;

            Params.userId = client.data.id;
            Params.userName = client.data.name;
        }
    }
}
