using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Max_Of_Three
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("Number one is greater");
                }
                else
                {
                    Console.WriteLine("Number Three is greater");
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("Number 2 is greater");
            }
            else
            {
                Console.WriteLine("Number Three is greater");
            }
        }
    }
}
