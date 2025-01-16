public class Solution {
    public int MaxProfit(int[] prices) {
        int bigDiff = 0;
        int min = prices[0];
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < min)
            {
                min = prices[i];
            }
            else if (prices[i] > min && bigDiff < prices[i] - min)
            {
                bigDiff = prices[i] - min;
            }
        }
        return bigDiff;
    }
}