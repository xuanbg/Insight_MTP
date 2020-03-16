using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Scenes.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Setting.Scenes.ViewModels
{
    public class SceneModel : BaseDialogModel<Scene, SceneDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public SceneModel(Scene data, string title) : base(title)
        {
            item = data;

            view.txtName.EditValue = item.name;
            view.memRemark.EditValue = item.remark;

            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }
        
        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入场景名称！");
                view.txtName.Focus();
                return;
            }
            
            base.confirm();
        }
    }
}
