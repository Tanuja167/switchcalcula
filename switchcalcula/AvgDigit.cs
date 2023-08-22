using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class AvgDigit
    { //WAP to calculate avg of digits in no.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0,count=0;
            
             while (num > 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                count++;
                num = num / 10;
                
            }
            Console.WriteLine("sum of digit is"+sum);
            double avg=sum/count;
            Console.WriteLine("Total number of digits are"+count);
            Console.WriteLine("average of digit :"+avg);
            
        }
    }
}
