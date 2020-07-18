using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] retindices = new int[2];
            int target = 6;// 9;
            int n = 3;// 4;
            int[] numbers = new int[3] { 3,2,4 };
            retindices = TwoSum1(numbers, 6);
            Console.WriteLine("Index 1 = {0}, Index 2 = {1}",retindices[0], retindices[1] );
        }

        public static int[] TwoSum(int[] nums, int target)
        { 
            int[] retindices = new int[2] { -1, -1 };
            int n = nums.Length;
            Dictionary<int, int> listkeyreverse = new Dictionary<int, int>();
            // Add to dictionary
            for (int i = 0; i < n; i++)
            {
                listkeyreverse.TryAdd(nums[i], i + 1);
            }
            for (int i = 0; i < n; i++)
            {
                int x = nums[i];
                if ((target - x) != nums[i])
                {
                    if (listkeyreverse.TryGetValue(target - x, out int second))
                    {
                        retindices[0] = i;
                        retindices[1] = second - 1;
                        break;
                    };
                }
                else
                {
                    if (retindices[0] == -1) retindices[0] = i;
                    retindices[1] = i;
                }
            };
            return retindices;
        }
    }
}
