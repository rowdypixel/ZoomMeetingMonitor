using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sleddog.Blink1;

namespace ZoomMeetingMonitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bgwCheckForZoom_DoWork(object sender, DoWorkEventArgs e)
        {

            var connected = Blink1Connector.Scan();
            var blink = connected.ToArray()[0] as Blink1;

            var foundZoom = false;

            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    if (process.MainWindowTitle.StartsWith("Zoom Meeting"))
                    {
                        foundZoom = true;
                    }
                }
            }
            if (foundZoom)
                blink.Set(Color.Red);
            else
                blink.TurnOff();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tmrCheckForChanges.Start();
            this.WindowState = FormWindowState.Minimized;
            icoTray.ShowBalloonTip(3000, "Online Meeting Monitor", "Monitoring your computer for Zoom Meetings.", ToolTipIcon.Info);
        }

        private void tmrCheckForChanges_Tick(object sender, EventArgs e)
        {
            if(!bgwCheckForZoom.IsBusy)
                bgwCheckForZoom.RunWorkerAsync();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                icoTray.Visible = true;
            }
        }

        private void icoTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                Show();
                this.WindowState = FormWindowState.Normal;
                icoTray.Visible = false;
        }

        private void btnToggleLight_Click(object sender, EventArgs e)
        {
            string turnOnText = "Set in Meeting";
            var connected = Blink1Connector.Scan();
            var blink = connected.ToArray()[0] as Blink1;
            if (btnToggleLight.Text == turnOnText)
            {
                tmrCheckForChanges.Stop();
                while(bgwCheckForZoom.IsBusy)
                {
                    Application.DoEvents();
                }
                blink.Set(Color.Red);
                btnToggleLight.Text = "End Meeting";
            }
            else
            {
                tmrCheckForChanges.Start();
                blink.TurnOff();
                btnToggleLight.Text = turnOnText;
            }
            

        }
    }
}
