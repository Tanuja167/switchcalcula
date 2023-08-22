using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class EvenDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num=Convert.ToInt32(Console.ReadLine());
          


            while(num!=0)
            {
                int digit=num%10;
                num = num / 10;

                if(digit%2==0)
                {
                    Console.WriteLine(digit);
                    
                }
                

            }
        }
    }
}
