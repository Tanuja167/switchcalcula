using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class AvgOf_Factors
    {
        static void Main(string[] args)
        {
            int count = 0,sum=0;
            double avg;
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            avg = sum / count;
            Console.WriteLine(avg);

        }
    }
}
