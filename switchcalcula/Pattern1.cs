using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            //5
            //54
            //543
            //5432
            //54321
           for (int i = 5; i >=1 ; i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
         
        }
        
    }
}
