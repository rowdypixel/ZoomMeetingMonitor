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
            this.btnSaveLifxIpAddress = new System.Windows.Forms.Button();
            this.txtLifxIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.chkLifx = new System.Windows.Forms.CheckBox();
            this.chkBlink = new System.Windows.Forms.CheckBox();
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
            this.tmrCheckForChanges.Interval = 5000;
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
            this.btnToggleLight.Location = new System.Drawing.Point(146, 137);
            this.btnToggleLight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleLight.Name = "btnToggleLight";
            this.btnToggleLight.Size = new System.Drawing.Size(174, 35);
            this.btnToggleLight.TabIndex = 0;
            this.btnToggleLight.Text = "Set in Meeting";
            this.btnToggleLight.UseVisualStyleBackColor = true;
            this.btnToggleLight.Click += new System.EventHandler(this.btnToggleLight_Click);
            // 
            // grpOverride
            // 
            this.grpOverride.Controls.Add(this.lblOverrideInstructions);
            this.grpOverride.Controls.Add(this.btnToggleLight);
            this.grpOverride.Location = new System.Drawing.Point(18, 18);
            this.grpOverride.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOverride.Name = "grpOverride";
            this.grpOverride.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOverride.Size = new System.Drawing.Size(330, 382);
            this.grpOverride.TabIndex = 1;
            this.grpOverride.TabStop = false;
            this.grpOverride.Text = "Detection Override";
            // 
            // lblOverrideInstructions
            // 
            this.lblOverrideInstructions.Location = new System.Drawing.Point(2, 31);
            this.lblOverrideInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverrideInstructions.Name = "lblOverrideInstructions";
            this.lblOverrideInstructions.Size = new System.Drawing.Size(318, 102);
            this.lblOverrideInstructions.TabIndex = 1;
            this.lblOverrideInstructions.Text = "This button will stop the meeting detection and turn on notifications. Press the " +
    "button again to resume automatic detection.";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(111, 80);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(180, 35);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Choose Light Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(70, 80);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(32, 35);
            this.pnlColor.TabIndex = 3;
            // 
            // grpNotifications
            // 
            this.grpNotifications.Controls.Add(this.btnSaveLifxIpAddress);
            this.grpNotifications.Controls.Add(this.txtLifxIpAddress);
            this.grpNotifications.Controls.Add(this.chkLifx);
            this.grpNotifications.Controls.Add(this.chkBlink);
            this.grpNotifications.Controls.Add(this.pnlColor);
            this.grpNotifications.Controls.Add(this.btnChangeColor);
            this.grpNotifications.Location = new System.Drawing.Point(357, 18);
            this.grpNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNotifications.Size = new System.Drawing.Size(300, 382);
            this.grpNotifications.TabIndex = 4;
            this.grpNotifications.TabStop = false;
            this.grpNotifications.Text = "Notification Settings";
            // 
            // btnSaveLifxIpAddress
            // 
            this.btnSaveLifxIpAddress.Location = new System.Drawing.Point(170, 168);
            this.btnSaveLifxIpAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveLifxIpAddress.Name = "btnSaveLifxIpAddress";
            this.btnSaveLifxIpAddress.Size = new System.Drawing.Size(112, 35);
            this.btnSaveLifxIpAddress.TabIndex = 7;
            this.btnSaveLifxIpAddress.Text = "Set IP";
            this.btnSaveLifxIpAddress.UseVisualStyleBackColor = true;
            this.btnSaveLifxIpAddress.Click += new System.EventHandler(this.btnSaveLifxIpAddress_Click);
            // 
            // txtLifxIpAddress
            // 
            this.txtLifxIpAddress.Location = new System.Drawing.Point(10, 172);
            this.txtLifxIpAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLifxIpAddress.Mask = "000.000.000.000";
            this.txtLifxIpAddress.Name = "txtLifxIpAddress";
            this.txtLifxIpAddress.Size = new System.Drawing.Size(148, 26);
            this.txtLifxIpAddress.TabIndex = 6;
            // 
            // chkLifx
            // 
            this.chkLifx.AutoSize = true;
            this.chkLifx.Location = new System.Drawing.Point(9, 137);
            this.chkLifx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLifx.Name = "chkLifx";
            this.chkLifx.Size = new System.Drawing.Size(129, 24);
            this.chkLifx.TabIndex = 5;
            this.chkLifx.Text = "Use LIFX light";
            this.chkLifx.UseVisualStyleBackColor = true;
            this.chkLifx.CheckedChanged += new System.EventHandler(this.NotificationType_CheckedChanged);
            // 
            // chkBlink
            // 
            this.chkBlink.AutoSize = true;
            this.chkBlink.Location = new System.Drawing.Point(10, 45);
            this.chkBlink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(153, 24);
            this.chkBlink.TabIndex = 4;
            this.chkBlink.Text = "Use Blink(1) Light";
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.NotificationType_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.grpNotifications);
            this.Controls.Add(this.grpOverride);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Online Meeting Monitor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.grpOverride.ResumeLayout(false);
            this.grpNotifications.ResumeLayout(false);
            this.grpNotifications.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkLifx;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.Button btnSaveLifxIpAddress;
        private System.Windows.Forms.MaskedTextBox txtLifxIpAddress;
    }
}

