using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(((0x([0-9]|[a-f])([0-9]|[a-f])?)|(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]))\.){3}" +
                    @"((0x([0-9]|[a-f])([0-9]|[a-f])?)|(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]))";
            var ips = new List<string>();
            ips.Add("99.198.122.146");
            ips.Add("0xFF.255.138.0x12");
            ips.Add("256.256.256.256");

            Console.WriteLine("All IP-addresses:");
            foreach (var ip in ips)
            {
                Console.WriteLine(ip);
            }

            Console.WriteLine("\nValid IP-addresses:");
            foreach (var ip in ips)
            {
                if (Regex.Match(ip, pattern, RegexOptions.IgnoreCase).Success)
                {
                    Console.WriteLine(ip);
                }
            }

            Console.ReadKey();
        }
    }
}
