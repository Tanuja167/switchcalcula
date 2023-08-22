using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class exam2of3
    {
        static void Main(string[] args)
        {
            int sq = 1;
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    sq = i * i;
                    Console.WriteLine(sq);
                }
                else
                {
                    Console.WriteLine("-"+i);
                }
            }
        }
    }
}
