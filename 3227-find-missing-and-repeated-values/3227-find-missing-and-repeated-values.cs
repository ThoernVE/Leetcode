public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        int n = grid.Length;

        int expectedSum = ((n*n)*((n*n)+1))/2;
        int[] set = new int[n * n + 1 ];


        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int curr = grid[i][j];
                set[curr]++;
                expectedSum -= curr;
                if(set[curr] == 2)
                {
                    ans[0] = curr;
                    expectedSum += curr;
                }
            }
        }
        ans[1] = expectedSum;

        return ans;
    }
}