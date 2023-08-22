using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
namespace switchevenodd
{
    internal class switchcalculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter choice");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}**/
