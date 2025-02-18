public class Solution {
    public int[] DiStringMatch(string s) {
        int n = s.Length;
        int lowest = 0;
        int highest = n;
        int[] arr = new int[n + 1];
        for(int i = 0; i < n; i++)
        {
            if(s[i] == 'I')
            {
                arr[i] = lowest++;
            }
            else
            {
                arr[i] = highest--;
            }
        }
        arr[n] = lowest;

        return arr;
    }
}