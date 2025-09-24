
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
        ListNode result=new ListNode();
        ListNode tempResult = result;
        int carry = 0;

        while(l1!=null||l2!=null||carry>0)
        {   
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            int sum = x+y+carry;
            
            tempResult.val=sum%10;
            carry=sum/10;
            
            if(l1!=null)
                l1=l1.next;
            if(l2!=null)
                l2=l2.next;

            if (l1 != null || l2 != null || carry > 0)
            {
                tempResult.next = new ListNode();
                tempResult = tempResult.next;
            }

            
        }
        return result;
    }
}