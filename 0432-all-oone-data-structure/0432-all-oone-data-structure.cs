public class AllOne {
    public static Dictionary<string, int> dict;

    public AllOne() {
        dict = new Dictionary<string, int>();
    }
    
    public void Inc(string key) {
        if(dict.ContainsKey(key))
        {
            dict[key]++;
        }
        else
        {
            dict[key] = 1;
        }
    }
    
    public void Dec(string key) {
        dict[key]--;
        if(dict[key] == 0)
        {
            dict.Remove(key);
        }
    }
    
    public string GetMaxKey() {
        string maxString = "";
        int maxInt = 0;
        foreach(var item in dict)
        {
            if (item.Value > maxInt)
            {
                maxString = item.Key;
                maxInt = item.Value;
            }
        }
        return maxString;
    }
    
    public string GetMinKey() {
        string minString = "";
        int minInt = 1000000000;
        foreach(var item in dict)
        {
            if (item.Value < minInt)
            {
                minString = item.Key;
                minInt = item.Value;
            }
        }

        return minString;
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */