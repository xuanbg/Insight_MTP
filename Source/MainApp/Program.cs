using System;
using System.Windows.Forms;
using Insight.Utils.MainForm.Login;

namespace Insight.MTP.Client.MainApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        // ReSharper disable once InconsistentNaming
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
