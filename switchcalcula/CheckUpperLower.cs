using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class CheckUpperLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character");
            char c = Convert.ToChar(Console.ReadLine());

            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("Lowercase Letter");
            }
            else
            {
                Console.WriteLine("UpperCase Letter");
            }
        }
    }
}
