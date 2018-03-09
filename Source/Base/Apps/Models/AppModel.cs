using System;
using System.Collections.Generic;
using Insight.MTP.Client.Base.Apps.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Apps.Models
{
    public class AppModel : BaseModel
    {
        public AppDialog view;

        private readonly App app;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public AppModel(App data, string title)
        {
            app = data;
            view = new AppDialog
            {
                Text = title,
                txtName = {EditValue = data.name},
                txtAlias = {EditValue = data.alias},
                txtlife = {EditValue = data.tokenLife},
                txtHost = {EditValue = data.host},
                picIcon = {EditValue = data.icon },
                memRemark = {EditValue = data.remark}
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => app.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => app.alias = view.txtAlias.Text.Trim();
            view.txtHost.EditValueChanged += (sender, args) => app.host = view.txtHost.Text.Trim();
            view.txtlife.EditValueChanged += (sender, args) => app.tokenLife = Convert.ToInt32(view.txtlife.Text.Trim());
            view.picIcon.ImageChanged += (sender, args) => app.icon = Util.Resize(view.picIcon.Image, 256, 256);
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                app.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 新增
        /// </summary>
        public App Add()
        {
            if (!InputExamine()) return null;

            var msg = $"新建应用【{app.name}】失败！";
            var url = $"{server}/appapi/v1.0/apps";
            var dict = new Dictionary<string, object> {{"app", app}};
            var client = new HttpClient<App>(token);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public App Edit()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新应用【{app.name}】的任何信息！";
            var url = $"{server}/appapi/v1.0/apps/{app.id}";
            var dict = new Dictionary<string, object> {{"app", app}};
            var client = new HttpClient<App>(token);
            return client.Put(url, dict, msg) ? app : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool InputExamine()
        {
            if (string.IsNullOrEmpty(app.name))
            {
                Messages.ShowWarning("必须输入应用名称！");
                view.txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(app.alias))
            {
                Messages.ShowWarning("必须输入简称！");
                view.txtAlias.Focus();
                return false;
            }

            return true;
        }
    }
}
