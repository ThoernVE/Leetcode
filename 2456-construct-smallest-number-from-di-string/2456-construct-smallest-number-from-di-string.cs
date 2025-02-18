public class Solution {
    public string SmallestNumber(string pattern) {
        List<int> list = new List<int>();
        Stack stk = new Stack();

        for(int i = 0; i < pattern.Length + 1; i++)
        {
            stk.Push(i + 1);
            while(stk.Count > 0 && (i >= pattern.Length || pattern[i] == 'I'))
            {
                list.Add((int)stk.Pop());
            }   
        }

        return string.Join("", list);
    }
}