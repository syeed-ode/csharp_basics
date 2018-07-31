using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class PortReadingService
    {
        static private SerialPort commPort;

        private static SerialDataReceivedEventHandler serialDataReceivedEventHandler
            = new SerialDataReceivedEventHandler(this.DataReceived);

        public PortReadingService(SerialPort port)
        {
            commPort = port;
        }
        
        internal void DataReceived(object sender, SerialDataRecievedEventArgs e)
        {
            // recieved processing
        }
    }
}
