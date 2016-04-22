namespace HydraTouch
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDebug0 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDebug1 = new System.Windows.Forms.Label();
            this.lblDebug2 = new System.Windows.Forms.Label();
            this.lblDebug3 = new System.Windows.Forms.Label();
            this.trayIconMenu.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "HydraTouch";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuSettings,
            this.iconMenuExit});
            this.trayIconMenu.Name = "contextMenuStrip1";
            this.trayIconMenu.Size = new System.Drawing.Size(162, 48);
            // 
            // iconMenuSettings
            // 
            this.iconMenuSettings.Name = "iconMenuSettings";
            this.iconMenuSettings.Size = new System.Drawing.Size(161, 22);
            this.iconMenuSettings.Text = "Settings";
            this.iconMenuSettings.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // iconMenuExit
            // 
            this.iconMenuExit.Name = "iconMenuExit";
            this.iconMenuExit.Size = new System.Drawing.Size(161, 22);
            this.iconMenuExit.Text = "Exit HydraTouch";
            this.iconMenuExit.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.twoToolStripMenuItem,
            this.threeToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(102, 70);
            // 
            // oneToolStripMenuItem
            // 
            this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
            this.oneToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.oneToolStripMenuItem.Text = "one";
            // 
            // twoToolStripMenuItem
            // 
            this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
            this.twoToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.twoToolStripMenuItem.Text = "two";
            // 
            // threeToolStripMenuItem
            // 
            this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
            this.threeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.threeToolStripMenuItem.Text = "three";
            // 
            // lblDebug0
            // 
            this.lblDebug0.AutoSize = true;
            this.lblDebug0.Location = new System.Drawing.Point(13, 13);
            this.lblDebug0.Name = "lblDebug0";
            this.lblDebug0.Size = new System.Drawing.Size(31, 13);
            this.lblDebug0.TabIndex = 9;
            this.lblDebug0.Text = "none";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDebug1
            // 
            this.lblDebug1.AutoSize = true;
            this.lblDebug1.Location = new System.Drawing.Point(121, 13);
            this.lblDebug1.Name = "lblDebug1";
            this.lblDebug1.Size = new System.Drawing.Size(31, 13);
            this.lblDebug1.TabIndex = 10;
            this.lblDebug1.Text = "none";
            // 
            // lblDebug2
            // 
            this.lblDebug2.AutoSize = true;
            this.lblDebug2.Location = new System.Drawing.Point(384, 13);
            this.lblDebug2.Name = "lblDebug2";
            this.lblDebug2.Size = new System.Drawing.Size(31, 13);
            this.lblDebug2.TabIndex = 11;
            this.lblDebug2.Text = "none";
            // 
            // lblDebug3
            // 
            this.lblDebug3.AutoSize = true;
            this.lblDebug3.Location = new System.Drawing.Point(344, 401);
            this.lblDebug3.Name = "lblDebug3";
            this.lblDebug3.Size = new System.Drawing.Size(31, 13);
            this.lblDebug3.TabIndex = 12;
            this.lblDebug3.Text = "none";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 569);
            this.ContextMenuStrip = this.rightClickMenu;
            this.Controls.Add(this.lblDebug3);
            this.Controls.Add(this.lblDebug2);
            this.Controls.Add(this.lblDebug1);
            this.Controls.Add(this.lblDebug0);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HydraTouch Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.trayIconMenu.ResumeLayout(false);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem iconMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem iconMenuExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
        private System.Windows.Forms.Label lblDebug0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDebug1;
        private System.Windows.Forms.Label lblDebug2;
        private System.Windows.Forms.Label lblDebug3;
    }
}

