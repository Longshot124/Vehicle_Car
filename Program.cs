using System;
using Vehicle_Task.Models;

namespace Vehicle_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();
            Bus bus = new Bus("Mercedes", "Sprinter", "White", 120, 25);

            Console.WriteLine(bus.Info());
          
        }
    }
}
