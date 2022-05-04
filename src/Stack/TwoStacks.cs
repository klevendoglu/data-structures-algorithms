public class TwoStacks
{
    private int[] items;

    private int count1;
    private int count2;

    public TwoStacks(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be 1 or greater.");

        items = new int[capacity];

        count1 = -1;
        count2 = capacity;
    }

    public void push1(int item)
    {
        if (isFull1())
            throw new IndexOutOfRangeException();

        items[++count1] = item;
    }


    public int pop1()
    {
        if (isEmpty1())
            throw new IndexOutOfRangeException();

        return items[count1--];
    }

    public void push2(int item)
    {
        if (isFull2())
            throw new IndexOutOfRangeException();

        items[--count2] = item;
    }

    public int pop2()
    {
        if (isEmpty2())
            throw new IndexOutOfRangeException();

        return items[count2++];
    }

    private bool isEmpty1()
    {
        return count1 == -1;
    }

    private bool isFull1()
    {
        return count1 + 1 == count2;
    }

    private bool isEmpty2()
    {
        return count2 == items.Length;
    }

    private bool isFull2()
    {
        return count2 - 1 == count1;
    }
}