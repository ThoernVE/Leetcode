public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        var set = new HashSet<int>(arr);
        int res = 0;

        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                int previous = arr[i];
                int current = arr[j];
                int next = previous + current;
                int length = 2;
                while(set.Contains(next))
                {
                    length++;
                    previous = current;
                    current = next;
                    next = previous + current;
                    res = Math.Max(res, length);
                }
            }
        }
        return res;
    }
}