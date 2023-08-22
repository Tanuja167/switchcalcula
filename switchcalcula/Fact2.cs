using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Fact2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact = 1, sum=0,rem=0;

            
                /*for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                    sum = sum + fact;
                 }
                Console.WriteLine("Factorial of number: "+fact);
                
                Console.WriteLine("sum is: "+sum); */

            while(num>0)                          //123    12
            {
                rem = num % 10;                    //3
                for (int i = 1; i <= rem; i++)        //i=1;i<=rem;  i=2;2<=3; i=3;3<=3
                {
                    fact = fact * i;                   //fact=1*1; 1*2=2;  1*3=3;
                    sum = sum + fact;                  //sum=1, 1+2=3,  
                    
                }
                num = num / 10;
            }
            
            Console.WriteLine("Factorial is" + fact);
                
            }
                
            
        }
    }

