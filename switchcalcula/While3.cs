using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class While3
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=50)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
