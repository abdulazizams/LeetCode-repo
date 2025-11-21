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
    public ListNode InsertionSortList(ListNode head) {
        
//edge case: one element
        if (head.next == null){return head;}

        ListNode current = head;
        ListNode temp = head;
        
        
while(current.next != null)
{
    
if (current.next.val < current.val)
{
    //take out of sort node and splice the rest
temp = current.next;
    current.next = temp.next;
    
    //if temp < head, update head
    if (temp.val < head.val)
    {
temp.next = head;
        head = temp;
}
    //otherwise, search list
    
    else{
    
    //declare search node
    ListNode search = head;
        bool done = false;
    
    while(!done && search.next != null)
    {
        //splice temp in
if (temp.val < search.next.val)
{
temp.next = search.next;
    search.next = temp;
    done = true;
    
}
        search = search.next;
        
}
        
    }
    }
    else {current = current.next;}
}
        
        return head;
    }
}
