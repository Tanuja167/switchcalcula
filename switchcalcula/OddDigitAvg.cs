using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class OddDigitAvg
    {
        static void Main(string[] args)
        {
            int sum = 0, avg=0, count=0;
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                int rem = num % 10;

                num = num / 10;
                if (rem % 2 != 0)
                {
                    count++;
                    sum = sum + rem;
                    avg = sum / count;
                }
                
            }
            Console.WriteLine(avg);

        }
    }
}
