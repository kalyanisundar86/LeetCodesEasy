using System;
using System.Linq;

namespace _9_IsPalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. IsPalindrome Number");
            Console.WriteLine("Is Number a Palidrome : {0}", IsPalindromeNumber(12321));
        }

        public static bool IsPalindromeNumber(int x)
        {
            if (x < 0)
            {
                //negative number is never a palindrome
                return false;
            }
            else
            {
                string sX = x.ToString();
                int len = sX.Length;
                int mid = sX.Length / 2;
                string firsthalf = firsthalf = sX.Substring(0, mid);
                string secondhalf = "";
                if (len % 2 == 0)
                {
                    secondhalf = new string(sX.Substring(mid).ToCharArray().Reverse().ToArray()); 
                }
                else
                {
                    secondhalf = new string(sX.Substring(mid + 1).ToCharArray().Reverse().ToArray());
                };

                return (firsthalf == secondhalf) ? true : false;
            };
        }
    }
}
