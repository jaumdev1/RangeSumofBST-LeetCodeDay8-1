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
    public int Sum(TreeNode root, int low, int high){
        if(root == null)
        return 0;
        int val = 0;
        if(root.val >= low && root.val <= high)
         val = root.val;

        return (val + Sum(root.left, low, high) +  Sum(root.right, low, high));

    }
    public int RangeSumBST(TreeNode root, int low, int high) {
        return Sum(root, low, high);
    }
}