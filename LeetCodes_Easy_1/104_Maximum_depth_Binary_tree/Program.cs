using LeetCodeLib;
using System;
using System.Runtime.InteropServices;

namespace _104_Maximum_depth_Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("104. Maximum depth of binary tree");
            TreeNode thetree = new TreeNode(1);
            TreeNode nextNode = new TreeNode(3);
            TreeNodeFunctions.InsertNodeAfter(nextNode, thetree);
            int d = MaxDepth(thetree);
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            else
            {
                int left = (root.left != null)? MaxDepth(root.left):0;
                int right = (root.right != null) ? MaxDepth(root.right) : 0;
                return (1 + ((left > right)?left:right));
            }

        }
    }
}
