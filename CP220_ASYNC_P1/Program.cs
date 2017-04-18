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
                data[i] = extender.Fib_MD(i);
                sw.Stop();
                time[i] = sw.Elapsed.TotalMilliseconds;
            }
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[i] + " ms");
            }
            Console.ReadKey();
            Console.Clear();
            Array.Clear(data, 0, data.Length);
            Array.Clear(time, 0, time.Length);

            sw.Start();
            Parallel.For(0, data.Length, i => data[i] = work.Fib_DK(i));
            sw.Stop();
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[i] + " ms");
            }
            Console.ReadKey();
        }
    }
}
