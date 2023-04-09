using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Coupon
    {
        
       /* public static void Main(string[] args)
        {
            int a = 100000;
             couponCode(a);
             
        }*/
        static int value = 0;
        public static void couponCode(int a)
        {
            int j = 10;
           for(int i=1; i<j; i++)
            {
                Random random = new Random();
                int num = random.Next(a, 999999);
                if (num == j)
                {
                    Console.WriteLine("It is a duplicate random number");
                }
                else
                {
                    Console.WriteLine("The coupon number is: " + num);
                }
                 value = num;

            }
            
        }
    }
}
