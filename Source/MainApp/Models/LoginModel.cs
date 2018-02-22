using System;
using System.Collections.Generic;
using System.Threading;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainApp.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainApp.Models
{
    public class LoginModel
    {
        public Login View = new Login();
        public bool TestPass;

        private List<LookUpMember> _DeptList = new List<LookUpMember>();
        private string _Account = Config.UserName();
        private string _Password;
        private DateTime _Time;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public LoginModel()
        {
            View.UserNameInput.EditValueChanged += (sender, args) => _Account = View.UserNameInput.Text.Trim();
            View.UserNameInput.ParseEditValue += (sender, args) => RefreshDeptList();
            View.PassWordInput.EditValueChanged += (sender, args) => _Password = View.PassWordInput.Text;
            View.DepartmentLookUp.EditValueChanged += (sender, args) => DeptChanged();
        }

        /// <summary>
        /// 测试服务器是否可用
        /// </summary>
        /// <returns>bool 是否通过测试</returns>
        public void Test()
        {
            //测试验证服务器
            TestPass = true;
            var url = $"{Params.Token.BaseServer}/securityapi/v1.0/test";
            var client = new HttpClient<object>(null);
            if (!client.Get(url))
            {
                Messages.ShowError(client.Message);
                if (client.Code == "400")
                {
                    Messages.ShowError("验证服务器配置错误！");
                    TestPass = false;
                }
            }
            else
            {
                // 测试应用服务器
                url = $"{Params.InsightServer}/commonapi/v1.0/test";
                if (!client.Get(url))
                {
                    Messages.ShowError(client.Message);
                    if (client.Code == "400")
                    {
                        Messages.ShowError("应用服务器配置错误！");
                        TestPass = false;
                    }
                }
            }

            // 根据测试结果设置控件可用
            View.UserNameInput.Enabled = TestPass;
            View.PassWordInput.Enabled = TestPass;
            View.LoginButton.Enabled = TestPass;
        }

        /// <summary>
        /// 初始化默认登录用户
        /// </summary>
        public void InitUserName()
        {
            if (string.IsNullOrEmpty(_Account)) return;

            View.UserNameInput.EditValue = _Account;
            View.PassWordInput.Focus();
        }

        /// <summary>
        /// 验证用户输入，通过验证后获取用户AccessToken
        /// </summary>
        /// <returns>bool 是否登录成功</returns>
        public bool Login()
        {
            if (string.IsNullOrEmpty(_Account))
            {
                Messages.ShowMessage("请输入用户名！");
                View.UserNameInput.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(_Password))
            {
                Messages.ShowWarning("密码不能为空！");
                View.PassWordInput.Focus();
                return false;
            }

            var time = 3200 - (int) (DateTime.Now - _Time).TotalMilliseconds;
            Thread.Sleep(time < 0 ? 0: time);
            Params.Token.Account = _Account;
            Params.Token.Signature(_Password);
            Params.Token.GetTokens();
            if (!Params.Token.Success) return false;

            Params.NeedChangePW = _Password == "123456";
            Config.SaveUserName(_Account);
            return true;
        }

        /// <summary>
        /// 根据用户登录账号获取可登录部门列表
        /// </summary>
        private void RefreshDeptList()
        {
            if (string.IsNullOrEmpty(_Account)) return;

            _Time = DateTime.Now;
            var url = $"{Params.Token.BaseServer}/organizationapi/v1.0/orgs/logindept?account={_Account}";
            var client = new HttpClient<List<LookUpMember>>(Params.Token);
            if (!client.Get(url)) return;

            _DeptList = client.Data;
            Format.InitLookUpEdit(View.DepartmentLookUp, _DeptList);
            View.DepartmentLookUp.Enabled = _DeptList.Count > 1;
            if (_DeptList.Count == 0) return;

            View.DepartmentLookUp.EditValue = _DeptList[0].ID;
        }

        /// <summary>
        /// 登录部门变化后更新相关信息
        /// </summary>
        private void DeptChanged()
        {
            Params.Token.Token.deptId = View.DepartmentLookUp.EditValue.ToString();
            Params.DeptName = View.DepartmentLookUp.Text;
        }
    }
}
