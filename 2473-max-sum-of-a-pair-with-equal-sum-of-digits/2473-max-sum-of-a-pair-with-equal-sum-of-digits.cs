public class Solution {
    public int MaximumSum(int[] nums) {
        int maxSum = -1;
        var sumMap = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            int sum = CheckSum(num);

            if(sumMap.ContainsKey(sum))
            {
                maxSum = Math.Max(maxSum, sumMap[sum] + num);
                sumMap[sum] = Math.Max(sumMap[sum], num);
            }
            else
            {
               sumMap[sum] = num; 
            }
            
        }
        return maxSum;
    }

    public int CheckSum(int a)
    {
        int sum = 0;
        while( a >= 100)
        {
            sum += a - ((a / 10) * 10);
            a /= 10;
            sum += a - ((a / 10) * 10);
            a /= 10;
        }
        while(a > 0)
        {
            sum += a - ((a / 10) * 10);
            a /= 10;
        }
        return sum;
    }
}