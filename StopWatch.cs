using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgramming
{
    internal class Watch
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hello World!");
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: "+stopwatch.Elapsed);

        }
        
    }
}
