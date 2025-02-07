public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> contains = new List<int> ();
        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Contains(x))
            {
                contains.Add(i);
            }
        }
        return contains;
    }
}