public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        foreach(char c in stones)
        {
            if(jewels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}