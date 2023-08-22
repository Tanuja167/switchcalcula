using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class exam2of1
    {
        static void Main(string[] args)
        {
            Area a=new Area();
            a.area(20);
            Console.WriteLine(a.display());
            a.area(12, 23);
            Console.WriteLine(a.display());
            a.area(2.00, 6);
            Console.WriteLine(a.display());
            a.area(3.0, 7.0);
            Console.WriteLine(a.display());

        }
    }
    public class Area
    {
        private double result;
        public void area(double r)
        {
            result = 3.14 * r * r;
        }
        public void area(int side)
        {
            result = side*side;
        }
        public void area(double l, int b)
        {
            result = l*b;
        }
        public void area(double b, double h)
        {
            result = 0.5*b*h;
        }
        public string display()
        {
            return $"Area: {result}";
        }
    }
}
