using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: Assignment 4 - Fibonacci Timing
    Class: CP220 - OOP II
    Destription: Fibonacci Timing Application
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P1
{
    public class extender
    {
        //Both Fib Methods Work Interchangably

        //Fib Method from Stackoverflow
        public static long Fib_MD(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        //Daniel's Fib Method
        public static long Fib_DK(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fib_DK(n - 2) + Fib_DK(n - 1);
        }

    }
}
