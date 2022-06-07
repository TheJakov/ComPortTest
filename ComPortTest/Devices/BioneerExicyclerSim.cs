using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ComPortTest
{
    public class BioneerExicyclerSim
    {
        #region Private members
        private string dedicatedPort { get; set; } = null;
        private SerialPort serialPort { get; set; } 
        private List<string> messages = new List<string>();
        #endregion

        #region Constructor
        public BioneerExicyclerSim(string port = null)
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
        const byte CR = 13;
        const byte NAK = 21;
        const byte LF = 10;
        const byte RS = 30;
        const byte GS = 29;

        const char dF = '|';
        const char dR = '\\';
        const char dC = '^';
        const string dC3 = "^^^";
        const char dE = '&';
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
            serialPort = Util.ConfigureDevicePort(ref devicePort, CPTDevice.BioneerExicycler, serialPort, dedicatedPort);

            messages = new List<string>
            {
                $"{C(ENQ)}",

                $"{C(STX)}P{dF}1{dF}{dF}PID00100{dF}{C(CR)}",
                $"{C(STX)}C{dF}1{dF}I{dF}Run = HIV modified test 07 Feb 2007 11:52:24; WellType = Calibrator{dF}G{C(CR)}",
                $"{C(STX)}O{dF}1{dF}SID0002 {dC} HIV Sample Kit{dC}William Lee blood sample {dC} B {dC} 2{dF}{dF}^{dC3}TID00_HIV {dC} HIV{dF}{dF}{dF}{dF}{dF}{dF}{dF}N{dF}{C(CR)}",
                $"{C(STX)}R{dF}1{dF}{dC3}TID00_HIV {dC} HIV{dF} 0.016 {dF} uIU / ml {dF} 0.230 {dC} 3.80 {dF} L {dF}{dF} F {dF}{dF}{dF} 19970425120351 {dF} 19970425122213 {dF}{C(CR)}",
                $"{C(STX)}L{dF}1{dF}N{C(CR)}",

                $"{C(STX)}P{dF}1{dF}{dF}PID00101{dF}{C(CR)}",
                $"{C(STX)}C{dF}1{dF}I{dF}Run = HIV modified test 08 Feb 2007 17:36:09; WellType = Calibrator{dF}G{C(CR)}",
                $"{C(STX)}O{dF}1{dF}SID0003 {dC} HIV Sample Kit{dC}Marucus Helt blood sample {dC} B {dC} 2{dF}{dF}^{dC3}TID00_HIV {dC} HIV{dF}{dF}{dF}{dF}{dF}{dF}{dF}N{dF}{C(CR)}",
                $"{C(STX)}R{dF}1{dF}{dC3}TID00_HIV {dC} HIV{dF} 0.019 {dF} uIU / ml {dF} 0.230 {dC} 3.60 {dF} L {dF}{dF} F {dF}{dF}{dF} 19970425120351 {dF} 19970425125277 {dF}{C(CR)}",
                $"{C(STX)}L{dF}1{dF}N{C(CR)}",

                $"08{C(EOT)}"
            };

            Send();
        }
        #endregion

        #region Private methods
        private void Send()
        {
            if (messages.Count == 0)
                return;

            var element = messages.First();
            serialPort.Write(element);
            messages.RemoveAt(0);
        }

        /// <summary>
        /// Returns char representation of byte value
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private static char C(byte b)
        {
            return (char)b;
        }
        #endregion
    }
}
