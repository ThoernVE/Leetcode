public class Solution {
    public int LengthOfLastWord(string s) {
        string sTrimmed = s.Trim();
        string[] words = sTrimmed.Split(" ");
        
        
        return words[words.Length-1].Length;
        
    }
}