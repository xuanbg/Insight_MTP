using System.Collections.Generic;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class ChangPwModel
    {
        public ChangePw View = new ChangePw();

        private string _Sing;
        private string _NewPw;
        private string _ConfirmPw;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ChangPwModel()
        {
            View.Password.EditValueChanged += (sender, args) => _Sing = Util.Hash(Params.Token.Token.userId + Util.Hash(View.Password.Text));
            View.NewPw.EditValueChanged += (sender, args) => _NewPw = View.NewPw.Text;
            View.ConfirmPw.EditValueChanged += (sender, args) => _ConfirmPw = View.ConfirmPw.Text;
        }

        /// <summary>
        /// 初始化对话框
        /// </summary>
        public void Init()
        {
            View.Password.EditValue = null;
            View.NewPw.EditValue = null;
            View.ConfirmPw.EditValue = null;
            View.Refresh();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns>bool 是否修改成功</returns>
        public bool Save()
        {
            if (_Sing != Params.Token.Sign)
            {
                Messages.ShowError("请输入正确的原密码，否则无法为您更换密码！");
                View.Password.EditValue = null;
                View.Password.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(_NewPw))
            {
                Messages.ShowWarning("新密码不能为空，请输入您的新密码并牢记！");
                View.NewPw.Focus();
                return false;
            }

            if (_NewPw == "123456")
            {
                Messages.ShowWarning("新密码不能设为初始密码，请输入其它密码并牢记！");
                View.NewPw.EditValue = null;
                View.ConfirmPw.EditValue = null;
                View.NewPw.Focus();
                return false;
            }

            if (_NewPw != _ConfirmPw)
            {
                Messages.ShowWarning("两次密码输入不一致！\r\n请重新确认密码，只有两次输入的密码一致，才能为您更换密码。");
                View.ConfirmPw.EditValue = null;
                View.ConfirmPw.Focus();
                return false;
            }

            const string msg = "更换密码失败！请检查网络状况，并再次进行更换密码操作。";
            var url = $"{Params.Token.BaseServer}/userapi/v1.0/users/{Params.Token.Account}/signature";
            var publicKey = Util.Base64Decode(Util.GetAppSetting("RSAKey"));
            var key = Util.Encrypt(publicKey, Util.Hash(_NewPw));

            var dict = new Dictionary<string, object> {{"password", key}};
            var client = new HttpClient<object>(Params.Token);
            if (!client.Put(url, dict, msg)) return false;

            Params.Token.Signature(_NewPw);
            Messages.ShowMessage("更换密码成功！请牢记新密码并使用新密码登录系统。");
            return true;
        }
    }
}