﻿namespace learn
{
    internal class CompoundInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time Period :");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate:");
            int r = Convert.ToInt32(Console.ReadLine());
            double ci = 0;

            ci = p * (1 + r / 100) ^ t;
            Console.WriteLine("compound interest:" + ci);
        }
    }
}