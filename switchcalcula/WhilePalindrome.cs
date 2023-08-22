using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class WhilePalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;


            while (num != 0)
            {
                int rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("number after reverse:"+rev);
            if(temp==rev)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }
            
       }
    }
}
//123
//rem=3
//rev=0*10+3=3
//num=12
//3
//rev=3*10+2=32
//num=1
//32


