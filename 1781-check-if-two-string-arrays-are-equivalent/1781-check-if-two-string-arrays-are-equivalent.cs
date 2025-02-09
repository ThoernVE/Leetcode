public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        string result1 = string.Join("", word1);
        string result2 = string.Join("", word2);
        if(result1.Length != result2.Length)
            {
                return false;
            }
        for(int i = 0; i < result1.Length; i++)
        {
            if(result1[i] != result2[i])
            {
                return false;
            }
        }
        return true;
    }
}