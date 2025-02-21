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
public class FindElements {
    HashSet<int> set = new HashSet<int>();
    public void recoverBinaryTree(TreeNode curr, int val)
    {
        if(curr == null) return;

        set.Add(val);
        recoverBinaryTree(curr.left, 2*val+1);
        recoverBinaryTree(curr.right, 2*val+2);
    }

    public FindElements(TreeNode root) {
        set.Add(0);
        recoverBinaryTree(root.left, 1);
        recoverBinaryTree(root.right, 2);
    }
    
    public bool Find(int target) {
        if(set.Contains(target)) return true;
        return false;
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */