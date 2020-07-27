using System;
using System.Threading;

namespace _70_Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("70 Climbing Stairs");
            int n = 6;
            Console.WriteLine(ClimbStairs(n).ToString());
        }

        public static int ClimbStairs(int n)
        {

            int [] series = new int[2] { 1, 2 };
            int sum = 2;
            if (n == 1) return 1;
            if (n == 2) return 2;
            
            for (int i = 2; i <n; i++)
            {
                sum = series[0] + series[1];
                series[0] = series[1];
                series[1] = sum;
            }
            return series[1] ;
        }
    }
}
