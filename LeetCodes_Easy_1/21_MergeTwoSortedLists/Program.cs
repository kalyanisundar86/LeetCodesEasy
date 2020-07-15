using LeetCodeLib;
using System;
using System.Collections.Generic;

namespace _21_MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("21 Merge Two Sorted Lists");
            ListNode l1, l2;
            //l1 = new ListNode(43, null);ListNodeFunctions.AddEndNode(l1, new ListNode(45, null)); ListNodeFunctions.AddEndNode(l1, new ListNode(49, null));
            //l2 = new ListNode(1, null); ListNodeFunctions.AddEndNode(l2, new ListNode(6, null)); ListNodeFunctions.AddEndNode(l2, new ListNode(8, null));
            l1 = null;
            l2 = new ListNode(0, null);
            PrintList(l1);PrintList(l2);
            PrintList( MergeTwoLists(l1, l2) );
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result=null;
            int l1Index = 0; int l2Index = 0;
            ListNode next1 = l1;
            ListNode next2 = l2;
            while (next1 != null  && next2 != null)
            {
                if ((next1 != null) && (next1.val <= next2.val))
                {
                    if (result != null)
                    { 
                        ListNodeFunctions.AddEndNode(result, new ListNode(next1.val));
                    }
                    else
                    { 
                        result = new ListNode(next1.val); 
                    }
                    next1 = next1.next;
                }
                else
                {
                    if (result != null)
                    {
                        ListNodeFunctions.AddEndNode(result, new ListNode(next2.val));
                    }
                    else
                    {
                        result = new ListNode(next2.val);
                    }
                    next2 = next2.next;
                }
            }

            if (next1 != null)
            {
                while (next1 != null)
                {
                    if (result != null)
                    {
                        ListNodeFunctions.AddEndNode(result, new ListNode(next1.val)); 
                    }
                    else
                    {
                        result = new ListNode(next1.val);
                    }
                    next1 = next1.next;
                }
            }

            if (next2 != null)
            {
                while (next2 != null)
                {
                    if (result != null)
                    {
                        ListNodeFunctions.AddEndNode(result, new ListNode(next2.val)); 
                    }
                    else
                    {
                        result = new ListNode(next2.val);
                    }
                    next2 = next2.next;
                }
            }
            return result;
        }

        public static void PrintList(ListNode l)
        {
            ListNode next = l;
            while (next != null)
            {
                Console.Write(next.val.ToString() + ",");
                next = next.next;
            }
            Console.WriteLine();
        }

    }
}
