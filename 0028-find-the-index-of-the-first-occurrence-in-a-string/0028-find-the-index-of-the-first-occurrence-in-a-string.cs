public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length) {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++) {
            if (haystack[i] != needle[0]) {
                continue;
            }

            int j = 0, counter = 0;
            while (j < needle.Length && i + j < haystack.Length) {
                if (haystack[i + j] == needle[j])
                {
                    counter++;
                    if( counter == needle.Length) {
                        return i;
                    }
                }
                else {
                    counter = 0;
                }
                j++;
            }
        }
        return -1;
    }
}