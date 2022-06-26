public class ArrayQueue
{
    private int[] items;
    private int rear;
    private int front;
    private int count;

    public ArrayQueue(int capacity)
    {
        items = new int[capacity];
    }

    public void enqueue(int item)
    {
        if (isFull()) throw new Exception("Queue is full!");

        items[rear] = item;
        rear = (rear + 1) % items.Length;
        count++;
    }

    public int dequeue()
    {
        var item = items[front];
        items[front] = 0;
        front = (front + 1) % items.Length;
        count--;
        return item;
    }

    public override string ToString()
    {
        return string.Join(", ", items);
    }

    //O(1) operation.
    private bool isFull()
    {
        return items.Length == count;
    }

    //O(1) operation.
    private bool isEmpty()
    {
        return count == 0;
    }
}