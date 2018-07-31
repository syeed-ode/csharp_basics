using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string stop = "";
            while("stop" != stop.ToLowerInvariant())
            {
                Console.WriteLine("Beginning to process any available COMM port:");
                PortManagingService portReadingService = new PortManagingService();
                portReadingService.ParallelProcessAllPorts();
                Console.WriteLine();
                stop = Console.ReadLine();
            }
        }
    }
}
