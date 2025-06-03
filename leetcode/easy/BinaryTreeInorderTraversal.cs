// https://leetcode.com/problems/binary-tree-inorder-traversal/description/

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return new List<int>();

        var left = InorderTraversal(root.left);
        var right = InorderTraversal(root.right);

        var result = new List<int>(left);
        result.Add(root.val);
        result.AddRange(right);

        return result;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
