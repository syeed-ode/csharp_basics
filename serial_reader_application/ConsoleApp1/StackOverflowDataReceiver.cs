using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class StackOverflowDataReceiver
    {
        private readonly SerialPort port;
        public StackOverflowDataReceiver(SerialPort activePort)
        {
            port = activePort;
            Console.WriteLine("StackOverflowDataReceiver: Incoming Data: ");
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(sofdr_DataReceiver);
        }

        private void sofdr_DataReceiver(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("sofdr_DataReceiver: received an event. Preparing to read data");
            string dataRead = port.ReadExisting();
            Console.WriteLine("sofdr_DataReceiver:  Received this data: {0}", dataRead);
        }
    }
}
