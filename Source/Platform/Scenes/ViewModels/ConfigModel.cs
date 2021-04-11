using System.Linq;
using Insight.Base.BaseForm.Utils;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Scenes.Views;

namespace Insight.MTP.Client.Platform.Scenes.ViewModels
{
    public class ConfigModel : BaseDialogModel<SceneConfig, ConfigDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="title">View标题</param>
        /// <param name="data">数据</param>
        /// <param name="dataModel">DAL</param>
        public ConfigModel(string title, SceneConfig data, DataModel dataModel) : base(title, data)
        {
            var apps = dataModel.getApps();
            Format.initLookUpEdit(view.lueApp, apps);

            view.lueApp.EditValueChanged += (sender, args) =>
            {
                item.appId = view.lueApp.EditValue as string;
                item.appName = apps.SingleOrDefault(i => i.id == item.appId)?.name;
            };
            view.memContent.EditValueChanged += (sender, args) =>
            {
                var text = view.memContent.Text.Trim();
                item.content = string.IsNullOrEmpty(text) ? null : text;
            };
            view.txtSign.EditValueChanged += (sender, args) => item.sign = view.txtSign.Text.Trim();
            view.speExpire.EditValueChanged += (sender, args) => item.expire = (int) view.speExpire.Value;
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            view.lueApp.EditValue = item.appId;
            view.memContent.EditValue = item.content;
            view.txtSign.EditValue = item.sign;
            view.speExpire.EditValue = item.expire;
            view.memRemark.EditValue = item.remark;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.content))
            {
                Messages.showWarning("必须输入消息内容！");
                view.memContent.Select();
                return;
            }

            base.confirm();
        }
    }
}
