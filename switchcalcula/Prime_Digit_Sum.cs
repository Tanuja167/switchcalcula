using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Prime_Digit_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int a = 0;
             
            while(num>0)                   //4362
            {
                int digit = num % 10;        //3

                for (int i = 2; i < digit; i++)      //i=2;2<30     
                {
                    if (digit % i == 0)
                    {
                        a = 1;
                        break;
                    }   
                }


                    if (a == 0)
                    {
                        Console.WriteLine(digit);
                        
                    }
                num = num / 10;

            }
            
        }
    }
}
