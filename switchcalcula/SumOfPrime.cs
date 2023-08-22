using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class SumOfPrime
    {
        static void Main(string[] args)
        {
            int count = 0, sum = 0;
            for(int i=1;i<=20;i++)
            {
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        sum = sum + i;
                        Console.WriteLine(sum);


                    }
                    
                }
                
            }
            


        }
    }
}
