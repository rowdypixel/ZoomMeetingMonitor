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
                blink.Set(Color.White);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tmrCheckForChanges.Start();
        }

        private void tmrCheckForChanges_Tick(object sender, EventArgs e)
        {
            if(!bgwCheckForZoom.IsBusy)
                bgwCheckForZoom.RunWorkerAsync();
        }
    }
}
