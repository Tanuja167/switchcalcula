﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace switchcalcula
{
    internal class Table1To6
    {
        static void Main(string[] args)
        {
            int cal = 1;
            for(int i=1;i<=6;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    cal = j * i;
                    Console.WriteLine(cal);
                }
                Console.WriteLine( );
            }
            
        }
    }
}
