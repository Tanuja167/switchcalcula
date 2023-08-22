using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Exam
    {
        static void Main(string[] args)
        {
            /*int num = 1034,count=0, sum=0;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
                if(count==1 || count==4)
                {
                    sum = sum + digit;
                    Console.WriteLine(sum);
                }

            }*/
            /*int i, j;
            for( i=1, j=i;i<=3 && j>=0; i++, j--)
            {
                if(i==j)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine( j);
                }
            }*/

            int[] a = { 1, 2, 3, 4, 5 };
            fun(a);
            Console.ReadLine();
        }
        static void fun(params int[] b)
        {
            int[] k = { 3, 4, 7, 8, '\0' };
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] + k[i];
                Console.WriteLine(b[i] + " ");
            }
        }



    }
}
