public class StackWithTwoQueues
{
    private Queue<int> queue1 = new Queue<int>();
    private Queue<int> queue2 = new Queue<int>();
    private int top;

    // O(1)
    public void push(int item)
    {
        queue1.Enqueue(item);
        top = item;
    }

    public int pop()
    {
        if (isEmpty()) throw new Exception("Queue is empty");

        while (queue1.Count > 1)
        {
            top = queue1.Dequeue();
            queue2.Enqueue(top);
        }

        swapQueues();

        return queue2.Dequeue();
    }

    // O(1)
    public int peek()
    {
        if (isEmpty()) throw new Exception("Queue is empty");

        return top;
    }

    private void swapQueues()
    {
        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    // O(1)
    public int size()
    {
        return queue1.Count;
    }

    // O(1)
    public bool isEmpty()
    {
        return queue1.Count == 0;
    }

    public override string ToString()
    {
        return string.Join(", ", queue1);
    }
}