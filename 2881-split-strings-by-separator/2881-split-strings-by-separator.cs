public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        return String.Join(separator, words).Split(separator, StringSplitOptions.RemoveEmptyEntries);
    }
}