using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP220_ASYNC_P1
{
    public class extender
    {
        public static long Fib_MD(int n)
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
