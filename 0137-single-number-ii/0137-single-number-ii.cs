public class Solution {
    public int SingleNumber(int[] nums) {
        List<int> list = new List<int>();
        List<int> ans = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!ans.Contains(nums[i]))
            {
                ans.Add(nums[i]);
                list.Add(nums[i]);
            }
            else if(ans.Contains(nums[i]))
            {
                list.Remove(nums[i]);
            }
        }

        return list[list.Count -1];
    }
}