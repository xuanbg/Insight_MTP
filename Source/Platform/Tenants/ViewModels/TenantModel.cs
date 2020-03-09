using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class TenantModel : BaseDialogModel<Tenant, TenantDialog>
    {

        private readonly Tenant tenant;
        private List<LookUpMember> citys;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public TenantModel(Tenant data, string title) : base(title)
        {
            tenant = data;
            view.txtName.EditValue = data.name;
            view.txtAlias.EditValue = data.alias;
            view.memRemark.EditValue = data.remark;

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => tenant.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => tenant.alias = view.txtAlias.Text.Trim();
            view.cbeProvince.SelectedIndexChanged += (sender, args) =>
            {
                var index = view.cbeProvince.SelectedIndex;
                if (index < 0) return;

                Format.initComboBoxEdit(view.cbeCounty, null);
                view.cbeCounty.EditValue = null;
                Format.initComboBoxEdit(view.cbeCity, citys);
                view.cbeCity.EditValue = null;
            };
            view.cbeCity.SelectedIndexChanged += (sender, args) =>
            {
                var index = view.cbeCity.SelectedIndex;
                if (index < 0) return;

            };
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                tenant.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            // 初始化地址列表

        }
        
        /// <summary>
        /// 输入合法性检查
        /// </summary>
        /// <returns>bool 是否通过</returns>
        private new bool inputExamine()
        {
            if (string.IsNullOrEmpty(tenant.name))
            {
                Messages.showWarning("必须输入应用名称！");
                view.txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tenant.alias))
            {
                Messages.showWarning("必须输入简称！");
                view.txtAlias.Focus();
                return false;
            }

            return true;
        }
    }
}
