using LeetCodeLib;
using System;

namespace _101_Symmetric_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100 Symmetric Tree");
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;
            else
            {
                if ((root.left != null) && (root.right != null) )
                {
                    if (root.right.val == root.left.val)
                    {
                        return isMirror(root.right,root.left);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool isMirror(TreeNode node1,
                  TreeNode node2)
        {
            // if both trees are empty,  
            // then they are mirror image  
            if (node1 == null && node2 == null)
                return true;

            // For two trees to be mirror images,  
            // the following three conditions must be true  
            // 1 - Their root node's key must be same  
            // 2 - left subtree of left tree and right subtree  
            //       of right tree have to be mirror images  
            // 3 - right subtree of left tree and left subtree  
            //       of right tree have to be mirror images  
            if (node1 != null && node2 != null &&
                node1.val == node2.val)
                return (isMirror(node1.left, node2.right) &&
                        isMirror(node1.right, node2.left));

            // if neither of the above conditions  
            // is true then root1 and root2 are 
            // mirror images  
            return false;
        }
    }
}
