using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

/*
    Project: Assignment 4 - Fibonacci Timing
    Class: CP220 - OOP II
    Destription: Fibonacci Timing Application
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Creation
            Stopwatch sw = new Stopwatch();

            //Array Creation
            long[] data = new long[36];
            double[] time = new double[36];

            //For Loop
            //Timer Starts -> Fills Data Array With Fib Data
            //Timer Stops ->  Fills Time Array with Millisecond Data
            for (int i = 0; i < data.Length; i++)
            {
                sw.Start();
                data[i] = extender.Fib_DK(i);
                //data[i] = extender.Fib_MD(i);
                sw.Stop();
                time[i] = sw.Elapsed.TotalMilliseconds;
            }

            //Data Output
            Console.WriteLine("===== PART 1: A =====");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[i] + " ms");
            }

            Console.ReadKey();

            //Clear Arrays For Part B
            Console.Clear();
            Array.Clear(data, 0, data.Length);
            Array.Clear(time, 0, time.Length);

            //Parallel For Executes Same Code As Part A
            Parallel.For(0, data.Length, i => 
            {
                sw.Start();
                data[i] = extender.Fib_MD(i);
                sw.Stop();
                time[i] = sw.Elapsed.TotalMilliseconds;
            });

            //Data Output
            Console.WriteLine("===== PART 1: B =====");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Fib(" + i + ") = " + data[i] + " in " + time[i] + " ms");
            }

            Console.ReadKey();
        }
    }
}
