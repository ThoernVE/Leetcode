public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richest = 0;
        foreach(int[] account in accounts)
        {
            int wealth = 0;
            foreach(int money in account)
            {
                wealth += money;
            }
            if(wealth > richest)
            {
                richest = wealth;
            }
        }
        return richest;
    }
}