// https://leetcode.com/problems/symmetric-tree/description/

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {

        if (root == null) return true;

        return IsMirror(root.left, root.right);
    }

    public bool IsMirror(TreeNode a, TreeNode b)
    {
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        if (a.val != b.val) return false;

        return IsMirror(a.left, b.right) && IsMirror(a.right, b.left);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
