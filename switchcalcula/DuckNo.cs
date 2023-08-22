using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class DuckNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());  //101
            int temp = num;
            int digit = 0,count=0;

            while (num != 0)           //101!=0
            {
                digit = num % 10;          //rem=1
                num = num / 10;          //10
                if (digit == 0)
                {
                    count++;

                }
            }
            if (count > 0)
            {
                Console.WriteLine("Duck number");
            }
            else
            {
                Console.WriteLine("not duck number");
            }
            
        }
    }
}
