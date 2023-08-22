using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class ProductDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int mul = 1;

            while(num>0)
            {
                int rem = num % 10;
                mul = mul * rem;
                num = num / 10;
            }
            Console.WriteLine(mul);
        }
    }
}
