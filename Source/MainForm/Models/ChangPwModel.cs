﻿using System.Collections.Generic;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class ChangPwModel : BaseModel
    {
        public ChangePw view = new ChangePw();

        private string sing;
        private string newPw;
        private string confirmPw;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public ChangPwModel()
        {
            view.Password.EditValueChanged += (sender, args) => sing = Util.Hash(token.account + Util.Hash(view.Password.Text));
            view.NewPw.EditValueChanged += (sender, args) => newPw = view.NewPw.Text;
            view.ConfirmPw.EditValueChanged += (sender, args) => confirmPw = view.ConfirmPw.Text;
        }

        /// <summary>
        /// 初始化对话框
        /// </summary>
        /// <param name="old">旧密码</param>
        public void Init(string old)
        {
            view.Password.EditValue = old;
            view.Password.Enabled = old == null;

            view.NewPw.EditValue = null;
            view.ConfirmPw.EditValue = null;
            view.Refresh();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns>bool 是否修改成功</returns>
        public bool Save()
        {
            if (sing != token.sign)
            {
                Messages.ShowError("请输入正确的原密码，否则无法为您更换密码！");
                view.Password.EditValue = null;
                view.Password.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(newPw))
            {
                Messages.ShowWarning("新密码不能为空，请输入您的新密码并牢记！");
                view.NewPw.Focus();
                return false;
            }

            if (newPw == "123456")
            {
                Messages.ShowWarning("新密码不能设为初始密码，请输入其它密码并牢记！");
                view.NewPw.EditValue = null;
                view.ConfirmPw.EditValue = null;
                view.NewPw.Focus();
                return false;
            }

            if (newPw != confirmPw)
            {
                Messages.ShowWarning("两次密码输入不一致！\r\n请重新确认密码，只有两次输入的密码一致，才能为您更换密码。");
                view.ConfirmPw.EditValue = null;
                view.ConfirmPw.Focus();
                return false;
            }

            const string msg = "更换密码失败！请检查网络状况，并再次进行更换密码操作。";
            var url = $"{server}/userapi/v1.0/users/{Params.userId}/signature";
            var dict = new Dictionary<string, object> {{"password", Util.Hash(newPw)}};
            var client = new HttpClient<object>(token);
            if (!client.Put(url, dict, msg)) return false;

            token.Signature(newPw);
            Messages.ShowMessage("更换密码成功！请牢记新密码并使用新密码登录系统。");
            return true;
        }
    }
}