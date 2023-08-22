using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class For5
    {//display number which is divisible by 3
        static void Main(string[] args)
        {
            for(int i=1;i<=30;i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("Numbers Divisible by 3: "+i);
                }
            }
        }
    }
}
