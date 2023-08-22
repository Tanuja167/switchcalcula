using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class DimondPattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i=1;i<=2;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();




            }
            
        }
    }
}
