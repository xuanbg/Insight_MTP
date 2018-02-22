using System.Collections.Generic;
using Insight.WS.Client.Common.Entity;

namespace Insight.WS.Client.Common.Utils
{
    public static class Parameters
    {
        // 当前登录用户名称
        public static string UserName;

        // 当前登录部门全称
        public static string DeptName;

        // 是否需要修改密码
        public static bool NeedChangePW;

        // 当前连接业务应用服务器
        public static string InsightServer;

        // 当前连接业务应用服务接口版本
        public static int InsightVer;

        // 服务器上的客户端文件列表
        public static List<UpdateFile> ServerFiles;
    }
}
