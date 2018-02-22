using Insight.Utils.Client;

namespace Insight.MTP.Client.Common.Utils
{
    public static class Params
    {
        /// <summary>
        /// AccessToken管理帮助类
        /// </summary>
        public static TokenHelper tokenHelper { get; set; } = new TokenHelper{appId = "9dd99dd9-e6df-467a-8207-d05ea5581125"};

        /// <summary>
        /// 当前登录部门ID
        /// </summary>
        public static string deptId { get; set; }

        /// <summary>
        /// 当前登录部门全称
        /// </summary>
        public static string deptName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public static string userId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public static string userName { get; set; }

        /// <summary>
        /// 是否需要修改密码
        /// </summary>
        public static bool needChangePw { get; set; }

        /// <summary>
        /// 界面主题样式
        /// </summary>
        public static string lookAndFeel { get; set; }

        /// <summary>
        /// 文档打印机
        /// </summary>
        public static string docPrint { get; set; }

        /// <summary>
        /// 标签打印机
        /// </summary>
        public static string tagPrint { get; set; }

        /// <summary>
        /// 票据打印机
        /// </summary>
        public static string bilPrint { get; set; }

        /// <summary>
        /// 票据是否合并打印
        /// </summary>
        public static bool isMergerPrint { get; set; }
    }
}
