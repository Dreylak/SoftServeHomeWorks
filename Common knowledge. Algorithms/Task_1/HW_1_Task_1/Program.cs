using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n >= 0 && n <= 109)
            {
                Console.WriteLine(Task(n));
            }
            else Console.WriteLine("Wrong number!");

            Console.ReadKey();
        }

        private static long Task(int n)
        {
            if (n >= 0 && n <= 9) return n;

            Stack<int> digits = GetDigitDividers(n);

            if (digits.Pop() != 1) return -1;

            return GetNumberFromDigits(digits);
        }

        private static Stack<int> GetDigitDividers(int n)
        {
            Stack<int> digits = new Stack<int>();

            for (int i = 9; i > 1 && n > 1; i--)
            {
                while (n % i == 0)
                {
                    digits.Push(i);
                    n /= i;
                }
            }

            digits.Push(n);

            return digits;
        }

        private static long GetNumberFromDigits(Stack<int> digits)
        {
            long res = 0;

            while (digits.Count != 0)
            {
                res = res * 10 + digits.Pop();
            }

            return res;
        }
    }
}
