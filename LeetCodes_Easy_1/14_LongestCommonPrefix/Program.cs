using System;
using System.Text.RegularExpressions;

namespace _14_LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14_LongestCommonPrefix");
            Console.WriteLine("Longest Prefix is {0}", LongestCommonPrefix(new string[] { "c", "acc", "ccc"}));
        }

        public static  string LongestCommonPrefix(string[] strs)
        {
            string prefixString = "";
            if (strs.Length > 0 ){
                for (int j = 0; j < strs[0].Length; j++)
                {
                    bool matchedAllWords = true;
                    for (int i = 1; i < strs.Length; i++)
                    {
                        int foundIndex = strs[i].ToLower().IndexOf(strs[0].Substring(0, strs[0].Length - j).ToLower());
                        if (foundIndex == -1 || foundIndex > 0)
                        {
                            matchedAllWords = false;
                        }
                    }
                    if (matchedAllWords)
                    {
                        prefixString = strs[0].Substring(0, strs[0].Length - j);
                        break;
                    }
                }
            }
            return prefixString;
        }
    }
}
