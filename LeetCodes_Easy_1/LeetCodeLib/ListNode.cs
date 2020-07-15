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
