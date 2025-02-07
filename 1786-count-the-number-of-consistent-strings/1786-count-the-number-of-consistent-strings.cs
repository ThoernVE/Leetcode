public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int count = 0;
        foreach(string word in words)
        {
            int a = 0;
            foreach(char c in word)
            {
                if(allowed.Contains(c))
                {
                    a++;
                }
                
            }
            if(a == word.Length)
            {
                count++;
            }
        }
        return count;
    }
}