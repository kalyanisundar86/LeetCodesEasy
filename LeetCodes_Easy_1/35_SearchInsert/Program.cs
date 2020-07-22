using System;

namespace _35_SearchInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("35_SearchInsert");
            int[] nums = new int[4] { 1, 3, 5, 6};
            int target = 1;
            Console.WriteLine("Nearest index is {0}", SearchInsert(nums, target));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            bool bless = false;
            bool bcontinue = true;
            int insert = 0;
            int j = 0;
            int i = nums.Length / 2;
            while (i > 0 && i < nums.Length)
            {
                if (nums[i] == target) return i;
                if (nums[i] > target) { j = i;bless = true; } else {j = i + 1;}

                if (bless)
                {
                    j = i;
                   while(j >= 0)
                    {
                        if (nums[j] >= target)
                        {
                            insert = j;
                            break;
                        }
                        j--;
                    }
                    i--;
                }
                else
                {
                    j = i;
                    while (j <nums.Length )
                    {
                        if (nums[j] <= target)
                        {
                            insert = j;
                            break;
                        }
                        j++;
                    }
                    i++;
                }
            }
            if (i <= 0 && insert > 0 && insert < nums.Length) return insert;
            else
            {
                if (insert == nums.Length-1) return insert;
                else
                return 0;
            }
            if (i == nums.Length) return nums.Length;
            return insert;
        }
    }
}
