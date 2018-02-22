using System;
using System.Windows.Forms;

namespace Insight.MTP.Client.MainApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ReSharper disable once UnusedVariable
            var controller = new Controller();
            Application.Run();
        }
    }
}
