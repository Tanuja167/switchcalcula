using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhileFactorNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
          

            int i = 1;
            while(i<=num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
               
                i++;
                

                
               
                    
            }
        }
    }
}

//num=12
//
