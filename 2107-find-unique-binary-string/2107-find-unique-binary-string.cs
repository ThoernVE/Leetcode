public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        string[] ans = new string[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = "0";
        }
        //000, 100, 110, 111
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums.Contains(string.Join("", ans)))
            {
                ans[i] = "1";
            }
            else
            {
                return string.Join("", ans);
            }
        }

        return string.Join("", ans);
    }
}