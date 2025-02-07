public class Solution {
    public int MostWordsFound(string[] sentences) {
        int longestCount = 0;
        foreach(string sentence in sentences)
        {
            string[] sent = sentence.Split(" ");
            if(sent.Length > longestCount)
            {
                longestCount = sent.Length;
            }
        }
        return longestCount;
    }
}