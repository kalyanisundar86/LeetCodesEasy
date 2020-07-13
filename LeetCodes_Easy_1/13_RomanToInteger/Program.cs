using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _13_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13_RomanToInteger!");
            Console.WriteLine("Roman turns to {0}", RomanToInt("XXCII"));
        }

        public static int RomanToInt(string s)
        {
            int retValue = 0;
            if (isRoman(s))
            {
                 int newValue = 0;
                Dictionary<string, int> romanMap = new Dictionary<string, int>();
                romanMap.Add("I", 1);
                romanMap.Add("V", 5);
                romanMap.Add("X", 10);
                romanMap.Add("L", 50);
                romanMap.Add("C", 100);
                romanMap.Add("D", 500);
                romanMap.Add("M", 1000);
                romanMap.Add("P", 4); // IV
                romanMap.Add("Q", 9); // IX
                romanMap.Add("R", 40); //XL
                romanMap.Add("S", 90);  //XC
                romanMap.Add("T", 400); // CD
                romanMap.Add("U", 900);  //CM

                // input string substitution

                s = s.ToUpper().Replace("IV", "P");
                s = s.ToUpper().Replace("IX", "Q");
                s = s.ToUpper().Replace("XL", "R");
                s = s.ToUpper().Replace("XC", "S");
                s = s.ToUpper().Replace("CD", "T");
                s = s.ToUpper().Replace("CM", "U");

                for (int i = 0; i < s.Length; i++)
                {
                    romanMap.TryGetValue(s[i].ToString(), out newValue);
                    retValue = retValue + newValue;
                }
            }
            return retValue;
        }

        public static bool isRoman(String s)
        {
            Regex r = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})");
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                return r.Match(s).Success ?  true : false;
            }
        }
    }
}
