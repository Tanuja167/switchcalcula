using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Forfact
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter any number:");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial of number is: " + fact);
        }
    }
}
