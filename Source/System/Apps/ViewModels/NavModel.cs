using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Apps.ViewModels
{
    public class NavModel : BaseDialogModel<Navigation, NavDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public NavModel(Navigation data, string title) : base(title)
        {
            item = data;

            var isGroup = item.type == 1;
            view.chkGroup.Checked = isGroup;
            view.txtModule.Enabled = !isGroup;
            view.txtFile.Enabled = !isGroup;
            view.cheLoad.Enabled = !isGroup;

            view.speIndex.EditValue = item.index;
            view.txtName.EditValue = item.name;
            view.txtModule.EditValue = item.moduleInfo.module;
            view.txtFile.EditValue = item.moduleInfo.file;
            view.txtIcon.EditValue = item.moduleInfo.iconUrl;
            view.cheLoad.Checked = item.moduleInfo.autoLoad ?? false;

            view.speIndex.EditValueChanged += (sender, args) => item.index = (int) view.speIndex.Value;
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtModule.EditValueChanged += (sender, args) => item.moduleInfo.module = view.txtModule.Text.Trim();
            view.txtFile.EditValueChanged += (sender, args) => item.moduleInfo.file = view.txtFile.Text.Trim();
            view.txtIcon.EditValueChanged += (sender, args) => item.moduleInfo.iconUrl = view.txtIcon.Text.Trim();
            view.cheLoad.CheckedChanged += (sender, args) => item.moduleInfo.autoLoad = view.cheLoad.Checked;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入导航名称！");
                view.txtName.Focus();
                return;
            }

            base.confirm();
        }
    }
}
