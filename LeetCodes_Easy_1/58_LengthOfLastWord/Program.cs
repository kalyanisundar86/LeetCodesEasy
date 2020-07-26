using System;

namespace _58_LengthOfLastWord
{
    class Program
    {
        /*
         * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word (last word means the last appearing word if we loop from left to right) in the string.

            If the last word does not exist, return 0.

            Note: A word is defined as a maximal substring consisting of non-space characters only.

            Example:

            Input: "Hello World"

            Output: 5
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("58. Length of Last Word");
            Console.WriteLine($"Length of last word is {LengthOfLastWord("Hello World").ToString()}");
        }

        public static int LengthOfLastWord(string s)
        {
            string[] sarray = s.Split(' ');
            for (int i = sarray.Length - 1; i >= 0; i--)
            {
                if (sarray[i].Trim().Length > 0)
                {
                    return sarray[i].Length;
                }
            }
            return 0;
        }
    }
}
