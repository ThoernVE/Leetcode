public class CustomStack {
    List<int> stk;
    int max;

    public CustomStack(int maxSize) {
        stk = new List<int>();
        max = maxSize;
    }
    
    public void Push(int x) {
        if(stk.Count < max)
        {
            stk.Add(x);
        }
    }
    
    public int Pop() {
        if(stk.Count == 0)
        {
            return -1;
        }
        int popNum = stk[stk.Count -1];
        stk.RemoveAt(stk.Count -1);
        return popNum;
    }
    
    public void Increment(int k, int val) {
        int indexMax = 0;
        if(k > stk.Count)
        {
            indexMax = stk.Count;
        }
        else
        {
            indexMax = k;
        }
        if(stk.Count > 0)
        {
            for(int i = 0; i < indexMax; i++)
            {
                stk[i] += val;
            }
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */