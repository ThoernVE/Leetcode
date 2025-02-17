public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
        {
            return false;
        }
        string inputString = Convert.ToString(x);

        int a = 0;
        int b = inputString.Length -1;

        while(a < b) {
            if (inputString[a++] != inputString[b--]) {
                return false;
            }
        }
        return true;

        
    }
}