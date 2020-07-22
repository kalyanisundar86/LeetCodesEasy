using System;

namespace _53_MaximumSubArray
{
    class Program
    {
        /*
         * Given an integer array nums, find the contiguous subarray (containing at least one number) which 
         * has the largest sum and return its sum.
         * Example:

            Input: [-2,1,-3,4,-1,2,1,-5,4],
            Output: 6
            Explanation: [4,-1,2,1] has the largest sum = 6.

            Sum (A[x]) where x = 1<i<j<n, and n is the number of elements in the array.

            https://en.wikipedia.org/wiki/Maximum_subarray_problem#:~:text=If%20the%20array%20contains%20all,%2C%20if%20it%20is%20permitted).

        Kadane's algorithm scans the given array A[1...n] from left to right. 
        In the jth step, it computes the subarray with the largest sum ending at j;this sum is maintained in variable current_sum
        Moreover, it computes the subarray with the largest sum anywhere in A[1...j], 
        maintained in variable best_sum and easily obtained as the maximum of all values of current_sum seen so far,
        
        As a loop invariant, in the jth step, the old value of current_sum holds the maximum over all 
         i in {1,...,j} of the sum A[i]+...+A[j-1]
        Therefore, current_sum +A[j] is the maximum over all i in {1,...,j} of the sum  A[i]+...+A[j]. 
        To extend the latter maximum to cover also the cas i=j+1, it is sufficient to consider also the empty subarray A[j+1\;...\;j]
        This is done in line 6 by assigning {\displaystyle \max(0,}{\displaystyle \max(0,}current_sum{\displaystyle +A[j])}{\displaystyle +A[j])} as the new value of current_sum, which after that holds the maximum over all {\displaystyle i\in \{1,...,j+1\}}{\displaystyle i\in \{1,...,j+1\}} of the sum {\displaystyle A[i]+...+A[j]}{\displaystyle A[i]+...+A[j]}.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("53. Maximum Subarray");
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine("Largest subarray sum is {0}", MaxSubArray(nums).ToString());
        }
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int best_sum =int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (best_sum < sum)
                {
                    best_sum = sum;
                }
                if (sum < 0) { sum = 0; }
            }
            return best_sum;
        }
    }
}
