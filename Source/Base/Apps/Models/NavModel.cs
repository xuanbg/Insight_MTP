using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Base.Apps.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Models;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Base.Apps.Models
{
    public class NavModel : BaseModel
    {
        public NavDialog view;

        private List<TreeLookUpMember> navList;
        private readonly Navigation nav;
        private int size = 32;

        /// <summary>
        /// 导航集合
        /// </summary>
        public List<TreeLookUpMember> navs
        {
            private get { return navList; }
            set
            {
                navList = value;
                Format.InitTreeListLookUpEdit(view.lueParent, navList);
            }
        }

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public NavModel(Navigation data, string title)
        {
            nav = data;
            view = new NavDialog
            {
                Text = title,
                lueParent = {EditValue = data.parentId},
                speIndex = {EditValue = data.index},
                cheLoad = {Checked = data.isDefault},
                txtName = {EditValue = data.name},
                txtAlias = {EditValue = data.alias},
                txtUrl = {EditValue = data.url},
                picIcon = {EditValue = data.icon },
                memRemark = {EditValue = data.remark}
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.lueParent.EditValueChanged += (sender, args) =>
            {
                var pid = view.lueParent.EditValue.ToString();
                size = string.IsNullOrEmpty(pid) ? 32 : 24;
                nav.parentId = pid;
                view.speIndex.Value = navs.Count(i => i.parentId == pid) + 1;
            };
            view.speIndex.EditValueChanged += (sender, args) => nav.index = (int) view.speIndex.Value;
            view.cheLoad.CheckedChanged += (sender, args) => nav.isDefault = view.cheLoad.Checked;
            view.txtName.EditValueChanged += (sender, args) => nav.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => nav.alias = view.txtAlias.Text.Trim();
            view.txtUrl.EditValueChanged += (sender, args) => nav.url = view.txtUrl.Text.Trim();
            view.picIcon.ImageChanged += (sender, args) => nav.icon = Util.Resize(view.picIcon.Image, size, size);
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                nav.remark = string.IsNullOrEmpty(text) ? null : text;
            };

        }

        /// <summary>
        /// 新增
        /// </summary>
        public Navigation Add()
        {
            if (!InputExamine()) return null;

            var msg = $"新建应用【{nav.name}】失败！";
            var url = $"{server}/appapi/v1.0/apps/navigations";
            var dict = new Dictionary<string, object> {{"nav", nav}};
            var client = new HttpClient<Navigation>(token);
            return client.Post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public Navigation Edit()
        {
            if (!InputExamine()) return null;

            var msg = $"没有更新应用【{nav.name}】的任何信息！";
            var url = $"{server}/appapi/v1.0/apps/navigations/{nav.id}";
            var dict = new Dictionary<string, object> {{"nav", nav}};
            var client = new HttpClient<Navigation>(token);
            return client.Put(url, dict, msg) ? nav : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool InputExamine()
        {
            if (string.IsNullOrEmpty(nav.name))
            {
                Messages.ShowWarning("必须输入导航名称！");
                view.txtName.Focus();
                return false;
            }

            return true;
        }
    }
}
