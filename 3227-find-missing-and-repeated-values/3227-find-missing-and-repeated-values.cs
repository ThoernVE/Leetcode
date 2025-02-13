public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        int max = grid.GetLength(0) * grid.GetLength(0);
        int[] loop = new int[max];
        int count = 0;

        foreach(int[] arr in grid)
        {
            foreach(int num in arr)
            {
                loop[count++] = num;
            }
        }

        Array.Sort(loop);
        if(loop[0] == 2)
        {
            ans[1] = 1;
        }


        for(int i = 0; i < loop.Length -1; i++)
        {
            if(loop[i] == loop[i + 1])
            {
                ans[0] = loop[i];
            }
            else if(loop[i + 1] > loop[i] + 1)
            {
                ans[1] = loop[i] + 1;
            }
        }
        if(ans[1] == 0)
        {
            ans[1] = loop.Length;
        }
        return ans;
    }
}