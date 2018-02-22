using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainApp.Views;

namespace Insight.MTP.Client.MainApp.Models
{
    public class SetModel
    {
        public LoginSet View;

        private bool _SaveUser = Config.IsSaveUserInfo();

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public SetModel()
        {
            View = new LoginSet
            {
                BaseInupt = {Text = Params.tokenHelper.baseServer },
                SaveUserCheckBox = {Checked = _SaveUser}
            };

            View.BaseInupt.EditValueChanged += (sender, args) => Params.tokenHelper.baseServer = View.BaseInupt.Text;
            View.SaveUserCheckBox.CheckStateChanged += (sender, args) => _SaveUser = View.SaveUserCheckBox.Checked;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        public void Save()
        {
            if (!_SaveUser) Config.SaveUserName(string.Empty);

            Config.SaveIsSaveUserInfo(_SaveUser);
            Config.SaveBaseAddress(Params.tokenHelper.baseServer);
        }
    }
}