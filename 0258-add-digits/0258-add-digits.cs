public class Solution {
    public int AddDigits(int num) {
        int sum = 0;
        string s = Convert.ToString(num);
        for(int i = 0; i < s.Length; i++)
        {
            sum = sum + Convert.ToInt32(s[i])-48;
        }
        s = Convert.ToString(sum);
        do
        {
            sum=0;
            for(int i = 0; i < s.Length; i++)
            {
                sum = sum + Convert.ToInt32(s[i])-48;
            }
            s = Convert.ToString(sum);
        }
        while(s.Length >= 2);
        return sum;
    }
}