using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Utils
{
    public static class Params
    {
        /// <summary>
        /// AccessToken管理帮助类
        /// </summary>
        public static TokenHelper Token = new TokenHelper();

        /// <summary>
        /// 当前登录部门全称
        /// </summary>
        public static string DeptName;

        /// <summary>
        /// 是否需要修改密码
        /// </summary>
        public static bool NeedChangePW;

        /// <summary>
        /// 当前连接业务应用服务
        /// </summary>
        public static string InsightServer;

        /// <summary>
        /// 当前连接报表应用服务
        /// </summary>
        public static string ReportServer = Util.GetAppSetting("ReportServer");

        /// <summary>
        /// 当前连接售后应用服务
        /// </summary>
        public static string RefundServer = Util.GetAppSetting("RefundServer");

        /// <summary>
        /// 当前连接订单应用服务
        /// </summary>
        public static string PurchaseServer = Util.GetAppSetting("PurchaseServer");

        /// <summary>
        /// 当前连接主数据应用服务
        /// </summary>
        public static string MasterDataServer = Util.GetAppSetting("MasterDataServer");

        /// <summary>
        /// 当前连接业务应用服务接口版本
        /// </summary>
        public static int InsightVer;

        /// <summary>
        /// 界面主题样式
        /// </summary>
        public static string LookAndFeel;

        /// <summary>
        /// 文档打印机
        /// </summary>
        public static string DocPrint;

        /// <summary>
        /// 标签打印机
        /// </summary>
        public static string TagPrint;

        /// <summary>
        /// 票据打印机
        /// </summary>
        public static string BilPrint;

        /// <summary>
        /// 票据是否合并打印
        /// </summary>
        public static bool IsMergerPrint;
    }
}
