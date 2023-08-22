using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class test
    {
        static void Main(string[] args)
        {
            /**  Console.WriteLine("enter three numbers");
              int num1=Convert.ToInt32(Console.ReadLine());
              int num2=Convert.ToInt32(Console.ReadLine());
              int num3=Convert.ToInt32(Console.ReadLine());

              if (num1 > num2)
              {
                  if (num1 > num3)
                  {
                      Console.WriteLine("number1 is greater");
                  }
                  else
                  {
                      Console.WriteLine("num 3 is grater");
                  }
              }
              else if(num2 > num3)
              {
                  Console.WriteLine( "number 2 is greater");
              }
              else
              {
                  Console.WriteLine("number three is largest");  
              }**/
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                sum =sum+i;
            }
            
            Console.WriteLine(sum);

        }
    }
}
