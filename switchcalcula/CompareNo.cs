using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class CompareNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int no1=Convert.ToInt32(Console.ReadLine());
            int no2=Convert.ToInt32(Console.ReadLine());

            if (no1 > no2)
            {
                Console.WriteLine(no1 + "is greater");
            }
            else
            {
                Console.WriteLine(no2 +" is greater");
            }
        }
    }
}
