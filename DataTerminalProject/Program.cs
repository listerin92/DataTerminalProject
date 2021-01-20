using System;
using System.Windows.Forms;

namespace DataTerminalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());


            //if (Environment.OSVersion.Version.Major & gt;= 6)
            //    SetProcessDPIAware();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainWindow());

            //[System.Runtime.InteropServices.DllImport("user32.dll")]
            //private static extern bool SetProcessDPIAware();
        }
    }
}
