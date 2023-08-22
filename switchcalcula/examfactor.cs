using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class examfactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0, fact=1, sum=0, avg=0;
            while(num > 0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;

                for(int i=1;i<=num;i++)
                {
                    fact = fact * i;
                    sum = sum + fact;
                }

            }
            avg = sum / count;
            Console.WriteLine(avg);

        }
    }
}
