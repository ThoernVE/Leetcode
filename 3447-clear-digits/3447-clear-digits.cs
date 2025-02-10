public class Solution {
    public string ClearDigits(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            
            if(Char.IsLetter(s[i]))
            {
                stack.Push(s[i]);
            }
            else if(Char.IsDigit(s[i]))
            {
                stack.Pop();
            }
        }
        Stack<char> reverse = new Stack<char>();
        foreach(char c in stack)
        {
            reverse.Push(c);
        }
        return String.Join("", reverse);
    }
}