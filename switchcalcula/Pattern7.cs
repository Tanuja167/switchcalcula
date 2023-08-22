using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern7
    {
        static void Main(string[] args)
        {
            //   A
            //  BA
            // CBA
            //DCBA
            for(char i='A';i<='D';i++)
            {
                for(char j='D';j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(char k='A';k<=i;k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}
