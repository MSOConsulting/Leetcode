using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * @author: Mehdi SOULA
 * @created on: 01/26/2022
 * @updated on: 01/26/2022
 * @description: Given head, the head of a linked list, determine if the linked list has a cycle in it.
 */

namespace Leetcode
{
    public class ListNode
    {
        public int _val = 0;
        public ListNode next;
        ListNode(int val, ListNode next=null)
        {
            _val = val;
        }
    }
    internal class Leetcode141
    {
        public bool HasCycle(ListNode head)
        {
            if(head == null)
                return false;

            bool toReturn = false;
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if(slow == fast)
                toReturn = true;

            return toReturn;
        }
    }
}
