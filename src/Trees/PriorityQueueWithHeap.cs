public class PriorityQueueWithHeap
{
    private Heap heap = new Heap(10);

    public void Enqueue(int item)
    {
        heap.Insert(item);
    }
    public int Dequeue()
    {
        return heap.remove();
    }

    public bool IsEmpty() {
        return heap.isEmpty();
    }
}