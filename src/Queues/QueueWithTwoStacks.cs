public class QueueWithTwoStacks
{
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    // O(1)
    public void enqueue(int item)
    {
        stack1.Push(item);
    }

    // O(n)
    public int dequeue()
    {
        if (isEmpty())
            throw new Exception("Queue is empty!");

        moveStack1ToStack2();

        return stack2.Pop();
    }

    private void moveStack1ToStack2()
    {
        if (stack2.Count == 0)
            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
    }

    public int peek()
    {
        if (isEmpty())
            throw new Exception("Queue is empty!");

        moveStack1ToStack2();

        return stack2.Peek();
    }

    public bool isEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}