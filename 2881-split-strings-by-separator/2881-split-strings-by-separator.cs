public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> result = new List<string>();

        foreach(string word in words)
        {
            string[] split = word.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in split)
            {
                result.Add(s);
            }
        }

        return result;
    }
}