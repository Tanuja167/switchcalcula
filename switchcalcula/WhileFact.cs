using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhileFact
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("factorial is :"+fact);

        }
    }
}
