using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class FirstLastSum
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num, sum=0;
            while(num > 10)
            {
                num = num / 10;
            }
            int firstdigit = num;
            int lastdigit = temp % 10;
            sum = (firstdigit + lastdigit);
            Console.WriteLine(sum);
        }
    }
}
