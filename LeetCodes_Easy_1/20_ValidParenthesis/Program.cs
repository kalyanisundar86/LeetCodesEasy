using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20. Valid Parenthesis");
            Console.WriteLine("String has valid parenthesis : {0}", IsValid("]").ToString());
        }

        public static bool IsValid(string s)
        {
            if (s.Length <= 0) return true;
            string stack = "";
            bool hasParenthesis = false;
            //check positions
            for (int i = 0; i < s.Length; i++)
            {
            hasParenthesis = true;
            switch (s.Substring(i, 1))
            {
                case "(": stack = stack.Trim() + "(";
                    break;
                case "[":
                    stack = stack.Trim() + "[";
                    break;
                case "{":
                    stack = stack.Trim() + "{";
                    break;
                case ")":
                    if ((stack.Length > 0) && (stack.Substring(stack.Length-1) == "("))
                    {
                            if (stack.Length > 0)  stack = stack.Remove(stack.Length - 1);
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case "]":
                    if ((stack.Length > 0) && (stack.Substring(stack.Length - 1) == "[") )
                    {
                            stack = stack.Remove(stack.Length - 1);
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case "}":
                    if ((stack.Length > 0) && (stack.Substring(stack.Length - 1) == "{"))
                    {
                            if (stack.Length > 0) stack = stack.Remove(stack.Length - 1);
                    }
                    else
                    {
                        return false;
                    }
                    break;
            }
        }
        return hasParenthesis && (stack.Trim().Length == 0);

        }
    }
}
