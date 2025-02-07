public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[j] < nums[i] && i != j)
                {
                    count++;
                }
            }
            ans[i] = count;
        }

        return ans;
    }
}