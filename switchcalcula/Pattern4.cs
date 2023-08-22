using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            
            for(char c='A';c<='E';c++)
            {
                for(char d='A';d<=c;d++)
                {
                    Console.Write(d);
                }
                Console.WriteLine();
            }
        }
    }
}
