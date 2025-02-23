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
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        int n = preorder.Length;

        return Build(0, n-1, 0, n - 1, preorder, postorder);
    }

    public TreeNode Build(int i1, int i2, int j1, int j2, int[] preorder, int[] postorder)
        {
            if(i1 > i2 || j1 > j2) return null;
            TreeNode root = new TreeNode(preorder[i1]);
            if(i1 != i2)
            {
                int left_val = preorder[i1 +1];

                int mid = Array.IndexOf(postorder, left_val);

                int left_size = mid - j1 + 1;

                root.left = Build(i1 + 1, i1 + left_size, j1, mid, preorder, postorder);
                root.right = Build(i1 + left_size +1, i2, mid + 1, j2 - 1, preorder, postorder);
            }
            return root;
        }
}

    