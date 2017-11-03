namespace COM2Sniffer
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.Port1COM = new System.Windows.Forms.ComboBox();
            this.Port1Baud = new System.Windows.Forms.ComboBox();
            this.Port1Button = new System.Windows.Forms.Button();
            this.Port2Button = new System.Windows.Forms.Button();
            this.Port2Baud = new System.Windows.Forms.ComboBox();
            this.Port2COM = new System.Windows.Forms.ComboBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 1024;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.ReadBufferSize = 1024;
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // Port1COM
            // 
            this.Port1COM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Port1COM.BackColor = System.Drawing.Color.Black;
            this.Port1COM.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::COM2Sniffer.Properties.Settings.Default, "COM1Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Port1COM.ForeColor = System.Drawing.Color.Green;
            this.Port1COM.FormattingEnabled = true;
            this.Port1COM.Location = new System.Drawing.Point(12, 351);
            this.Port1COM.Name = "Port1COM";
            this.Port1COM.Size = new System.Drawing.Size(71, 21);
            this.Port1COM.TabIndex = 2;
            this.Port1COM.Text = global::COM2Sniffer.Properties.Settings.Default.COM1Port;
            // 
            // Port1Baud
            // 
            this.Port1Baud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Port1Baud.BackColor = System.Drawing.Color.Black;
            this.Port1Baud.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::COM2Sniffer.Properties.Settings.Default, "COM1Baud", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Port1Baud.ForeColor = System.Drawing.Color.Green;
            this.Port1Baud.FormattingEnabled = true;
            this.Port1Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230600",
            "461200"});
            this.Port1Baud.Location = new System.Drawing.Point(89, 351);
            this.Port1Baud.Name = "Port1Baud";
            this.Port1Baud.Size = new System.Drawing.Size(89, 21);
            this.Port1Baud.TabIndex = 3;
            this.Port1Baud.Text = global::COM2Sniffer.Properties.Settings.Default.COM1Baud;
            // 
            // Port1Button
            // 
            this.Port1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Port1Button.BackColor = System.Drawing.Color.Black;
            this.Port1Button.ForeColor = System.Drawing.Color.Green;
            this.Port1Button.Location = new System.Drawing.Point(184, 351);
            this.Port1Button.Name = "Port1Button";
            this.Port1Button.Size = new System.Drawing.Size(75, 21);
            this.Port1Button.TabIndex = 4;
            this.Port1Button.Text = "Connect";
            this.Port1Button.UseVisualStyleBackColor = false;
            this.Port1Button.Click += new System.EventHandler(this.Port1Button_Click);
            // 
            // Port2Button
            // 
            this.Port2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Port2Button.BackColor = System.Drawing.Color.Black;
            this.Port2Button.ForeColor = System.Drawing.Color.Red;
            this.Port2Button.Location = new System.Drawing.Point(351, 351);
            this.Port2Button.Name = "Port2Button";
            this.Port2Button.Size = new System.Drawing.Size(75, 21);
            this.Port2Button.TabIndex = 7;
            this.Port2Button.Text = "Connect";
            this.Port2Button.UseVisualStyleBackColor = false;
            this.Port2Button.Click += new System.EventHandler(this.Port2Button_Click);
            // 
            // Port2Baud
            // 
            this.Port2Baud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Port2Baud.BackColor = System.Drawing.Color.Black;
            this.Port2Baud.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::COM2Sniffer.Properties.Settings.Default, "COM2Baud", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Port2Baud.ForeColor = System.Drawing.Color.Red;
            this.Port2Baud.FormattingEnabled = true;
            this.Port2Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230600",
            "461200"});
            this.Port2Baud.Location = new System.Drawing.Point(432, 351);
            this.Port2Baud.Name = "Port2Baud";
            this.Port2Baud.Size = new System.Drawing.Size(89, 21);
            this.Port2Baud.TabIndex = 6;
            this.Port2Baud.Text = global::COM2Sniffer.Properties.Settings.Default.COM2Baud;
            // 
            // Port2COM
            // 
            this.Port2COM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Port2COM.BackColor = System.Drawing.Color.Black;
            this.Port2COM.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::COM2Sniffer.Properties.Settings.Default, "COM2Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Port2COM.ForeColor = System.Drawing.Color.Red;
            this.Port2COM.FormattingEnabled = true;
            this.Port2COM.Location = new System.Drawing.Point(527, 351);
            this.Port2COM.Name = "Port2COM";
            this.Port2COM.Size = new System.Drawing.Size(71, 21);
            this.Port2COM.TabIndex = 5;
            this.Port2COM.Text = global::COM2Sniffer.Properties.Settings.Default.COM2Port;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearAllButton.Location = new System.Drawing.Point(265, 351);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(77, 21);
            this.ClearAllButton.TabIndex = 8;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.Location = new System.Drawing.Point(12, 12);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(586, 333);
            this.LogBox.TabIndex = 10;
            this.LogBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(610, 384);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.Port2Button);
            this.Controls.Add(this.Port2Baud);
            this.Controls.Add(this.Port2COM);
            this.Controls.Add(this.Port1Button);
            this.Controls.Add(this.Port1Baud);
            this.Controls.Add(this.Port1COM);
            this.Name = "Form1";
            this.Text = "COM Sniffer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox Port1COM;
        private System.Windows.Forms.ComboBox Port1Baud;
        private System.Windows.Forms.Button Port1Button;
        private System.Windows.Forms.Button Port2Button;
        private System.Windows.Forms.ComboBox Port2Baud;
        private System.Windows.Forms.ComboBox Port2COM;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Timer InterfaceTimer;
        private System.Windows.Forms.RichTextBox LogBox;
    }
}

