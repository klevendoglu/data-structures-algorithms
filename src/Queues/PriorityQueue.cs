public class PriorityQueue
{
    private int[] items;
    private int count;

    public PriorityQueue(int capacity)
    {
        items = new int[capacity];
    }

    public void add(int item)
    {
        if (isFull()) resize(5);

        var index = shiftItemsAndGetInsertionPoint(item);

        items[index] = item;
        count++;
    }

    public int remove()
    {
        if (isEmpty()) return -1;

        return items[--count];
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
    public bool isEmpty()
    {
        return count == 0;
    }

    //O(n) operation.
    private int shiftItemsAndGetInsertionPoint(int item)
    {
        int i;
        for (i = count - 1; i >= 0; i--)
        {
            if (items[i] > item)
                items[i + 1] = items[i];
            else
                break;
        }
        return i + 1;
    }

    //O(n) operation.
    private void resize(int? additionalSize = null)
    {
        int[] newArray = new int
            [
                additionalSize.HasValue ? count + additionalSize.Value
                : count * 2
            ];
        for (int i = 0; i < count; i++)
            newArray[i] = items[i];

        this.items = newArray;
    }
}