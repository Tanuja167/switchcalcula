using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Positive_Negative_Zero
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
        }
    }
}
