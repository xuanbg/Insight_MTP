using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Apps.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Apps.Models
{
    public class NavModel : BaseDialogModel<NavDialog>
    {

        private List<TreeLookUpMember> navList;
        private Navigation nav;

        /// <summary>
        /// 导航集合
        /// </summary>
        public List<TreeLookUpMember> navs
        {
            private get { return navList; }
            set
            {
                navList = value;
                Format.initTreeListLookUpEdit(view.lueParent, navList);
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
                txtName = {EditValue = data.name},
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.lueParent.EditValueChanged += (sender, args) =>
            {
                var pid = view.lueParent.EditValue.ToString();
                nav.parentId = pid;
                view.speIndex.Value = navs.Count(i => i.parentId == pid) + 1;
            };
            view.speIndex.EditValueChanged += (sender, args) => nav.index = (int) view.speIndex.Value;
            view.txtName.EditValueChanged += (sender, args) => nav.name = view.txtName.Text.Trim();
            view.picIcon.ImageChanged += (sender, args) =>
            {
                var size = string.IsNullOrEmpty(nav.parentId) ? 32 : 24;
            };
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
            };

        }

        /// <summary>
        /// 新增
        /// </summary>
        public Navigation add()
        {
            if (!inputExamine()) return null;

            var msg = $"新建应用【{nav.name}】失败！";
            var url = $"/appapi/v1.0/apps/navigations";
            var dict = new Dictionary<string, object> {{"nav", nav}};
            var client = new HttpClient<Navigation>();
            return client.post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public Navigation edit()
        {
            if (!inputExamine()) return null;

            var msg = $"没有更新应用【{nav.name}】的任何信息！";
            var url = $"/appapi/v1.0/apps/navigations/{nav.id}";
            var dict = new Dictionary<string, object> {{"nav", nav}};
            var client = new HttpClient<Navigation>();
            return client.put(url, dict, msg) ? nav : null;
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool inputExamine()
        {
            if (string.IsNullOrEmpty(nav.name))
            {
                Messages.showWarning("必须输入导航名称！");
                view.txtName.Focus();
                return false;
            }

            return true;
        }
    }
}
