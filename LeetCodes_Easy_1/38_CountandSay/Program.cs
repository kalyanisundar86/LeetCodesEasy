using System;
using System.Collections.Generic;

namespace _38_CountandSay
{
    class Program
    {

        /* The Problem
         The count-and-say sequence is the sequence of integers with the first five terms as following:

                1.     1
                2.     11
                3.     21
                4.     1211
                5.     111221
                1 is read off as "one 1" or 11.
                11 is read off as "two 1s" or 21.
                21 is read off as "one 2, then one 1" or 1211.

                Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence. You can do so recursively, in other words from the previous member read off the digits, counting the number of digits in groups of the same digit.

                Note: Each term of the sequence of integers will be represented as a string.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("38. Count and Say");
            int n = 1; // Number of members to print in the sequence
            Console.WriteLine(CountAndSay(n));
        }
        public static string CountAndSay(int n)
        {
            string number = "1"; // The first member is always 1

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(number);
                number = countnsay(number);
            }
            return number;
        }

        public static string countnsay(string curr)
        {
            string result = "";
            int i = 0;
            while (i < curr.Length)
            {
                int count = 1;
                while ((i + 1 < curr.Length) && (curr[i] == curr[i + 1]))
                {
                    i += 1;
                    count += 1;
                }
                result += (count.ToString() + curr[i]);
                i += 1;
            }
            return result;
        }
    }
}
