public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] arr = new int[2];
        int index = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    arr[index] = nums[j];
                    index++;
                
                }
            }
        }

        return arr;
    }
}