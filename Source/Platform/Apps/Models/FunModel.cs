using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Apps.Models
{
    public class FunModel : BaseDialogModel<FunDialog>
    {

        private readonly Function fun;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public FunModel(Function data, string title)
        {
            fun = data;
            view = new FunDialog
            {
                Text = title,
                speIndex = {EditValue = data.index},
                txtName = {EditValue = data.name},
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.speIndex.EditValueChanged += (sender, args) => fun.index = (int)view.speIndex.Value;
            view.txtName.EditValueChanged += (sender, args) => fun.name = view.txtName.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
            };
        }

        /// <summary>
        /// 新增
        /// </summary>
        public Function add()
        {
            if (!inputExamine()) return null;

            var msg = $"新建应用【{fun.name}】失败！";
            var url = $"/appapi/v1.0/apps/navigations/functions";
            var dict = new Dictionary<string, object> {{"fun", fun}};
            var client = new HttpClient<Function>();
            return client.post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public Function edit()
        {
            if (!inputExamine()) return null;

            var msg = $"没有更新应用【{fun.name}】的任何信息！";
            var url = $"/appapi/v1.0/apps/navigations/functions/{fun.id}";
            var dict = new Dictionary<string, object> {{"fun", fun}};
            var client = new HttpClient<Function>();
            return client.put(url, dict, msg) ? fun : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool inputExamine()
        {
            if (string.IsNullOrEmpty(fun.name))
            {
                Messages.showWarning("必须输入应用名称！");
                view.txtName.Focus();
                return false;
            }

            return true;
        }
    }
}
