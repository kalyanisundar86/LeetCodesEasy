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


}
