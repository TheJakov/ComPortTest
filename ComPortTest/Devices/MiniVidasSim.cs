using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPortTest
{
    public class MiniVidasSim
    {
        #region Private members
        private string dedicatedPort { get; set; } = null;
        private static List<string> messages = new List<string>();
        private static SerialPort serialPort { get; set; }
        #endregion

        #region Constructor
        public MiniVidasSim(string port = null)
        {
            dedicatedPort = port ??"COM1";
            serialPort = new SerialPort(dedicatedPort, 1200, Parity.None, 8);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        #endregion

        #region Consts
        const byte SOH = 1;
        const byte STX = 2;
        const byte ETX = 3;
        const byte EOT = 4;
        const byte ENQ = 5;
        const byte ACK = 6;
        const byte NAK = 21;
        const byte LF = 10;
        const byte RS = 30;
        const byte GS = 29;
        const char cSOH = (char)SOH;
        const char cSTX = (char)STX;
        const char cETX = (char)ETX;
        const char cEOT = (char)EOT;
        const char cACK = (char)ACK;
        const char cNAK = (char)NAK;
        const char cLF = (char)LF;
        const char cRS = (char)RS;
        const char cGS = (char)GS;
        const char cENQ = (char)ENQ;
        #endregion

        #region Event handlers
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(indata);

            if (asciiBytes[indata.Length - 1] == ACK)
            {
                Send();
            }

            if (asciiBytes[indata.Length - 1] == NAK) { /*error*/ }
        }
        #endregion

        #region Public methods
        public void SendDeviceData(ref Dictionary<CPTDevice, KeyValuePair<string, SerialPort>> serialPortManager)
        {
            serialPort = Util.ConfigureDevicePort(ref serialPortManager, CPTDevice.MiniVidas, serialPort, dedicatedPort);

            messages = new List<string>
            {
                $"{cENQ}",
                $"{cSTX}{cRS}mtrsl|",
                $"{cRS}pi|{cRS}pn|",
                $"{cRS}si|{cRS}ci2",
                "52109357",
                $"0|{cRS}rtTXG",
                $"A|{cRS}rnTox",
                $"o IgG Av",
                $"idity|{cRS}t",
                $"t10:00|{cRS}",
                $"td06/16/",
                $"21|{cRS}qlHi",
                $"gh|{cRS}qn0.",
                $"486|{cGS}88",
                $"{cETX}",
                $"{cEOT}"
            };

            Send();
        }
        #endregion

        #region Private methods
        private void Send()
        {
            if (messages == null || messages.Count == 0)
                return;

            string element = messages.FirstOrDefault();

            if (element == $"{cENQ}")
            {
                serialPort.Write(element);
                messages.RemoveAt(0);
            }                   
            else if (element == $"{cEOT}")
                serialPort.Write(element);
            else
            {
                foreach(string bg in messages)
                {
                    if (bg == $"{cEOT}")
                        break;

                    serialPort.Write(bg);
                    System.Threading.Thread.Sleep(200);
                }
                messages.Clear();
                messages.Add($"{cEOT}");
            }
        }
        #endregion
    }
}
