using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class PrimeUptoGiven_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n=Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            for( int num=1;num<=50;num++)
            {
                bool isprime = true;
                for(int i=2;i<num;i++)
                {
                    if(num%i==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime)
                {
                    cnt++;
                    Console.WriteLine(num);
                }
                if(cnt == n) 
                {
                    break;
                }
            }
        }
    }
}
