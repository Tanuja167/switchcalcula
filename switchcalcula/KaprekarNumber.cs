using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class KaprekarNumber
    {
        //check number is kaprekar or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int pow = 1,sum=0, count=0;

            int sq = num * num;
            int temp = num;
            while(num > 0)
            {
                count++;            
                num = num / 10;
            }

            for (int i = 1; i <= count; i++)
            {
                pow = pow * 10;
            }
                int end = sq % pow;
                int start = sq / pow;
                sum = end + start;
                //Console.WriteLine(sum);

                if (temp == sum)
                {
                    Console.WriteLine("kaprekar number");
                }
                else
                {
                    Console.WriteLine("not kaprekar number");
                }
        }

    }
}
