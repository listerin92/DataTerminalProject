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



        const string pathToExec = @"C:\Program Files\Heidelberg\Data Terminal\app\HDDataTerminal.exe";

        private void StartAppBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(pathToExec);

            }
            catch (Exception exception)
            {
                errMessageLabel.Show();
                errMessageLabel.Text = exception.Message;

                var timer1 = new Timer { Interval = 3000, Enabled = true };
                timer1.Tick += new EventHandler(OnTimerEvent);

                void OnTimerEvent(object sender1, EventArgs e1)
                {
                    errMessageLabel.Hide();
                }
            }
        }


        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }
        private void ShutDownBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
