using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ComPortTest
{
    public class Util
    {
        public static SerialPort ConfigureDevicePort(ref Dictionary<CPTDevice, KeyValuePair<string, SerialPort>> serialPortManager, 
            CPTDevice jDevice, SerialPort serialPort, string dedicatedPort = "COM1")
        {
            if (serialPortManager == null)
                serialPortManager = new Dictionary<CPTDevice, KeyValuePair<string, SerialPort>>();

            if (!serialPortManager.ContainsKey(jDevice) || serialPortManager[jDevice].Key != dedicatedPort)
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    serialPortManager.Add(CPTDevice.BioneerExicycler, new KeyValuePair<string, SerialPort>(dedicatedPort, serialPort));
                }
            }
            else
                serialPort = serialPortManager[jDevice].Value;

            return serialPort;
        }
    }
}
