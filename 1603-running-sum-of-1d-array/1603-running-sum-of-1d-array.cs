public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for(int j = i; j >= 0; j--)
            {
                count += nums[j];
            }
            ans[i] = count;
        }

        return ans;
    }
}