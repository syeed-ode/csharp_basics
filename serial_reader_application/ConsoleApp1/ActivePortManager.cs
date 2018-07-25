using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ConsoleApp1
{
    class ActivePortManager
    {
        public List<SerialPort> GetActivePorts()
        {
            string[] nameArray = null;

            nameArray = SerialPort.GetPortNames();
            int numberOfPorts = nameArray.Length;
            Console.Write("Found {} active ports.", numberOfPorts);
            SerialPort[] activeSerialPorts = null;

            List<SerialPort> portList = new List<SerialPort>();
            for (int i = 0; i < numberOfPorts; i++)
            {
                Console.Write("Configuring port {} ", nameArray[i]);
                activeSerialPorts[i] = new SerialPort();
                activeSerialPorts[i].PortName = nameArray[i];
                activeSerialPorts[i].ReadTimeout = 1500;
                portList.Add(activeSerialPorts[i]);
            }
            if(numberOfPorts > 0)
            {
                return portList;
            }
            else
            {
                return null;
            }
            
        }
    }
}
