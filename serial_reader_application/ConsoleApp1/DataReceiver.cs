using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class DataReceiver
    {
        public event SerialDataReceivedEventHandler SerialMessageReceived;

        public void OnSerialDataReceived(SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("OnSerialDataReceived: Constructing event reader.");
            SerialDataReceivedEventHandler serialMessageRecieved = SerialMessageReceived;

            if (serialMessageRecieved != null)
            {
                serialMessageRecieved(this, e);
            }
        }
    }
}
