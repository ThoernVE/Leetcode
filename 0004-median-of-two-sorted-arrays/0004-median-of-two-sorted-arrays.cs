public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = nums1.Concat(nums2).ToArray();

        Array.Sort(combined);

        double ans = 0;

        if(combined.Length % 2 == 0)
        {
            ans = (double)(combined[combined.Length/2] + combined[combined.Length/2 - 1]) / 2;
        }
        else
        {
            ans = combined[combined.Length / 2];
        }
        return ans;
    }
}