using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DataTerminalProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        const string pathToExec = @"C:\Windows\explorer.exe";

        private void StartAppBtn_Click(object sender, EventArgs e)
        {
            Process.Start(pathToExec);
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }
        private void ShutDownBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

    }
}
