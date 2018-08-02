using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class DataProcessor
    {
        private readonly SerialPort activeSerialPort;
        public DataProcessor(DataReceiver dataReceiver, SerialPort activePort)
        {
            Console.WriteLine("DataProcessor: Constructing event handler...waiting| " 
                + "for message to be received...");
            this.activeSerialPort = activePort;
            dataReceiver.SerialMessageReceived 
                += dataReceiver_SerialMessageReceived;
        }

        private void dataReceiver_SerialMessageReceived(object sender
            , SerialDataReceivedEventArgs e)
        {
            if (!PortExists())
                return;

            if (activeSerialPort.IsOpen)
            {
                String receivedData = activeSerialPort.ReadExisting();
                Console.WriteLine("dataReceiver_SerialMessageReceived: Just returned|" 
                    + " from ReadExisting() method. Recieved the following data: {0}.|" 
                    + " On port: {1}."
                    , receivedData
                    , activeSerialPort.PortName);
            }
            else
            {
                Console.WriteLine("dataReceiver_SerialMessageReceived: Eventhough read|" 
                    + " event was received: {0} had it's port closed was closed"
                    , activeSerialPort.PortName);
            }
        }

        private bool PortExists()
        {
            bool portExist = activeSerialPort != null;
            if (portExist)
            {
                Console.WriteLine("PortExists: Attempting to read from a populated| " 
                    + "port: {0}."
                    , activeSerialPort.PortName);
                return portExist;
            }
            Console.WriteLine("PortExists: Although received a read event. {0} is null|" 
                + " and connot be read.", activeSerialPort.PortName);
            return portExist;
        }
    }
}
