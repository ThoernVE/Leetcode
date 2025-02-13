public class Solution {
    public int MinOperations(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();

        foreach(var num in nums)
        {
            if(num < k)
            {
                pq.Enqueue(num, num);
            }
        }

        int count = 0;
        while(pq.Count > 1)
        {
            var x = pq.Dequeue();
            var y = pq.Dequeue();

            if(x * 2  < k - y)
            {
                pq.Enqueue(x * 2 + y, x * 2 + y);
            }
            count++;
        }
        return count + pq.Count;

    }
}