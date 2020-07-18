using System;

namespace _27_Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("27. Remove Element");
            int[] nums = new int[2] ;
            int val = 3;
            Console.WriteLine("Length of resultant array {0}", RemoveElement(nums, val));
        }
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length <= 0) return 0;
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }
    }
}
