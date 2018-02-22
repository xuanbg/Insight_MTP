using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;
using Insight.Utils.Common;

namespace Insight.MTP.Client.MainForm.Models
{
    public class LockModel
    {
        public Locked view = new Locked();

        private string sing;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public LockModel()
        {
            var sign = Util.Hash(Params.userId + Util.Hash(view.Password.Text));
            view.Password.EditValueChanged += (sender, args) => sing = sign;
        }

        /// <summary>
        /// 初始化对话框
        /// </summary>
        public void Init()
        {
            view.Password.EditValue = null;
            view.Refresh();
        }

        /// <summary>
        /// 解锁
        /// </summary>
        /// <returns>bool 是否解锁成功</returns>
        public bool Unlock()
        {
            if (sing == Params.tokenHelper.sign) return true;

            Messages.ShowError("请输入正确的密码，否则无法为您解除锁定！");
            view.Password.Text = string.Empty;
            view.Password.Focus();
            return false;
        }
    }
}