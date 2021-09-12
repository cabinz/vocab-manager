using System;
using System.Windows.Forms;

namespace ManagerUI
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

            // Initialize services.
            ManagerLibrary.GlobalConfig.InitConnection();

            // Application.Run(new EditorForm());
            Application.Run(new HomeForm());
        }
    }
}
