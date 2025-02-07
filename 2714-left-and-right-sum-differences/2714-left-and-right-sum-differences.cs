public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int[] ans = new int[nums.Length];
        int leftCount = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int rightCount = 0;
            for(int j = i+1; j < nums.Length; j++)
            {
                rightCount += nums[j];
            }
            int count = leftCount - rightCount;
            if(count < 0)
            {
                ans[i] = count * -1;
            }
            else
            {
            ans[i] = leftCount - rightCount;
            }
            leftCount += nums[i];
        }

        return ans;
    }
}