namespace Insight.MTP.Client.Common.Entity
{
    public class CompanyInfo
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// 企业LOGO
        /// </summary>
        public string logo { get; set; }

        /// <summary>
        /// 企业官网
        /// </summary>
        public string homeSit { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string license { get; set; }

        /// <summary>
        /// 营业执照照片URL
        /// </summary>
        public string licenseImage { get; set; }

        /// <summary>
        /// 公司所在省/直辖市ID
        /// </summary>
        public string provinceId { get; set; }

        /// <summary>
        /// 所在省/直辖市
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 公司所在市ID
        /// </summary>
        public string cityId { get; set; }

        /// <summary>
        /// 所在市/地区
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 公司所在区县ID
        /// </summary>
        public string countyId { get; set; }

        /// <summary>
        /// 所在区/县
        /// </summary>
        public string county { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string contactName { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        public string contactPhone { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string contactMailbox { get; set; }
    }
}
