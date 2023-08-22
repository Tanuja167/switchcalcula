using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class swap
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("numbers after swapping");
            Console.WriteLine("First number" + a);
            Console.WriteLine("Second number" + b);

        }
    }
}
