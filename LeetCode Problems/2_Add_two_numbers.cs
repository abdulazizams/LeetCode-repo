//URL: https://leetcode.com/problems/add-two-numbers

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode sum = new ListNode();
        sum.val = 0;
        ListNode head = new ListNode(0, sum);
        ListNode prev = new ListNode();

        //helper values to circumvent null cases
        int tot = 0; int val1 = 0; int val2 = 0;

        while(l1 != null || l2 != null)
        {
            //populate helper values with node values if not null
            val1 = (l1 == null)? 0 : l1.val;
            val2 = (l2 == null)? 0 : l2.val;

            //add node values to carried value in helper total
            tot += val1 + val2;

            //sum node value is the ones digit of helper total
            sum.val = tot % 10;

            // next node
            sum.next = new ListNode();
            prev = sum;
            sum = sum.next;

            //helper total is the carried tenth digit
            tot = tot / 10;

            //procede to next node if not null
            l1 = (l1 == null)? l1 : l1.next;
            l2 = (l2 == null)? l2 : l2.next;
        }

        //if there is 1 carried add it to the new node, else delete the node
        sum.val = tot;
        prev.next = (sum.val == 0)? null : sum;
        

        return head.next;
    }
}
