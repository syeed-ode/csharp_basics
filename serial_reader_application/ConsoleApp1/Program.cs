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
            Console.ReadKey();

            Console.WriteLine("Beghinning to read from COMM Port:");
            PortReadingService portReadingService = new PortReadingService();
            portReadingService.ParallelProcessAllPorts();
        }
    }
}
