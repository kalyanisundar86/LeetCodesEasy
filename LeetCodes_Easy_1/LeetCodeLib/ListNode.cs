using System;

namespace LeetCodeLib
{
    public static class ListNodeFunctions
    {
        public static void AddEndNode(ListNode list, ListNode node)
        {
            while (list.next != null)
            {
                list = list.next;
            }
            list.next = node;
        }

        public static ListNode Find(ListNode list, int n)
        {
            while (list.next != null)
            {
                if (list.val == n)
                {
                    return list;
                }
            }
            return null;
        }

        public static void RemoveNodeAt(ListNode list, ListNode nodeToRemove)
        {
            ListNode ln = list;
            ListNode prev = list;
            while(ln != null)
            {
                if (ln == nodeToRemove)
                {
                    prev.next = ln.next;
                }
                prev = ln;
                ln = ln.next;
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
     }
      public class TreeNode
      {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
          {
            this.val = val;
            this.left = left;
            this.right = right;
          }
      }

    public static class TreeNodeFunctions
    {
        public static void InsertNodeBefore(TreeNode nodeToInsert, TreeNode insertionNode)
        {
            TreeNode oldLeft = insertionNode.left;
            insertionNode.left.right = nodeToInsert;
            insertionNode.left = nodeToInsert;
            nodeToInsert.left = oldLeft;
            nodeToInsert.right = insertionNode;
        }

        public static void InsertNodeAfter(TreeNode nodeToInsert, TreeNode insertionNode)
        {
            TreeNode oldright = insertionNode.right;
            insertionNode.right.left= nodeToInsert;
            insertionNode.right =nodeToInsert;
            nodeToInsert.right= oldright;
            nodeToInsert.left = insertionNode;
        }
        public static bool IsSameNode(TreeNode n1, TreeNode n2)
        {
            return (n1.val == n2.val) ? true : false;
        }
    }

}
