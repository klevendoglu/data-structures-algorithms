public class QueueReverser
{
    public void reverse(Queue<int> queue)
    {
        if (queue == null) throw new ArgumentNullException();

        var count = queue.Count;

        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < count; i++)
            stack.Push(queue.Dequeue());

        for (int i = 0; i < count; i++)
            queue.Enqueue(stack.Pop());

    }

    public void reverseByKth(Queue<int> queue, int k)
    {
        if (k < 0 || k > queue.Count) throw new ArgumentException();

        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < k; i++)
            stack.Push(queue.Dequeue());

        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());

        for (int i = 0; i < queue.Count - k; i++)
            queue.Enqueue(queue.Dequeue());
    }

    //O(n) operation.
    public void print(Queue<int> queue)
    {
        for (int i = 0; i < queue.Count; i++)
            Console.WriteLine(queue.ElementAt(i));
    }
}