public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans  = new int[nums.Length];
        int x = 0;
        int y = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            
            if(i % 2 == 0)
            {
                ans[i] = nums[x];
                x++;
            }
            else
            {
                ans[i] = nums[y + (nums.Length / 2)];
                y++;
            }
        }
        return ans;
    }
}