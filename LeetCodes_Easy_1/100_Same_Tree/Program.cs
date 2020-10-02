using System;
using LeetCodeLib;

namespace _100_Same_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100 Same Tree");

        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null) && (q == null)) return true;
            if ((p !=null) && q != null)
            {
                if ((p.val == q.val) && IsSameTree(p.left,q.left ) && IsSameTree(p.right, q.right))return true;
            }
            return false;
        }
    }
}
