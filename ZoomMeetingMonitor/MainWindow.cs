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
using ZoomMeetingMonitor.Properties;
using ZoomMeetingMonitor.Notifications;

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
            {
                SendNotifications();
            }
            else
            {
                StopNotifications();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tmrCheckForChanges.Start();
            this.WindowState = FormWindowState.Minimized;
            icoTray.ShowBalloonTip(3000, "Online Meeting Monitor", "Monitoring your computer for Zoom Meetings.", ToolTipIcon.Info);
            pnlColor.BackColor = Settings.Default.LightColor;
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
            if (btnToggleLight.Text == turnOnText)
            {
                tmrCheckForChanges.Stop();
                while(bgwCheckForZoom.IsBusy)
                {
                    Application.DoEvents();
                }
                SendNotifications();
                btnToggleLight.Text = "End Meeting";
            }
            else
            {
                tmrCheckForChanges.Start();
                StopNotifications();
                btnToggleLight.Text = turnOnText;
            }
            

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(colorNotificationLight.ShowDialog() == DialogResult.OK)
            { 
                pnlColor.BackColor = colorNotificationLight.Color;
                SaveSettings();
            }
        }

        private void BindSettings()
        {
            txtLifxIpAddress.Text = Properties.Settings.Default.LifxIpAddress;
            pnlColor.BackColor = Properties.Settings.Default.LightColor;
            chkBlink.Checked = Properties.Settings.Default.UseBlink1;
            chkLifx.Checked = Properties.Settings.Default.UseLifx;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.LifxIpAddress  = txtLifxIpAddress.Text;
            Properties.Settings.Default.LightColor = pnlColor.BackColor;
            Properties.Settings.Default.UseBlink1 = chkBlink.Checked;
            Properties.Settings.Default.UseLifx = chkLifx.Checked;

            Properties.Settings.Default.Save();
        }

        private void SendNotifications()
        {
            if (Properties.Settings.Default.UseBlink1)
                new BlinkNotification().OnMeetingStart(Properties.Settings.Default.LightColor);
            if (Properties.Settings.Default.UseLifx)
                new LifxNotification().OnMeetingStart(Properties.Settings.Default.LightColor);
        }

        private void StopNotifications()
        {
            if (Properties.Settings.Default.UseBlink1)
                new BlinkNotification().OnMeetingEnd();
            if (Properties.Settings.Default.UseLifx)
                new LifxNotification().OnMeetingEnd();
        }

        private void NotificationType_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnSaveLifxIpAddress_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
