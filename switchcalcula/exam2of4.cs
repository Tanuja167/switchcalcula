using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class exam2of4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num,sum=0;

            while(num!=0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if(temp%sum==0)
            {
                Console.WriteLine("harshad number");
            }
            else
            {
                Console.WriteLine("not an harshad number");
            }
        }
    }
}
