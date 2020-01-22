using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new StringBuilder();
            items.Append("First list item\n");
            items.Append("Second list item\n");
            items.Append("Second list item\n");
            items.Append("Repeated list item\n");
            items.Append("Repeated list item\n");
            items.Append("Repeated list item\n");

            Console.WriteLine("Items:");
            Console.WriteLine(items.ToString());

            var pattern = @"(.*\r?\n)(\1*)";
            string replaceDuplicatesWith = "$1";

            string result = Regex.Replace(items.ToString(), pattern, replaceDuplicatesWith);

            Console.WriteLine("Result:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
