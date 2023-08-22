using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Each_DigitIsPrime
    {
        static void Main(string[] args)
        {
           // int cnt = 0;
            for (int num = 21; num <= 40; num++)
            {
                int cnt = 0;
                for (int j = 2; j <= num / 2; j++)
                {
                    if (num % j == 0)
                    {
                        cnt++;
                        break;
                    }
                }
                    if (cnt == 0)
                    {
                        Console.WriteLine(num);
                    }    
            }
            Console.ReadLine();
        }                   // Console.WriteLine
            
    }
 }

