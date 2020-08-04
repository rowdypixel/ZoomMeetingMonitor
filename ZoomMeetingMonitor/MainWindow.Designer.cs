namespace ZoomMeetingMonitor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bgwCheckForZoom = new System.ComponentModel.BackgroundWorker();
            this.tmrCheckForChanges = new System.Windows.Forms.Timer(this.components);
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // bgwCheckForZoom
            // 
            this.bgwCheckForZoom.WorkerReportsProgress = true;
            this.bgwCheckForZoom.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckForZoom_DoWork);
            // 
            // tmrCheckForChanges
            // 
            this.tmrCheckForChanges.Tick += new System.EventHandler(this.tmrCheckForChanges_Tick);
            // 
            // icoTray
            // 
            this.icoTray.Text = "Zoom Meeting Monitor";
            this.icoTray.Visible = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainWindow";
            this.Text = "Zoom Meeting Monitor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwCheckForZoom;
        private System.Windows.Forms.Timer tmrCheckForChanges;
        private System.Windows.Forms.NotifyIcon icoTray;
    }
}

