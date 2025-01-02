public class Solution {
    public bool IsPalindrome(int x) {
        string inputString = Convert.ToString(x);

        int a = 0;
        int b = inputString.Length -1;

        while(a < b) {
            if (inputString[a] != inputString[b]) {
                return false;
            }
            a++;
            b--;
        }
        return true;

        
    }
}