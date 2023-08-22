using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhileSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
