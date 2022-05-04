using System.Text;

public class Stack
{
    private int[] items = new int[5];
    private int count;

    public Stack()
    {

    }

    public void push(int item)
    {
        if (isFull()) throw new StackOverflowException();

        items[count++] = item;
    }

    public int pop()
    {
        if (isEmpty()) throw new IndexOutOfRangeException();

        var item = items[--count];

        return item;
    }

    public int peek()
    {
        if (isEmpty()) throw new IndexOutOfRangeException();

        return items[count - 1];
    }

    public void print()
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine(items[i]);
    }

    private bool isFull()
    {
        return count == items.Length;
    }

    public bool isEmpty()
    {
        return count == 0;
    }
}