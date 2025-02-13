public class Solution {
    public int MinOperations(int[] nums, int k)
    {
        int count = 0;
        var minHeap = new PriorityQueue<long>();

        // Add all elements to the min-heap
        foreach (var num in nums)
        {
            minHeap.Enqueue(num);
        }

        // Continue until the smallest element is >= k
        while (minHeap.Count > 0 && minHeap.Peek() < k)
        {
            if (minHeap.Count < 2)
            {
                // If there's only one element left and it's < k, we can't proceed
                return -1; // Or handle this case as per your requirements
            }

            // Perform the operation
            long smallest = minHeap.Dequeue();
            long secondSmallest = minHeap.Dequeue();
            long newElement = smallest * 2 + secondSmallest;

            minHeap.Enqueue(newElement);
            count++;
        }

        return count;
    }
}

// PriorityQueue implementation (min-heap)
public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> heap;

    public PriorityQueue()
    {
        heap = new List<T>();
    }

    public int Count => heap.Count;

    public void Enqueue(T item)
    {
        heap.Add(item);
        int i = heap.Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (heap[parent].CompareTo(heap[i]) <= 0)
                break;
            Swap(parent, i);
            i = parent;
        }
    }

    public T Dequeue()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        T result = heap[0];
        int last = heap.Count - 1;
        heap[0] = heap[last];
        heap.RemoveAt(last);

        int i = 0;
        while (true)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left >= heap.Count)
                break;
            int minChild = left;
            if (right < heap.Count && heap[right].CompareTo(heap[left]) < 0)
                minChild = right;
            if (heap[i].CompareTo(heap[minChild]) <= 0)
                break;
            Swap(i, minChild);
            i = minChild;
        }

        return result;
    }

    public T Peek()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Queue is empty");
        return heap[0];
    }

    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}