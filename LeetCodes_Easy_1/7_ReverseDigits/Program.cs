using System;

namespace _7_ReverseDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversed integer is {0}",Reverse(321));
        }

        public static int Reverse(int x)
        {
           bool isNegative = false;
           int revint = 0;
            long revcompute = 0;
           int ndigits = x.ToString().Length;
            if (x.ToString().Substring(0,1) == "-")
            {
                ndigits = ndigits - 1;
                isNegative = true;
                if (x <= int.MinValue || x >= int.MaxValue)
                {
                    return 0;
                }
                x = -x;
            }
            for (int i = 0; i <= ndigits-1; i++)
            {
                long checkvalue = long.Parse(x.ToString().Substring(i, 1)) * long.Parse(Math.Pow(10.00, i).ToString());
                   
                revcompute = checkvalue + revcompute;
                if (revcompute >= int.MaxValue || revcompute <= int.MinValue)
                {
                    return 0;
                }
            }
            if (isNegative) revcompute = -revcompute;
            revint = (int)revcompute;
            return revint;
        }
    }
}
