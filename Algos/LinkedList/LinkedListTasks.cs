using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.LinkedList
{
    public class LinkedListTasks
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l1Reverse = ReverseList(l1);
            var l2Reverse = ReverseList(l2);
            ListNode l3 = new ListNode(); ;
            int newVal = 0;
            int nextVal = 0;
            while (l1Reverse != null || l2Reverse != null)
            {

                var val = l1Reverse.val + l2Reverse.val;

                if (nextVal > 0)
                {
                    val += nextVal;
                }

                if (val >= 10)
                {
                    newVal = val % 10;
                    nextVal = val / 10;
                }
                else
                    newVal = val;

                l3.val = newVal;
                l3.next = new ListNode();
                l3 = l3.next;
                l1Reverse = l1Reverse.next;
                l2Reverse = l2Reverse.next;
            }

            return l3;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode next = null;
            ListNode current = head;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;

            return head;
        }
    }
}
