using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace CP220_ASYNC_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            long[] data = new long[10];
            long[] time = new long[10];

            for(int i = 0; i < 10; i++)
            {
                sw.Start();
                if(sw.IsRunning == true)
                {
                    data[i] = Fib(i);
                    sw.Stop();
                    time[i] = sw.ElapsedMilliseconds;
                }
                else
                {
                    Console.WriteLine("Stopwatch Failed To Start");
                }
            }

            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 0; i < time.Length; i++)
                {
                    Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[j] + " ms");
                }
            }
            Console.ReadKey();
        }
        public static long Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fib(n - 2) + Fib(n - 1);
        }
    }
}
