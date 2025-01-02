public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> numList = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(numList.Contains(nums[i]))
            {
                continue;
            }
            else
            {
              numList.Add(nums[i]);
            }
        }
        for(int i = 0; i < numList.Count; i++)
        {
            nums[i] = numList[i]; 
        }
        return numList.Count;
    }
}