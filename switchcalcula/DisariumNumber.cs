using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class DisariumNumber
    {//WAP to check number is disarium or not 135=(1)^1+(3)^2+(5)^3
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0,rem=0,temp=num,sum=0;

            while (num > 0)
            {
                count++;
                num = num / 10;
                Console.WriteLine(num);
            }
           
                num = temp;
                while(num>0)
            {
                rem = num % 10;                     //5
                int pow = 1;                        //1
                for(int i=1;i<=count;i++)           //i=1;1<=3; i=2;2<=3; i=3;3<=3; i=4;4<=3
                {
                    pow = pow * rem;                //1*5  ; 5*5; 25*5
                }
                    sum=sum + pow;                  //0+125
                    count--;                        //2
                    num = num / 10;                 //13
            }
            if(sum==temp)
            {
                Console.WriteLine("Disarium number");
            }
            else
            {
                Console.WriteLine("Not an disarium number");
            }

            
         
        }
    }
}
