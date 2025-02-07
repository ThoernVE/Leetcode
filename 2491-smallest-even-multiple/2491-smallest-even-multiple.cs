public class Solution {
    public int SmallestEvenMultiple(int n) {
        int a = 1;
        while(!(a % 2 == 0 && a % n == 0))
        {
            a++;
        }
        return a;
        
    }
}