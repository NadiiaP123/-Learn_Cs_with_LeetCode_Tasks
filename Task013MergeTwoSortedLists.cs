using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LeetcodeTasks
{
    internal class Task013MergeTwoSortedLists
    {

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

        public static void Run()
        {
            ListNode list1 =
                new ListNode(1,
                    new ListNode(2,
                        new ListNode(4)));

            ListNode list2 =
                new ListNode(1,
                    new ListNode(3,
                        new ListNode(4)));

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }


            if (list1 != null)
                current.next = list1;

            if (list2 != null)
                current.next = list2;

            ListNode result = dummy.next;

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }

        }


    }
}
