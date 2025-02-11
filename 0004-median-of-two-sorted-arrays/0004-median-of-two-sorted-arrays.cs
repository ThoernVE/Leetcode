public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length <= 0) return GetMedian(nums2);
if (nums2.Length <= 0) return GetMedian(nums1);
        int[] combined = nums1.Concat(nums2).ToArray();

        Array.Sort(combined);

        return GetMedian(combined);
    }

    public double GetMedian(int[] array)
    {
        if(array.Length % 2 == 0)
        {
            return (double)(array[array.Length/2] + array[array.Length/2 - 1]) / 2;
        }
        else
        {
            return (double)array[array.Length / 2];
        }
    }
}