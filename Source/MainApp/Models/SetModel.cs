using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainApp.Views;

namespace Insight.MTP.Client.MainApp.Models
{
    public class SetModel : BaseModel
    {
        public LoginSet view;

        private bool saveUser = Config.IsSaveUserInfo();

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public SetModel()
        {
            view = new LoginSet
            {
                BaseInupt = {Text = server },
                SaveUserCheckBox = {Checked = saveUser}
            };

            view.BaseInupt.EditValueChanged += (sender, args) => server = view.BaseInupt.Text;
            view.SaveUserCheckBox.CheckStateChanged += (sender, args) => saveUser = view.SaveUserCheckBox.Checked;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        public void Save()
        {
            if (!saveUser) Config.SaveUserName(string.Empty);

            Config.SaveIsSaveUserInfo(saveUser);
            Config.SaveBaseAddress(server);
        }
    }
}