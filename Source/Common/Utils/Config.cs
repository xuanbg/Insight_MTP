using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Utils
{
    public class Config
    {

        #region 读取配置项

        /// <summary>
        /// 获取保存的默认样式主题
        /// </summary>
        /// <returns></returns>
        public static string LookAndFeel()
        {
            return Util.GetAppSetting("DefaultLookAndFeel");
        }

        /// <summary>
        /// 获取保存的默认打印机
        /// </summary>
        /// <param name="print"></param>
        /// <returns></returns>
        public static string Printer(string print)
        {
            return Util.GetAppSetting(print);
        }

        /// <summary>
        /// 获取合并打印选项
        /// </summary>
        /// <returns></returns>
        public static bool IsMergerPrint()
        {
            return bool.Parse(Util.GetAppSetting("IsMergerPrint"));
        }

        /// <summary>
        /// 获取是否保存用户名选项设置
        /// </summary>
        /// <returns></returns>
        public static bool IsSaveUserInfo()
        {
            return bool.Parse(Util.GetAppSetting("IsSaveUserInfo"));
        }

        /// <summary>
        /// 获取保存的用户名
        /// </summary>
        /// <returns></returns>
        public static string UserName()
        {
            return Util.GetAppSetting("UserName");
        }

        /// <summary>
        /// 获取应用服务地址
        /// </summary>
        /// <returns></returns>
        public static string Address()
        {
            return Util.GetAppSetting("Address");
        }

        /// <summary>
        /// 获取验证服务地址
        /// </summary>
        /// <returns></returns>
        public static string BaseAddress()
        {
            return Util.GetAppSetting("BaseServer");
        }

        #endregion

        #region 保存配置项

        /// <summary>
        /// 保存默认样式
        /// </summary>
        /// <param name="defaultLookAndFeel"></param>
        public static void SaveLookAndFeel(string defaultLookAndFeel)
        {
            Util.SaveAppSetting("DefaultLookAndFeel", defaultLookAndFeel);
        }

        /// <summary>
        /// 保存默认打印机
        /// </summary>
        /// <param name="print"></param>
        /// <param name="printName"></param>
        public static void SavePrinter(string print, string printName)
        {
            Util.SaveAppSetting(print, printName);
        }

        /// <summary>
        /// 保存用户信息保存选项
        /// </summary>
        /// <param name="isMerger"></param>
        public static void SaveIsMergerPrint(bool isMerger)
        {
            Util.SaveAppSetting("IsMergerPrint", isMerger.ToString());
        }

        /// <summary>
        /// 保存用户信息保存选项
        /// </summary>
        /// <param name="isSave"></param>
        public static void SaveIsSaveUserInfo(bool isSave)
        {
            Util.SaveAppSetting("IsSaveUserInfo", isSave.ToString());
        }

        /// <summary>
        /// 保存用户名
        /// </summary>
        /// <param name="userName"></param>
        public static void SaveUserName(string userName)
        {
            Util.SaveAppSetting("UserName", userName);
        }

        /// <summary>
        /// 保存应用服务地址和端口
        /// </summary>
        /// <param name="address"></param>
        public static void SaveAddress(string address)
        {
            Util.SaveAppSetting("Address", address);
        }

        /// <summary>
        /// 保存验证服务地址和端口
        /// </summary>
        /// <param name="address"></param>
        public static void SaveBaseAddress(string address)
        {
            Util.SaveAppSetting("BaseServer", address);
        }

        #endregion
    }
}
