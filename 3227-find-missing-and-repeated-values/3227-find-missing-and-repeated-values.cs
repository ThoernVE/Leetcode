public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        HashSet<int> hs = new HashSet<int>();
        int max = grid.GetLength(0) * grid.GetLength(0);
        bool found = false;

        foreach(int[] arr in grid)
        {
            foreach(int num in arr)
            {
                if(!found && hs.Contains(num))
                {
                    ans[0] = num;
                    found = true;
                }
                else
                {
                    hs.Add(num);
                }
            }
        }

        for(int i = 1; i <= max; i++)
        {
            if(hs.Contains(i))
            {
                continue;
            }
            else
            {
                ans[1] = i;
                return ans;
            }
        }
        return ans;
    }
}