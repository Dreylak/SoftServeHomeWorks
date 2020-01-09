using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Task(n));

            Console.ReadKey();
        }
        
        public static long Task(int n)
        {
            return CombosOnBranch(n, 1) - 1;
        }

        private static long CombosOnBranch(int blocksLeft, int minHeight)
        {
            if (minHeight > blocksLeft) return 0;
            if (minHeight == blocksLeft) return 1;

            long combos = 0;
            int currentHeight;
            for (currentHeight = minHeight; currentHeight + 1 <= blocksLeft - currentHeight; currentHeight++)
            {
                long subBranchCombos = CombosOnBranch(blocksLeft - currentHeight, currentHeight + 1);
                if (subBranchCombos > 0)
                {
                    combos += subBranchCombos;
                }
            }
            if (blocksLeft > 0) combos++;

            return combos;
        }
    }
}
