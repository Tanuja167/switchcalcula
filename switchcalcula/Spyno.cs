﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Spyno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0, mul=1;

            
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                mul = mul * rem;
                num = num / 10;

            }
            if(sum==mul)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("not spy number");
            }
           
        }
    }
}
