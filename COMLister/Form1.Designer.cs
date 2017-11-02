namespace COMLister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.COM_List = new System.Windows.Forms.TextBox();
            this.Detailed_List = new System.Windows.Forms.TextBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_refreshports = new System.Windows.Forms.Timer(this.components);
            this.timer_autohide = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // COM_List
            // 
            this.COM_List.Location = new System.Drawing.Point(13, 13);
            this.COM_List.Multiline = true;
            this.COM_List.Name = "COM_List";
            this.COM_List.ReadOnly = true;
            this.COM_List.Size = new System.Drawing.Size(90, 113);
            this.COM_List.TabIndex = 1;
            this.COM_List.WordWrap = false;
            // 
            // Detailed_List
            // 
            this.Detailed_List.Location = new System.Drawing.Point(109, 13);
            this.Detailed_List.Multiline = true;
            this.Detailed_List.Name = "Detailed_List";
            this.Detailed_List.ReadOnly = true;
            this.Detailed_List.Size = new System.Drawing.Size(288, 113);
            this.Detailed_List.TabIndex = 3;
            this.Detailed_List.WordWrap = false;
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
            // 
            // timer_refreshports
            // 
            this.timer_refreshports.Enabled = true;
            this.timer_refreshports.Interval = 1000;
            this.timer_refreshports.Tick += new System.EventHandler(this.timer_refreshports_Tick);
            // 
            // timer_autohide
            // 
            this.timer_autohide.Enabled = true;
            this.timer_autohide.Interval = 1000;
            this.timer_autohide.Tick += new System.EventHandler(this.timer_autohide_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 138);
            this.ControlBox = false;
            this.Controls.Add(this.Detailed_List);
            this.Controls.Add(this.COM_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "COM Ports";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox COM_List;
        private System.Windows.Forms.TextBox Detailed_List;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Timer timer_refreshports;
        private System.Windows.Forms.Timer timer_autohide;
    }
}

