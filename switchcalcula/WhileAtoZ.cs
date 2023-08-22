using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhileAtoZ
    {
        static void Main(string[] args)
        {
            char c= 'a';
            while(c<='z') 
            {
                Console.WriteLine(c);
                c++;
            }
        }
    }
}
