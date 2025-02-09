public class Solution {
    public int BalancedStringSplit(string s) {
        ushort result = 0;
        byte lCount = 0;
        byte rCount = 0;
        for(ushort i = 0; i < s.Length; i++)
        {
            if(s[i] == 'R')
            {
                rCount++;
            }
            else
            {
                lCount++;
            }
            if(rCount == lCount && rCount > 0)
            {
                result++;
                lCount = 0;
                rCount = 0;
            }
        }


        return result;
    }
}