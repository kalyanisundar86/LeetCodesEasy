using System;

namespace _28_Implement_strstr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("28. Implement Strstr()");
            string haystack = "hello"; string needle = "ll";
            Console.WriteLine("Needle in haystack at {0}", StrStr(haystack, needle));
        }
        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
