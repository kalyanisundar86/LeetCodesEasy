using System;
using System.Linq;

namespace _67_AddBinary
{
    class Program
    {

        /**
         * Given two binary strings, return their sum (also a binary string).

            The input strings are both non-empty and contains only characters 1 or 0.

            Example 1:

            Input: a = "11", b = "1"
            Output: "100"
            Example 2:

            Input: a = "1010", b = "1011"
            Output: "10101"

        Constraints:

            Each string consists only of '0' or '1' characters.
            1 <= a.length, b.length <= 10^4
            Each string is either "0" or doesn't contain any leading zero.
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("67.  Add Binary");
            string binsum = AddBinary("11", "1");
        }

        public static string AddBinary(string a, string b)
        {
            string binsum = "";
            int i = a.Length-1;
            int j = b.Length-1;
            string carry = "0";

            // Make lengths the same
            if (i > j)
            {
                b = b.PadLeft(b.Length + i - j+1).Replace(' ', '0');
                j = b.Length - 1;
            }
            else
            {
                a = a.PadLeft(a.Length + j-i ).Replace(' ', '0');
                i = a.Length - 1;
            }
            while (j >=0 && i >=0 )
            {
                if ((a[i].ToString() == "1") && (b[j].ToString() == "1")){
                    if (carry == "0")
                    {
                        binsum = binsum + "0";
                        carry = "1";
                    }
                    else
                    {
                        binsum = binsum + "1";
                        carry = "1";
                    }
                }
                else if ((a[i].ToString() == "0") && (b[j].ToString() == "0"))
                {
                    if (carry == "0")
                    {
                        binsum = binsum + "0";
                    }
                    else
                    {
                        binsum = binsum + "1";
                    }
                    carry = "0";
                }
                else 
                {
                    if (carry == "0")
                    {
                        binsum = binsum + "1";
                        carry = "0";
                    }
                    else
                    {
                        binsum = binsum + "0";
                    }
                }
                i--;
                j--;
            }
            if (carry == "1") binsum = binsum + carry;
            char[] array = binsum.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
