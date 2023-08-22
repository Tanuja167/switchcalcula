using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Reactangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth");
            int l=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());

            int p=2*(l+b);
            Console.WriteLine("Perimeter of reactangle: "+p);
        }
    }
}
