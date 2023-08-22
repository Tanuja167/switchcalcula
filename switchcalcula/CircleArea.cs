using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class CircleArea
    {  //area of circle
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius of circle:");
            int r=Convert.ToInt32(Console.ReadLine());
            double area = 0;

            area = 3.14 * r * r;              
            Console.WriteLine(area);
            

        }
    }
}
