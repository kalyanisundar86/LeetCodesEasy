using System;
using System.Collections.Generic;
using System.Globalization;

namespace _26_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("26 Remove duplicates from a Sorted Array");
            int[] nums = new int[1];
            Console.WriteLine("Unique elements array length {0}", RemoveDuplicates(nums).ToString());
        }
        public static int RemoveDuplicates(int[] nums)
        {

            int i = 1;
            int j = 1;
            if ((nums.Length > 1) )
            {
                while (i < nums.Length)
                {
                    if (nums[i - 1] == nums[i])
                    {
                        i = i + 1;
                    }
                    else
                    {
                        if (nums[j - 1] < nums[i])
                        {
                            nums[j] = nums[i]; j++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                if (j < nums.Length) nums[j] = 0;

            }
            else
            {
                if (nums.Length < 2)  j = nums.Length;
                else
                {
                    j = nums.Length - 1;
                }
            }
            return j;

        }
        public static int RemoveDuplicates1(int[] nums)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!intList.Contains(nums[i])){
                    intList.Add(nums[i]);
                }
            }
            return intList.Count;
        }
    }
}
