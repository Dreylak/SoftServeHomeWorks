using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?!1000)+(1[0-9][0-9][0-9]|20[0-1][0-2])";

            var dates = new List<string>();
            dates.Add("1000/01/01 00:01");
            dates.Add("1001/01/01 00:01");
            dates.Add("2012/09/18 12:10");
            dates.Add("2013/09/09 09:09");

            Console.WriteLine("All dates:");
            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }

            Console.WriteLine("\nDates between 1000 and 2013 year");
            foreach (var date in dates)
            {
                if (Regex.Match(date.Substring(0, 4), pattern).Success)
                {
                    Console.WriteLine(date);
                }
            }

            Console.ReadKey();
        }
    }
}
