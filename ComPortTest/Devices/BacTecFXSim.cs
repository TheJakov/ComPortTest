using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ComPortTest
{
    public class BacTecFXSim
    {
        #region Private members
        private string dedicatedPort { get; set; } = null;
        private SerialPort serialPort { get; set; }
        private List<string> messages = new List<string>();
        #endregion

        #region Constructor
        public BacTecFXSim(string port = null)
        {
            dedicatedPort = port ?? "COM1";
            serialPort = new SerialPort(dedicatedPort, 9600, Parity.None, 8);
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
                Send();

            if (asciiBytes[indata.Length - 1] == NAK) { /*error*/ }
        }
        #endregion

        #region Public methods
        public void SendDeviceData(ref Dictionary<CPTDevice, KeyValuePair<string, SerialPort>> devicePort)
        {
            serialPort = Util.ConfigureDevicePort(ref devicePort, CPTDevice.BacTecFX, serialPort, dedicatedPort);

            messages = new List<string>
            {
                $"{cENQ}",
                $"{cSTX}1H|\\^&|||Becton Dickinson||||||||V1.0|20210525091225{cETX}",
                $"7B{cSTX}2P|1{cETX}",
                $"3F{cSTX}3O|1|UR216582||^^^BACTECFX_GND|||19700101020000{cETX}",
                $"40{cSTX}4R|1|^^^GND^449289522914|INST_NEGATIVE|||||P|||20210520090353|20210525091222|BACTECFX^92^5^01^B-C10{cETX}",
                $"6C{cSTX}5L|1|N{cETX}",
                $"08{cEOT}"
            };

            Send();
        }
        #endregion

        #region Private methods
        private void Send()
        {
            if (messages == null || messages.Count == 0)
                return;

            var element = messages.First();
            serialPort.Write(element);
            messages.RemoveAt(0);
        }
        #endregion
    }
}
