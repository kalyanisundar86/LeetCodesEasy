using System;
using System.Globalization;
using System.Net.Mime;
using System.Numerics;

namespace _66_PlusOne
{
    class Program
    {
        /*
         * Given a non-empty array of digits representing a non-negative integer, increment one to the integer.

            The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.

            You may assume the integer does not contain any leading zero, except the number 0 itself.

            Example 1:

            Input: [1,2,3]
            Output: [1,2,4]
            Explanation: The array represents the integer 123.
            Example 2:

            Input: [4,3,2,1]
            Output: [4,3,2,2]
            Explanation: The array represents the integer 4321.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("66_PlusOne");
            int[] digits = {7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7};
            digits = PlusOne1(digits);
        }
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            digits[n - 1] += 1;
            int carry = digits[n - 1] / 10;
            digits[n - 1] = digits[n - 1] % 10;
            for (int i = n - 2; i >= 0; i++)
            {
                if (carry == 1)
                {
                    digits[i] += 1;
                    carry = digits[i] / 10;
                    digits[i] = digits[i] % 10;
                }
            }
            if (carry == 1)
            {
                Array.Resize(ref digits, n + 1);
                digits[0] = carry;
            }
            return digits;
        }
        public static int[] PlusOne1(int[] digits)
        {
            BigInteger toadd = 0;
            BigInteger arraynum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                toadd = (BigInteger)Math.Pow(10, digits.Length - 1 - i) * (BigInteger)digits[i];
                if (i == digits.Length - 1)
                {
                    toadd++;
                }
                arraynum = arraynum + toadd;
            }
            string snum = arraynum.ToString();
            Array.Resize(ref digits, snum.Length);
            for (int i = 0; i < snum.Length; i++)
            {
                digits[i] = int.Parse(snum[i].ToString());
            }
            return digits;
        }
    }
}
