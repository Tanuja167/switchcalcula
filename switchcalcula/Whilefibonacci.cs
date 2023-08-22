using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Whilefibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=(Convert.ToInt32(Console.ReadLine()));
            int no1 = 0, no2 = 1;
            int i = 2;
            while( i<=num)
            {
                int f = no1 + no2;
                Console.WriteLine(f);
                no1 = no2;
                no2 = f;
                i++;
            }
        }
          

    }
}
