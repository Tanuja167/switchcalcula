using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Automorphic_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());   

            int sq = num * num;
            Console.WriteLine(sq);
           if(num%10==sq%10)
            {
                Console.WriteLine("Atomorphic number");
            }
            else
            {
                Console.WriteLine("not atomorphic number");
            }
        }
    }
}
