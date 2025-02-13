public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        int n = grid.Length;

        int expectedSum = ((n*n)*((n*n)+1))/2;
        HashSet<int> set = [];

        bool japp = false;
        foreach(int[] arr in grid)
        {
            foreach(int num in arr)
            {
                
                if(!japp && set.Contains(num))
                {
                    ans[0] = num;
                    japp = true;
                }
                else if(!japp)
                {
                    set.Add(num);
                    expectedSum -= num;
                }
                else
                {
                    expectedSum -= num;
                }
            }
        }
        ans[1] = expectedSum;

        return ans;
    }
}