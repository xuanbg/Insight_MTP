using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Base.BaseForm.ViewModels;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class TenantModel : BaseDialogModel<Tenant, TenantDialog>
    {
        private readonly DataModel dm;
        public readonly List<Region> regions = new List<Region>();

        /// <summary>
        /// 构造函数
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        /// <param name="dataModel"></param>
        public TenantModel(Tenant data, string title, DataModel dataModel) : base(title)
        {
            item = data;
            dm = dataModel;
            if (item.companyInfo == null) item.companyInfo = new CompanyInfo();

            view.txtName.EditValue = item.name;
            view.txtAlias.EditValue = item.alias;
            view.memRemark.EditValue = item.remark;
            view.txtCompany.EditValue = item.companyInfo.companyName;
            view.butLogo.EditValue = item.companyInfo.logo;
            view.txtHome.EditValue = item.companyInfo.homeSit;
            view.txtLicense.EditValue = item.companyInfo.license;
            view.butImage.EditValue = item.companyInfo.licenseImage;
            view.txtAddress.EditValue = item.companyInfo.address;
            view.txtContact.EditValue = item.companyInfo.contactName;
            view.txtMobile.EditValue = item.companyInfo.contactPhone;
            view.txtEmail.EditValue = item.companyInfo.contactMailbox;

            view.txtName.EditValueChanged += (sender, args) => item.name = view.txtName.Text.Trim();
            view.txtAlias.EditValueChanged += (sender, args) => item.alias = view.txtAlias.Text.Trim();
            view.memRemark.EditValueChanged += (sender, args) =>
            {
                var text = view.memRemark.Text.Trim();
                item.remark = string.IsNullOrEmpty(text) ? null : text;
            };
            view.txtCompany.EditValueChanged += (sender, args) => item.companyInfo.companyName = view.txtCompany.Text.Trim();
            view.butLogo.EditValueChanged += (sender, args) =>
            {
                item.companyInfo.companyName = view.txtCompany.Text.Trim();
            };
            view.txtHome.EditValueChanged += (sender, args) => item.companyInfo.homeSit = view.txtHome.Text.Trim();
            view.txtLicense.EditValueChanged += (sender, args) => item.companyInfo.license = view.txtLicense.Text.Trim();
            view.butImage.EditValueChanged += (sender, args) =>
            {
                item.companyInfo.licenseImage = view.butImage.Text.Trim();
            };
            view.lueProvince.EditValueChanged += (sender, args) =>
            {
                item.companyInfo.provinceId = view.lueProvince.EditValue.ToString();
                item.companyInfo.province = view.lueProvince.Text.Trim();
                initCity(item.companyInfo.provinceId);
            };
            view.lueCity.EditValueChanged += (sender, args) =>
            {
                item.companyInfo.cityId = view.lueCity.EditValue.ToString();
                item.companyInfo.city = view.lueCity.Text.Trim();
                initCounty(item.companyInfo.cityId);
            };
            view.lueCounty.EditValueChanged += (sender, args) =>
            {
                item.companyInfo.countyId = view.lueCounty.EditValue.ToString();
                item.companyInfo.county = view.lueCounty.Text.Trim();
            };
            view.txtAddress.EditValueChanged += (sender, args) => item.companyInfo.address = view.txtAddress.Text.Trim();
            view.txtContact.EditValueChanged += (sender, args) => item.companyInfo.contactName = view.txtContact.Text.Trim();
            view.txtMobile.EditValueChanged += (sender, args) => item.companyInfo.contactPhone = view.txtMobile.Text.Trim();
            view.txtEmail.EditValueChanged += (sender, args) => item.companyInfo.contactMailbox = view.txtEmail.Text.Trim();

            Format.initLookUpEdit(view.lueProvince, dm.getProvinces());
            view.lueProvince.EditValue = item.companyInfo.provinceId;
            view.lueCity.EditValue = item.companyInfo.cityId;
            view.lueCounty.EditValue = item.companyInfo.countyId;
        }

        /// <summary>
        /// 初始化城市下拉控件
        /// </summary>
        /// <param name="id"></param>
        private void initCity(string id)
        {
            view.lueCounty.Properties.DataSource = null;
            var list = regions.Where(i => i.parentId == id).Select(i => new LookUpMember {id = i.id, name = i.name}).ToList();
            if (list.Any())
            {
                Format.initLookUpEdit(view.lueCity, list);
            }
            else
            {
                regions.AddRange(dm.getRegions(id));
                initCity(id);
            }
        }

        /// <summary>
        /// 初始化城市下拉控件
        /// </summary>
        /// <param name="id"></param>
        private void initCounty(string id)
        {
            var list = regions.Where(i => i.parentId == id).Select(i => new LookUpMember {id = i.id, name = i.name}).ToList();
            if (list.Any())
            {
                Format.initLookUpEdit(view.lueCounty, list);
            }
            else
            {
                regions.AddRange(dm.getRegions(id));
                initCounty(id);
            }
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            if (string.IsNullOrEmpty(item.name))
            {
                Messages.showWarning("必须输入租户名称！");
                view.txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(item.alias))
            {
                Messages.showWarning("必须输入租户简称！");
                view.txtAlias.Focus();
                return;
            }

            base.confirm();
        }
    }
}
