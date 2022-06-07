using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPortTest
{
    public partial class Form1 : Form
    {
        Dictionary<CPTDevice, KeyValuePair<string, SerialPort>> SerialPortManager = new Dictionary<CPTDevice, KeyValuePair<string, SerialPort>>();

        public Form1()
        {
            InitializeComponent();
            InitDevicePortSettings();
        }

        private void InitDevicePortSettings()
        {
            try
            {
                txtComPortMiniVidas.Text = "COM1";
                txtComPortBacTecFX.Text = "COM2";
                txtComPortBioneerExicycler.Text = "COM3";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, ex.GetType().Name);
            }
        }

        private void BacTecFXButton_Click(object sender, EventArgs e)
        {
            try
            {
                new BacTecFXSim(txtComPortBacTecFX.Text).SendDeviceData(ref SerialPortManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, ex.GetType().Name);
            }
        }

        private void MiniVidasButton_Click(object sender, EventArgs e)
        {
            try
            {
                new MiniVidasSim(txtComPortMiniVidas.Text).SendDeviceData(ref SerialPortManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, ex.GetType().Name);
            }
        }

        private void BioneerExicyclerButton_Click(object sender, EventArgs e)
        {
            try
            {
                new BioneerExicyclerSim(txtComPortBioneerExicycler.Text).SendDeviceData(ref SerialPortManager);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, ex.GetType().Name);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                this.ShowInTaskbar = false;

                if (SerialPortManager == null)
                    return;

                foreach(var portItem in SerialPortManager)
                {
                    if (portItem.Value.Value.IsOpen)
                        portItem.Value.Value.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, ex.GetType().Name);
            }
        }
    }

    public enum CPTDevice
    {
        MiniVidas,
        BacTecFX,
        BioneerExicycler
    }
}
