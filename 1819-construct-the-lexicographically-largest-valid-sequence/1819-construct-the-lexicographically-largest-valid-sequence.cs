public class Solution {
    int[] ans;
    int input;
    public int[] ConstructDistancedSequence(int n) {
        input = n;
        return ConstructSequence(n);
    }

    public int[] ConstructSequence(int n)
    {
        ans = new int[2*n-1];
        Backtrack(0);
        return ans;
    }

    private bool Backtrack(int pos)
    {
        if(pos == ans.Length)
            return true;

        if(ans[pos] != 0)
            return Backtrack(pos + 1);

        for(int i = input; i >= 1; i--)
        {
            if(!CanPlace(i))
                continue;

            if(i == 1)
            {
                ans[pos] =1;
                if(Backtrack(pos+1))
                    return true;

                ans[pos] = 0;
            }
            else
            {
                int secondPos = pos + i;

                if(secondPos < ans.Length && ans[secondPos] == 0)
                {
                    ans[pos] = i;
                    ans[secondPos] = i;

                    if(Backtrack(pos + 1))
                        return true;

                        ans[pos] = 0;
                        ans[secondPos] = 0;
                }
            }
        }
        return false;
    }

    private bool CanPlace(int num)
    {
        int count = 0;
        foreach(int val in ans)
        {
            if(val == num)
            {
                count++;
            }
        }
        return count < (num == 1 ? 1 : 2);
    }
}