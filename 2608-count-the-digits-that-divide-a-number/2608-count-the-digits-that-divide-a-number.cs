public class Solution {
    public int CountDigits(int num) {
        int count=0;
        int x=0;
        int n=num;
        while(num>0)
        {
            x = num % 10;
            num = num / 10;
            if(n % x == 0)
            {
                count++;
            }
        }
        return count;
    }
}