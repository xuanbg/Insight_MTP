using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Scenes.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Scenes.ViewModels
{
    public class ConfigModel : BaseDialogModel<TempConfig, ConfigDialog>
    {
        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data"></param>
        /// <param name="temps">可选模板集合</param>
        /// <param name="apps">可选应用集合</param>
        /// <param name="title">View标题</param>
        public ConfigModel(TempConfig data, List<MessageTemp> temps, List<LookUpMember> apps, string title) : base(title)
        {
            item = data;

            var list = temps.Select(i => new LookUpMember {id = i.id, name = i.title}).ToList();
            Format.initLookUpEdit(view.lueTemplate, list);
            Format.initLookUpEdit(view.lueApp, apps);

            view.lueTemplate.EditValueChanged += (sender, args) =>
            {
                item.templateId = view.lueTemplate.EditValue.ToString();
                item.template = view.lueTemplate.Text;
            };
            view.lueApp.EditValueChanged += (sender, args) =>
            {
                item.appId = view.lueApp.EditValue.ToString();
                item.appName = view.lueApp.Text;
            };
            view.txtSign.EditValueChanged += (sender, args) => item.sign = view.txtSign.Text.Trim();
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.templateId))
            {
                Messages.showWarning("必须选择一个模板！");
                view.lueTemplate.Focus();
                return;
            }

            base.confirm();
        }
    }
}
