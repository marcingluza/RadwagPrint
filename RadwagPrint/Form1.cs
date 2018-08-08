using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadwagPrint
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortComboBox.Items.AddRange(ports);
            PortComboBox.SelectedIndex = 1;
            CloseButton.Enabled = false;
            toolStripStatusLabelConnected.Text = "Rozłączono";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenButton.Enabled = false;
            CloseButton.Enabled = true;
            toolStripStatusLabelConnected.Text = "Połączono";
            try
            {
                serialPort.PortName = PortComboBox.Text;
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            OpenButton.Enabled = true;
            CloseButton.Enabled = false;
            toolStripStatusLabelConnected.Text = "Rozłączono";
            try
            {
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Thread.Sleep(50);
                SerialPort serialPort1 = sender as SerialPort;
                byte[] data = new byte[serialPort1.BytesToRead];
                Stream portStream = serialPort1.BaseStream;
                portStream.Read(data, 0, data.Length);
                String dataString = Encoding.UTF8.GetString(data);

                StringBuilder sb = new StringBuilder(dataString);
                sb.Replace("[", "");
                sb.Replace("]", "");
                sb.Replace(" ", "");

                Console.Write(sb.ToString());
            }));
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

   

}
