public class Solution {
    public int MaximumCount(int[] nums) {
        int negative = 0;
        int positive = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] < 0)
            {
                negative++;
            }
            else if(nums[i] > 0)
            {
                positive++;
            }
        }
        if(positive < negative)
        {
            return negative;
        }
        else
        {
            return positive;
        }
    }
}