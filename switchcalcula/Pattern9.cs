using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern9
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=8;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j==1 || i == 8 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    { 
                    Console.Write(" ");
                    }
                }
                    Console.WriteLine();
            }
            //Console.WriteLine();

        }
    }
}
