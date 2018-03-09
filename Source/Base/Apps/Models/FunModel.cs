using System.Collections.Generic;
using Insight.MTP.Client.Base.Apps.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Base.Apps.Models
{
    public class FunModel : BaseModel
    {
        public FunDialog view;

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
                txtAlias = {EditValue = data.alias},
                txtRoute = {EditValue = data.routes},
                txtUrl = {EditValue = data.url},
                picIcon = {EditValue = data.icon},
                memRemark = {EditValue = data.remark},
                chkGroup = {Checked = data.isBegin},
                chkShow = {Checked = data.isShowText}
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.speIndex.EditValueChanged += (sender, args) => fun.index = (int)view.speIndex.Value;
            view.txtName.EditValueChanged += (sender, args) => fun.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => fun.alias = view.txtAlias.Text.Trim();
            view.txtRoute.EditValueChanged += (sender, args) => fun.routes = view.txtRoute.Text.Trim();
            view.txtUrl.EditValueChanged += (sender, args) => fun.alias = view.txtUrl.Text.Trim();
            view.picIcon.ImageChanged += (sender, args) => fun.icon = Util.Resize(view.picIcon.Image, 16, 16);
            view.chkGroup.CheckedChanged += (sender, args) => fun.isBegin = view.chkGroup.Checked;
            view.chkShow.CheckedChanged += (sender, args) => fun.isShowText = view.chkShow.Checked;
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                fun.remark = string.IsNullOrEmpty(text) ? null : text;
            };
        }

        /// <summary>
        /// 新增
        /// </summary>
        public Function Add()
        {
            if (!InputExamine()) return null;

            var msg = $"新建应用【{fun.name}】失败！";
            var url = $"{server}/appapi/v1.0/apps/navigations/functions";
            var dict = new Dictionary<string, object> {{"fun", fun}};
            var client = new HttpClient<Function>(token);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public Function Edit()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新应用【{fun.name}】的任何信息！";
            var url = $"{server}/appapi/v1.0/apps/navigations/functions/{fun.id}";
            var dict = new Dictionary<string, object> {{"fun", fun}};
            var client = new HttpClient<Function>(token);
            return client.Put(url, dict, msg) ? fun : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool InputExamine()
        {
            if (string.IsNullOrEmpty(fun.name))
            {
                Messages.ShowWarning("必须输入应用名称！");
                view.txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(fun.alias))
            {
                Messages.ShowWarning("必须输入简称！");
                view.txtUrl.Focus();
                return false;
            }

            return true;
        }
    }
}
