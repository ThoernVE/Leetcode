public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int ans = 0;
        for(int i = 0; i < arr.Length - 2; i++)
        {
            for(int j = i + 1; j < arr.Length-1; j++)
            {
                if(CheckValue(arr[i], arr[j], a))
                {
                    for(int k = j + 1; k < arr.Length; k++)
                    {
                        if(CheckValue(arr[j], arr[k], b) && CheckValue(arr[i], arr[k], c))
                        {
                            ans++;
                        }
                    }
                }
            }
        }
        return ans;
    }

    public bool CheckValue(int x, int y, int z)
    {
        return (Math.Abs(x - y) <= Math.Abs(z));
    }
    
}