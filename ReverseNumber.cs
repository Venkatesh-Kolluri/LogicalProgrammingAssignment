using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number to be reversed: ");
            num=Convert.ToInt32(Console.ReadLine());

            int result = rev(num);

            Console.WriteLine(result);
        }
        public static int rev(int num)
        {
            int ans = 0;

            for(int i=num; i > 0; i/=10)
            {
                int rem = i % 10;
                ans=10*ans+rem;
                
            }
            return ans;
        }
    }
}
