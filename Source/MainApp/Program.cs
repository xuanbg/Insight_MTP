using Insight.Base.MainForm;
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
        // ReSharper disable once InconsistentNaming
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new Controller();
            if (controller.exit) return;

            Application.Run();
        }
    }
}
