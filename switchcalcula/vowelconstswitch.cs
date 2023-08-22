using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class vowelconstswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character:");
            char c = Convert.ToChar(Console.ReadLine());


            switch (c)
            {
                case 'a':
                case 'A':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':


                    Console.WriteLine("Entet charecter is vowel");
                    break;
                default:
                    Console.WriteLine("Enter character is constant");
                    break;
            

            }
        }
    }
}
    

