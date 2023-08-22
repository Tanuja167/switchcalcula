using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class swapno2
    {
        static void Main(string[] args)
        {
            int no1, no2;
            Console.WriteLine("Enter two numbers:");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = Convert.ToInt32(Console.ReadLine());

            no1 = no1 + no2;
            no2 = no1 - no2;
            no1 = no1 - no2;
            Console.WriteLine("number after swapping");
            Console.WriteLine("first number is" + no1);
            Console.WriteLine("second number is" + no2);
        }
    }
}
