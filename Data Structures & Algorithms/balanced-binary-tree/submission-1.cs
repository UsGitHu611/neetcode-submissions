/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int Height(TreeNode subtree) {
        if (subtree == null) return 0;
        return 1 + Math.Max(Height(subtree.left), Height(subtree.right));
    }
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int leftHeight = Height(root.left);
        int rightHeight = Height(root.right);
        if (Math.Abs(leftHeight - rightHeight) > 1) {
            return false;
        }
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
}
