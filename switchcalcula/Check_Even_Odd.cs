using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Check_Even_Odd
    {
        //check entered no is even or odd.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even number");
                    break;

                default:
                    Console.WriteLine("Odd Number");
                    break;

            }
            /**  if(num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            } **/
        }
    }
}



