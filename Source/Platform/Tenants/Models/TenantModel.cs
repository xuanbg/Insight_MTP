using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Client;
using Insight.Utils.Common;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class TenantModel : BaseDialogModel<TenantDialog>
    {

        private readonly Tenant tenant;
        private List<LookUpMember> citys;

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">UserInfo</param>
        /// <param name="title">View标题</param>
        public TenantModel(Tenant data, string title)
        {
            tenant = data;
            var provinces = getRegions();
            view = new TenantDialog
            {
                Text = title,
                txtName = {EditValue = data.name},
                txtAlias = {EditValue = data.alias},
                txtContact = {EditValue = data.contact},
                txtMobile = { EditValue = data.mobile },
                txtEmail = { EditValue = data.email },
                txtAddress = { EditValue = data.address },
                picIcon = {EditValue = data.icon },
                memRemark = {EditValue = data.remark}
            };

            view.picIcon.Click += (sender, args) => view.picIcon.LoadImage();

            // 订阅控件事件实现数据双向绑定
            view.txtName.EditValueChanged += (sender, args) => tenant.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => tenant.alias = view.txtAlias.Text.Trim();
            view.txtContact.EditValueChanged += (sender, args) => tenant.contact = view.txtContact.Text.Trim();
            view.txtMobile.EditValueChanged += (sender, args) => tenant.mobile = view.txtMobile.Text.Trim();
            view.txtEmail.EditValueChanged += (sender, args) => tenant.email = view.txtEmail.Text.Trim();
            view.cbeProvince.SelectedIndexChanged += (sender, args) =>
            {
                tenant.province = view.cbeProvince.Text;
                var index = view.cbeProvince.SelectedIndex;
                if (index < 0) return;

                Format.initComboBoxEdit(view.cbeCounty, null);
                view.cbeCounty.EditValue = null;
                citys = getRegions(provinces[index].id);
                Format.initComboBoxEdit(view.cbeCity, citys);
                view.cbeCity.EditValue = null;
            };
            view.cbeCity.SelectedIndexChanged += (sender, args) =>
            {
                tenant.city = view.cbeCity.Text;
                var index = view.cbeCity.SelectedIndex;
                if (index < 0) return;

                var county = getRegions(citys[index].id);
                Format.initComboBoxEdit(view.cbeCounty, county);
            };
            view.cbeCounty.SelectedIndexChanged += (sender, args) => tenant.county = view.cbeCounty.Text;
            view.txtAddress.EditValueChanged += (sender, args) => tenant.address = view.txtAddress.Text.Trim();
            view.picIcon.ImageChanged += (sender, args) => tenant.icon = Util.resize(view.picIcon.Image, 64, 64);
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.EditValue?.ToString().Trim();
                tenant.remark = string.IsNullOrEmpty(text) ? null : text;
            };

            // 初始化地址列表
            Format.initComboBoxEdit(view.cbeProvince, provinces);

            view.cbeProvince.EditValue = data.province;
            view.cbeCity.EditValue = data.city;
            view.cbeCounty.EditValue = data.county;
        }

        /// <summary>
        /// 新增
        /// </summary>
        public Tenant add()
        {
            if (!inputExamine()) return null;

            var msg = $"新建租户【{tenant.name}】失败！";
            var url = $"/tenantapi/v1.0/tenants";
            var dict = new Dictionary<string, object> {{"tenant", tenant}};
            var client = new HttpClient<Tenant>();

            return client.post(url, dict, msg) ? client.data : null;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public Tenant edit()
        {
            if (!inputExamine()) return null;

            var msg = $"没有更新租户【{tenant.name}】的任何信息！";
            var url = $"/tenantapi/v1.0/tenants/{tenant.id}";
            var dict = new Dictionary<string, object> {{"tenant", tenant}};
            var client = new HttpClient<Tenant>();

            return client.put(url, dict, msg) ? tenant : null;
        }

        /// <summary>
        /// 根据上级ID获取地区
        /// </summary>
        /// <param name="id">上级地区ID</param>
        /// <returns>地区列表</returns>
        private List<LookUpMember> getRegions(string id = null)
        {
            var url = $"/commonapi/v1.0/regions?pid={id}";
            var client = new HttpClient<List<Region>>();
            client.get(url);

            var list = client.data.Select(i => new LookUpMember {id = i.id, name = i.name});
            return list.ToList();
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
