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
    public TreeNode RecoverFromPreorder(string traversal) {
        List<TreeNode> stk = new List<TreeNode>();
        int dashes = 0;

        int i = 0;
        while(i < traversal.Length)
        {
            if(traversal[i] == '-')
            {
                dashes++;
                i++;
            }
            else
            {
                int j = i;
                while(j < traversal.Length && traversal[j] != '-')
                {
                    j++;
                }
                int val = Convert.ToInt32(traversal[i..j]);
                TreeNode node = new TreeNode(val);

                while(stk.Count > dashes)
                {
                    
                    stk.Remove(stk[stk.Count - 1]);
                }

                if(stk.Count > 0) 
                {
                    TreeNode lastnode = stk[stk.Count - 1];
                    if(lastnode.left == null)
                    {
                        lastnode.left = node;
                    }
                    else
                    {
                        lastnode.right = node;
                    }
                }

                stk.Add(node);

                i = j;
                dashes = 0;
            }

        }



        return stk[0];
    }
}