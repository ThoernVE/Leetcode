public class Solution {
    public int[] DiStringMatch(string s) {
        Stack stk = new Stack();
        List<int> list = new List<int>();
        for(int i = 0; i < s.Length + 1; i++)
        {
            stk.Push(i);
            while(stk.Count > 0 && (i == s.Length || s[i] == 'I'))
            {
                list.Add((int)stk.Pop());
            }
        }

        return list.ToArray();
    }
}