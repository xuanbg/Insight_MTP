using System.Collections.Generic;
using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Scenes.Views;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Platform.Scenes.ViewModels
{
    public class SceneModel : BaseDialogModel<Scene, SceneDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public SceneModel(Scene data, string title) : base(title, data)
        {
            view.txtCode.EditValueChanged += (sender, args) => item.code = view.txtCode.Text.Trim();
            view.cbeType.SelectedIndexChanged += (sender, args) => item.type = view.cbeType.SelectedIndex;
            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtTitle.EditValueChanged += (sender, args) => item.title = view.txtTitle.Text.Trim();
            view.txtTag.EditValueChanged += (sender, args) => item.tag = view.txtTag.Text.Trim();
            view.txtParam.EditValueChanged += (sender, args) =>
            {
                var text = view.txtParam.Text.Trim();
                item.param = string.IsNullOrEmpty(text) ? null : Util.deserialize<List<string>>(text);
            };
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            view.txtCode.EditValue = item.code;
            view.cbeType.SelectedIndex = item.type;
            view.txtName.EditValue = item.name;
            view.txtTitle.EditValue = item.title;
            view.txtTag.EditValue = item.tag;
            view.txtParam.EditValue = item.paramVal;
            view.memRemark.EditValue = item.remark;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.code))
            {
                Messages.showWarning("必须输入场景编码！");
                view.txtCode.Select();
                return;
            }

            if (item.type <= 0)
            {
                Messages.showWarning("必须选择消息发送类型！");
                view.cbeType.Select();
                return;
            }

            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入场景名称！");
                view.txtName.Select();
                return;
            }

            base.confirm();
        }
    }
}
