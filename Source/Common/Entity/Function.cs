using Insight.Base.BaseForm.Entities;

namespace Insight.MTP.Client.Common.Entity
{
    public class Function
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 导航ID
        /// </summary>
        public string navId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 接口授权码
        /// </summary>
        public string authCodes { get; set; }

        /// <summary>
        /// 图标信息
        /// </summary>
        public FuncInfo funcInfo { get; set; } = new FuncInfo();
    }
}
