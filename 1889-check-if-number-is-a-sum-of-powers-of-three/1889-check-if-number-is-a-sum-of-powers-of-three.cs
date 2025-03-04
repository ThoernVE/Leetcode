public class Solution {
    public bool CheckPowersOfThree(int n) {
        int i = 0;
        while(Math.Pow(3, i) < n)
        {
            i++;
        }

        while(i >= 0)
        {
            int power = (int)Math.Pow(3, i);

            if(power <= n)
            {
                n -= power;
            }
            i--;
        }

        return n == 0;
    }
}