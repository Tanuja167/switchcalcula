using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class ExpPower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power");
            int ex=Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for(int i=1;i<=ex;i++)
            {
                 result = result * num;
            }
            Console.WriteLine(result);

        }   
    }
}

//num=2
//pow=3
//r=2*1=2
//r=2*2=4
//r=3*2=6
