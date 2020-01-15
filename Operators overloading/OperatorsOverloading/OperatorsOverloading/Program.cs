using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(10, 0, 0);
            Timer timer = new Timer(10, 10, 10);
            Console.WriteLine("Clock:\n" + clock);
            Console.WriteLine("Timer:\n" + timer);
            Console.WriteLine("\nClock - timer = " + (clock - timer));
            Console.WriteLine("\nClock + timer = " + (clock + timer));

            Console.ReadKey();
        }
    }
}
