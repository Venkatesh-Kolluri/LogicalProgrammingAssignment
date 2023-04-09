using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
       public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int a = 0;

            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    a=a + i;
                    Console.WriteLine(a);
                }
            }
            if(num == a)
            {
                Console.WriteLine("It is a perfect Number");
            }
            else
            {
                Console.WriteLine("It is not a perfect Number");
            }
        }
    }
}
