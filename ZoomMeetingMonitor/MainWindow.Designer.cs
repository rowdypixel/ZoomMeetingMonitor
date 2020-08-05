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
            this.grpOverride = new System.Windows.Forms.GroupBox();
            this.lblOverrideInstructions = new System.Windows.Forms.Label();
            this.colorNotificationLight = new System.Windows.Forms.ColorDialog();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.grpOverride.SuspendLayout();
            this.grpNotifications.SuspendLayout();
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
            this.btnToggleLight.Location = new System.Drawing.Point(97, 89);
            this.btnToggleLight.Name = "btnToggleLight";
            this.btnToggleLight.Size = new System.Drawing.Size(116, 23);
            this.btnToggleLight.TabIndex = 0;
            this.btnToggleLight.Text = "Set in Meeting";
            this.btnToggleLight.UseVisualStyleBackColor = true;
            this.btnToggleLight.Click += new System.EventHandler(this.btnToggleLight_Click);
            // 
            // grpOverride
            // 
            this.grpOverride.Controls.Add(this.lblOverrideInstructions);
            this.grpOverride.Controls.Add(this.btnToggleLight);
            this.grpOverride.Location = new System.Drawing.Point(12, 12);
            this.grpOverride.Name = "grpOverride";
            this.grpOverride.Size = new System.Drawing.Size(220, 118);
            this.grpOverride.TabIndex = 1;
            this.grpOverride.TabStop = false;
            this.grpOverride.Text = "Detection Override";
            // 
            // lblOverrideInstructions
            // 
            this.lblOverrideInstructions.Location = new System.Drawing.Point(1, 20);
            this.lblOverrideInstructions.Name = "lblOverrideInstructions";
            this.lblOverrideInstructions.Size = new System.Drawing.Size(212, 66);
            this.lblOverrideInstructions.TabIndex = 1;
            this.lblOverrideInstructions.Text = "This button will stop the meeting detection and turn on notifications. Press the " +
    "button again to resume automatic detection.";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(33, 29);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 23);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Choose Light Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(6, 29);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(21, 23);
            this.pnlColor.TabIndex = 3;
            // 
            // grpNotifications
            // 
            this.grpNotifications.Controls.Add(this.pnlColor);
            this.grpNotifications.Controls.Add(this.btnChangeColor);
            this.grpNotifications.Location = new System.Drawing.Point(238, 12);
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.Size = new System.Drawing.Size(200, 118);
            this.grpNotifications.TabIndex = 4;
            this.grpNotifications.TabStop = false;
            this.grpNotifications.Text = "Notification Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 154);
            this.Controls.Add(this.grpNotifications);
            this.Controls.Add(this.grpOverride);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Online Meeting Monitor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.grpOverride.ResumeLayout(false);
            this.grpNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwCheckForZoom;
        private System.Windows.Forms.Timer tmrCheckForChanges;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.Button btnToggleLight;
        private System.Windows.Forms.GroupBox grpOverride;
        private System.Windows.Forms.Label lblOverrideInstructions;
        private System.Windows.Forms.ColorDialog colorNotificationLight;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.GroupBox grpNotifications;
    }
}

