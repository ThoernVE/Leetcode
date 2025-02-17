public class Solution {
    public int NumTilePossibilities(string tiles) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i = 0; i < tiles.Length; i++)
        {
            if(dict.ContainsKey(tiles[i].ToString()))
            {
                dict[tiles[i].ToString()]++;
            }
            else
            {
                dict[tiles[i].ToString()] = 1;
            }
        }

        

        return Recursivething(dict);
        
    }
    public int Recursivething(Dictionary<string, int> dict)
    {
        int result = 0;
        foreach(var kvp in dict)
        {
            if(kvp.Value > 0)
            {
                dict[kvp.Key] -= 1;
                result += 1;
                result += Recursivething(dict);
                dict[kvp.Key] += 1;
            }
        }
        return result;
    }
}