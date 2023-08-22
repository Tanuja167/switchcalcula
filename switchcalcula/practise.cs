using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class practise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int sq = num * num;
            if(num%10==sq%10)
            {
                Console.WriteLine("automorphic");
            }
            else
            {
                Console.WriteLine("not automorphic");
            }
        }
    }
}
