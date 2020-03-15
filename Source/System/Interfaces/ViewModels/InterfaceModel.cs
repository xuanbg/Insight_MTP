using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Interfaces.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Setting.Interfaces.ViewModels
{
    public class InterfaceModel : BaseDialogModel<Interface, InterfaceDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public InterfaceModel(Interface data, string title) : base(title)
        {
            item = data;

            view.txtName.EditValue = item.name;
          

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入应用名称！");
                view.txtName.Focus();
                return;
            }

            base.confirm();
        }
    }
}
