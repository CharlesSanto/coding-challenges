// https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/

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

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return head;

        ListNode current = head;
        ListNode runner = head.next;

        while (runner != null)
        {
            if (current.val != runner.val)
            {
                current.next = runner;
                current = current.next;
            }
            runner = runner.next;
        }

        current.next = null;

        return head;
    }
}