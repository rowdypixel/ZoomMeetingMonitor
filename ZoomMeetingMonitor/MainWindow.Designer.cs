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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.bgwCheckForZoom = new System.ComponentModel.BackgroundWorker();
            this.tmrCheckForChanges = new System.Windows.Forms.Timer(this.components);
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnToggleLight = new System.Windows.Forms.Button();
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
            this.icoTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTray.Icon")));
            this.icoTray.Text = "Zoom Meeting Monitor";
            this.icoTray.Visible = true;
            this.icoTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icoTray_MouseDoubleClick);
            // 
            // btnToggleLight
            // 
            this.btnToggleLight.Location = new System.Drawing.Point(12, 12);
            this.btnToggleLight.Name = "btnToggleLight";
            this.btnToggleLight.Size = new System.Drawing.Size(116, 23);
            this.btnToggleLight.TabIndex = 0;
            this.btnToggleLight.Text = "Set In Meeting";
            this.btnToggleLight.UseVisualStyleBackColor = true;
            this.btnToggleLight.Click += new System.EventHandler(this.btnToggleLight_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToggleLight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Online Meeting Monitor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwCheckForZoom;
        private System.Windows.Forms.Timer tmrCheckForChanges;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.Button btnToggleLight;
    }
}

