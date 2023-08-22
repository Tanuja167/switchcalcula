using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class NoOdd1to20
    {
        static void Main(string[] args)

        {
            int count = 0;
            for (int i=1; i<=20;i++)
            {
                if(i%2!=0)
                {
                    count++; 
                }
            }
            Console.WriteLine("number of odd numbers from 1 to 20: "+count);
        }
    }
}
