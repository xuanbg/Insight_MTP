using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class LockModel
    {
        public Locked View = new Locked();

        private string _Sing;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public LockModel()
        {
            var sign = Util.Hash(Params.Token.Token.userId + Util.Hash(View.Password.Text));
            View.Password.EditValueChanged += (sender, args) => _Sing = sign;
        }

        /// <summary>
        /// 初始化对话框
        /// </summary>
        public void Init()
        {
            View.Password.EditValue = null;
            View.Refresh();
        }

        /// <summary>
        /// 解锁
        /// </summary>
        /// <returns>bool 是否解锁成功</returns>
        public bool Unlock()
        {
            if (_Sing == Params.Token.Sign) return true;

            Messages.ShowError("请输入正确的密码，否则无法为您解除锁定！");
            View.Password.Text = string.Empty;
            View.Password.Focus();
            return false;
        }
    }
}