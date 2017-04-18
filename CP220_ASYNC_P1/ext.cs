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

    public class work
    {
        private static int idx = 0;
        public static int Index
        {
            get { return idx++; }
        }
        public static long Fib_DK(int n)
        {
            //0,1,1,2,3,5,8,13,21,34,55,…
            if (n == 0 || n == 1)//satisfaction condition
                return n;
            return Fib_DK(n - 2) + Fib_DK(n - 1);
        }
        public static void WorkIt(int ValueToWorkWith, int[] intArray, int indexToWriteAt)
        {
            intArray[indexToWriteAt] = (int)Fib_DK(ValueToWorkWith);
        }
    }

}
