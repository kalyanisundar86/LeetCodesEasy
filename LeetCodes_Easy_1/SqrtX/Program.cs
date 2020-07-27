using System;
using System.Net.Http.Headers;

namespace SqrtX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("69. Sqrt(x)");
            int x = 8;
            Console.WriteLine(MySqrt(x).ToString());
        }

        public static int MySqrt1(int x)
        {
            double sqrtx = Math.Sqrt((double)x);
            return (int)sqrtx;
        }

        public static int MySqrt(int x)
        {
            // Base cases 
            if (x == 0 || x == 1)
                return x;

            // Staring from 1, try all 
            // numbers until i*i is  
            // greater than or equal to x. 
            int i = 1, result = 1;

            while (result <= x)
            {
                i++;
                result = i * i;
            }
            return i - 1;
        }
    }
}
