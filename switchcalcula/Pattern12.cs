using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern12
    {
        static void Main(string[] args)
        {
            //10101
            //01010
            //10101
            //01010

            /** for(int i=1;i<=5;i++)
             {
                 for(int j=1;j<=5;j++)
                 {
                     if(i==j || i%2!=0 && j%2!=0 || (i == 4 && j == 2) || (j == 4 && i == 2))
                     {
                         Console.Write("1");
                     }
                     else
                     {
                         Console.Write("0");
                     }
                     
                 }

                 Console.WriteLine();
             }**/
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }
                    }
                }
                else
                {
                   for(int j=1;j<=5; j++)
                    {
                        if(j % 2 == 0)
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                   // Console.WriteLine();
                }
                Console.WriteLine();
            }
            }

        }
    }

