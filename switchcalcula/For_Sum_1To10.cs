using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class For_Sum_1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;

            }

            Console.WriteLine("sum of all numbers: " + sum);
        }
    }
}
