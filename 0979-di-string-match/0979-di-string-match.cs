public class Solution {
    public int[] DiStringMatch(string s) {
        int[] arr = new int[s.Length + 1];
        int lowest = 0;
        int highest = s.Length;
        for(int i = 0; i < s.Length; i++)
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
        arr[s.Length] = lowest;

        return arr;
    }
}