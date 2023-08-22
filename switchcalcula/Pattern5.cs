using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            //5
            //45
            //345
            //2345
            //12345
                for(int i=5;i>=1;i--)  //5
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine( );
            }
        }
    }
}
