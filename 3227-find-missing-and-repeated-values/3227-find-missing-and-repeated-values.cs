public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        int n = grid.Length;
        int m = grid[0].Length;
        int rep = -1;

        int expectedSum = ((n*m)*((n*m)+1))/2;
        int max = grid.GetLength(0) * grid.GetLength(0);
        HashSet<int> set = [];


        foreach(int[] arr in grid)
        {
            foreach(int num in arr)
            {
                
                if(set.Contains(num))
                {
                    ans[0] = num;
                }
                else
                {
                    set.Add(num);
                    expectedSum -= num;
                }
            }
        }
        ans[1] = expectedSum;

        return ans;
    }
}