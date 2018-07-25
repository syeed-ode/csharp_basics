using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ConsoleApp1
{
    class PortReadingService
    {

        ActivePortManager portManager = new ActivePortManager();

        public void ParallelProcessAllPorts()
        {
            // allActivePorts.AsParallel().Select(port => ReadFromActivePort(port));
            Console.WriteLine("ParallelProcessAllPorts: Calling "
                + "portManager to getActivePorts.");
            IEnumerable<SerialPort> allActivePorts = 
                portManager.GetActivePorts();
            if(null == allActivePorts)
            {
                Console.WriteLine("Recieved no active ports. Processing "
                    + "will not be started");
                return;
            }
            Console.WriteLine("ParallelProcessAllPorts: Attempting "
                + "to read from all ports in Parallel");
            System.Threading.Tasks.Parallel
                .ForEach(allActivePorts
                    , port => ReadFromActivePort(port));
        }

        private void ReadFromActivePort(SerialPort activePort)
        {
            if (activePort != null)
            {
                string portName = activePort.PortName;
                Console.WriteLine("PortReadingService: Preparing " +
                    "to read from port {} verifying its open."
                    , portName);
                RetrieveDataFromActivePort(activePort, portName);
            }
            else
            {
                Console.WriteLine("PortReadingService: Something went" +
                    " wrong received a null port");
            }
        }

        private void RetrieveDataFromActivePort(SerialPort activePort, string portName)
        {
            if (activePort.IsOpen)
            {
                Console.WriteLine("{} is an open port and we are preparing" +
                    " to read", portName);
                String recievedText;
                recievedText = activePort.ReadLine();
                Console.WriteLine("Completed reading data as a String. " +
                    "Recieved <><><>{}<><><> as a response", recievedText);
            }
            else
            {
                Console.WriteLine("PortReadingService: Something went" +
                    " {} is now closed.", portName);
            }
        }
    }
}
