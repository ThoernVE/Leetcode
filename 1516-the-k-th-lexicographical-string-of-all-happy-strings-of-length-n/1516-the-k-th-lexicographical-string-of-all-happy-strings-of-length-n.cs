public class Solution {
    public string GetHappyString(int n, int k) {
        List<char> res = new List<char>();
        int left = 1;
        int right = (int)3 * (int)Math.Pow(2, (n-1));

        if(right < k )
        {
            return "";
        }

        for(int i = 0; i < n; i++)
        {
            List<char> choices = new List<char>{'a', 'b', 'c'};
            if (res.Count > 0) choices.Remove(res[^1]);

            int current = left;
            int partition_size = (right - left + 1) / choices.Count;
            foreach(char c in choices)
            {
                if(k >= current && k < current + partition_size)
                {
                    res.Add(c);
                    left = current;
                    right = current + partition_size - 1;
                    break;
                }
                current += partition_size;
            }
        }

        return string.Join("", res);
    }
}