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
            long[] data = new long[36];
            double[] time = new double[36];
            for (int i = 0; i < data.Length; i++)
            {
                sw.Start();
                data[i] = Fib(i);
                sw.Stop();
                time[i] = sw.Elapsed.TotalMilliseconds;
            }
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[i] + " ms");
            }
            Console.ReadKey();
        }
        public static long Fib(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
