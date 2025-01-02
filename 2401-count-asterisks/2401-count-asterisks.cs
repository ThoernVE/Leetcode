public class Solution {
    public int CountAsterisks(string s) {
        string[] split = s.Split('|');
        int count = 0;
        for(int i = 0; i < split.Length; i++)
        {
            for(int j = 0; j < split[i].Length; j++)
            {
                if(split[i][j] == '*')
                {
                    count++;
                }
            }
            i++;
        }
        return count;
    }
}