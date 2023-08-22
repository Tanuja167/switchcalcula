using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class forsumodd1to10
    {
        
        
        static void Main(string[] args)
        {
            /** Console.WriteLine("enter number");
             int num=Convert.ToInt32(Console.ReadLine());

             int sum = 0;
             for (int i=0; i<=num; i++)
             {
                 if (i % 2 != 0)
                 {
                     sum = sum + i;
                 }
             }
             Console.WriteLine(sum);**/
            //Console.WriteLine("enter number");
            //int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum); 
        }

    }
}
