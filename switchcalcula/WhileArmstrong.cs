using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhileArmstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while(num!=0)
            {
                int rem = num % 10;
               
                sum=sum+(rem*rem*rem);
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }
        }
    }
}
