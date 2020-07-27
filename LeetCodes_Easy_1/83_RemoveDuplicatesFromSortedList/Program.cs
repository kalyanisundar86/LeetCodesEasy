using LeetCodeLib;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _83_RemoveDuplicatesFromSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("83. Remove Duplicates from Sorted List");
            ListNode l1 = new ListNode(1, null); ListNodeFunctions.AddEndNode(l1, new ListNode(1, null)); ListNodeFunctions.AddEndNode(l1, new ListNode(2, null));
            ListNodeFunctions.AddEndNode(l1, new ListNode(3, null)); ListNodeFunctions.AddEndNode(l1, new ListNode(3, null));
            ListNode result = DeleteDuplicates(l1);
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode ln = head;
            Hashtable availValues = new Hashtable();
            while (ln != null)
            {
                if (availValues.ContainsValue(ln.val))
                {
                    //its a duplicate remove
                    ListNodeFunctions.RemoveNodeAt(head, ln);
                }
                else
                {
                    availValues.Add(ln.val, ln.val);
                }
                ln = ln.next;
            }
            return head;
        }
    }
}
