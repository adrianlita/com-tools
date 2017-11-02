using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.IO.Ports;
using System.Runtime.InteropServices;


namespace COMLister
{
    public partial class Form1 : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1;
        public byte seconds_left;

        public void MyShow()
        {
            seconds_left = 10;
            timer_refreshports_Tick(null, null);
            timer_refreshports.Enabled = true;
            timer_autohide.Enabled = true;
            this.Show();
        }

        public void MyHide()
        {
            timer_autohide.Enabled = false;
            timer_refreshports.Enabled = false;
            this.Hide();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                if (this.Visible)
                    this.MyHide();
                else
                    this.MyShow();
            }
            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
            seconds_left = 10;

            //3 for CTRL ALT,, 6 for CTRLSHIFT
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 3, (int)'C');
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            this.MyShow();
        }

        private void timer_refreshports_Tick(object sender, EventArgs e)
        {
            COM_List.Clear();
            Detailed_List.Clear();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSSerial_PortName");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Detailed_List.Text += queryObj["InstanceName"] + "\r\n";
                    COM_List.Text += queryObj["PortName"] + "\r\n";

                    //If the serial port's instance name contains USB 
                    //it must be a USB to serial device
                    // if (queryObj["InstanceName"].ToString().Contains("USB"))
                    // {
                    //     COM_List.Text += queryObj["PortName"] + " is a USB to SERIAL adapter / converter\r\n";
                    // }
                }
            }
            catch (ManagementException xe)
            {
                Detailed_List.Text = "No WMI data: " + xe.Message;
            }
        }

        private void timer_autohide_Tick(object sender, EventArgs e)
        {
            seconds_left--;
            if (seconds_left == 0)
            {
                this.MyHide();
            }
        }
    }
}
