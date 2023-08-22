using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class KrishanMurtino
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num=Convert.ToInt32(Console.ReadLine());  //145
            int rem = 0,  sum = 0, temp=num ;

            while (num != 0)
            {
                rem = num % 10;
                int fact = 1;
             for(int i=1;i<=rem;i++)
                {
                    fact = fact * i;
                }
                sum=sum+ fact;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("krishanmurti number");
            }
            else
            {
                Console.WriteLine("not krishanmurti number");
            }



        }
        
    }
}
