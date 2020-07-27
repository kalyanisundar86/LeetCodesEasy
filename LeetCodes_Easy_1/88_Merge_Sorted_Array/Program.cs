using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace _88_Merge_Sorted_Array
{
    class Program
    {
        /***
         * 
         * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

            Note:

            The number of elements initialized in nums1 and nums2 are m and n respectively.
            You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
         * 
         * **/
        static void Main(string[] args)
        {
            Console.WriteLine("88. Merge Sorted Array");
            int[] nums1 = new int[] { -12,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            int[] nums2 = new int[] { -49,-45,-42,-41,-40,-39,-39,-39,-38,-36,-34,-34,-33,-33,-32,-31,-29,-28,-26,-26,-24,-21,-20,-20,-18,-16,-16,-14,-11,-7,-6,-5,-4,-4,-3,-3,-2,-2,-1,0,0,0,2,2,6,7,7,8,10,10,13,13,15,15,16,17,17,19,19,20,20,20,21,21,22,22,24,24,25,26,27,29,30,30,30,35,36,36,36,37,39,40,41,42,45,46,46,46,47,48};
            int m =1;
            int n = 90;
            Merge(nums1, m, nums2, n);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> sList = new List<int>();
            int j=0;
            if (m == 0)
            {
                sList.AddRange(nums2);
            }
            else if (n == 0)
            {
                sList.AddRange(nums1);
            }
            else
            {
               int i = 0;
               while( i < m + n)
                {
                   if ((j < nums2.Length))
                    {
                        if ((nums1[i] < nums2[j]))
                        {
                            if (i < m)
                            { 
                                sList.Add(nums1[i]); i++; 
                            }
                            else
                            {
                                sList.Add(nums2[j]); i++;j++;
                            }
                        }
                        else if (nums1[i] == nums2[j]){
                            if (i < m) { sList.Add(nums1[i]); }
                            ; i++;
                            if (j<n) sList.Add(nums2[j]); 
                            j++;
                        }
                        else
                        {
                            sList.Add(nums2[j]); j++;
                        }
                    }
                    else 
                    {
                       sList.Add(nums1[i]);i++;
                    }
                }
            }
            
            int l = 0;
            while (l < m + n)
            {
                nums1[l] = sList[l];l++;
            }
        }
    }
}
