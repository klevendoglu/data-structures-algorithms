public class MinPriorityQueue
{
    private MinHeap heap = new MinHeap();

    public void add(String value, int priority)
    {
        heap.Insert(priority, value);
    }

    public String remove()
    {
        return heap.remove();
    }

    public bool isEmpty()
    {
        return heap.isEmpty();
    }
}