using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace COM2Sniffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddData(RichTextBox TextEventLog, string line, int port)
        {
            if (TextEventLog.InvokeRequired)
            {
                TextEventLog.BeginInvoke(new Action(delegate {
                    AddData(TextEventLog, line, port);
                }));
                return;
            }

            TextEventLog.SelectionStart = LogBox.TextLength;
            TextEventLog.SelectionLength = 0;
            if (port == 1)
                TextEventLog.SelectionColor = Color.Green;
            else
                TextEventLog.SelectionColor = Color.Red;
            TextEventLog.AppendText(line);
            TextEventLog.SelectionColor = TextEventLog.ForeColor;

            TextEventLog.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //COM ports listing
            var ports = System.IO.Ports.SerialPort.GetPortNames();
            for(int i = 0; i < ports.Count() - 1; i++)
            {
                Port1COM.Items.Add(ports[i]);
                Port2COM.Items.Add(ports[i]);
            }
            

            for(int i = 0; i < Port1COM.Items.Count - 1; i++)
                if(Port1COM.Items[i].ToString() == "COM33")
                    Port1COM.Text = "COM33";

            for (int i = 0; i < Port2COM.Items.Count - 1; i++)
                if (Port2COM.Items[i].ToString() == "COM32")
                    Port2COM.Text = "COM32";

            ClearAllButton_Click(sender, e);
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Port1COM.Enabled = false;
                Port1Baud.Enabled = false;
                Port1Button.Text = "Disconnect";
            }
            else
            {
                Port1COM.Enabled = true;
                Port1Baud.Enabled = true;
                Port1Button.Text = "Connect";
            }

            if (serialPort2.IsOpen)
            {
                Port2COM.Enabled = false;
                Port2Baud.Enabled = false;
                Port2Button.Text = "Disconnect";
            }
            else
            {
                Port2COM.Enabled = true;
                Port2Baud.Enabled = true;
                Port2Button.Text = "Connect";
            }
        }

        private void Port1Button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.BaudRate = Convert.ToInt32(Port1Baud.Text);
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                serialPort1.RtsEnable = false;
                serialPort1.DtrEnable = false;
                serialPort1.DataBits = 8;
                serialPort1.PortName = Port1COM.Text;
                serialPort1.Open();
            }
        }

        private void Port2Button_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }
            else
            {
                serialPort2.BaudRate = Convert.ToInt32(Port2Baud.Text);
                serialPort2.Parity = System.IO.Ports.Parity.None;
                serialPort2.StopBits = System.IO.Ports.StopBits.One;
                serialPort2.RtsEnable = false;
                serialPort2.DtrEnable = false;
                serialPort2.DataBits = 8;
                serialPort2.PortName = Port2COM.Text;
                serialPort2.Open();
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort spL = (SerialPort)sender;
            byte[] buf = new byte[spL.BytesToRead];
            spL.Read(buf, 0, buf.Length);
            AddData(LogBox, System.Text.Encoding.ASCII.GetString(buf), 1);
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort spL = (SerialPort)sender;
            byte[] buf = new byte[spL.BytesToRead];
            spL.Read(buf, 0, buf.Length);
            AddData(LogBox, System.Text.Encoding.ASCII.GetString(buf), 2);     
        }
    }
}
