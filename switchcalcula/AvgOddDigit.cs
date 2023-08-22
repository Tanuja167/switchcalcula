using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class AvgOddDigit
    { //WAP to calculate average of odd digit in number.
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem = 0, sum=0, count=0;
            double avg=0;

            while(num!=0)
            {
                rem = num % 10;
                num = num / 10;
                if(rem%2!=0)
                {
                    sum = sum + rem;
                    count++;
                    avg = sum / count;
                }
            }
            Console.WriteLine("sum of number is :"+sum);
            Console.WriteLine("total number of odd digits are :"+count);
            Console.WriteLine("Average is :"+avg);
        }
    }
}
