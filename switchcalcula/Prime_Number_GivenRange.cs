using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Prime_Number_GivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());


              for (int i = 1; i <= num; i++)      //1
              {
                  int count = 0;
                  for (int j = 2; j <= i/2; j++)                
                  {
                      if (i % j == 0)                   
                      {
                          count++;
                          break;
                      }

                  }

                  if (count == 0 && i != 1)
                  {
                      Console.WriteLine(i);
                  }


              }
          
            
            Console.ReadLine();   


        }
    }
}
