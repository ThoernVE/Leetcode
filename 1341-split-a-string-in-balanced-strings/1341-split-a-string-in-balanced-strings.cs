public class Solution {
    private ushort count=0,r=0,l=0;
    public int BalancedStringSplit(string s) {

        for(ushort i = 0; i < s.Length; i++)
        {
            if(s[i] == 'R')
            {
                l++;
            }
            else
            {
                r++;
            }
            if(r == l)
            {
                count++;
                l = 0;
                r = 0;
            }
        }


        return count;
    }
}