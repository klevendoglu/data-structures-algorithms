public class Array
{
    private int[] items;
    private int count;

    public Array(int length)
    {
        this.items = new int[length];
    }

    //O(n) operation.
    public void insert(int item)
    {
        if (isFull()) resize();

        items[count++] = item;
    }

    //O(n) operation.
    public void bulkInsert(params int[] arr)
    {
        if (isFull()) resize(arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            items[count++] = arr[i];
        }
    }

    //O(n) operation.
    public void removeAt(int index)
    {
        if (isOutOfRange(index)) throw new ArgumentOutOfRangeException();

        shift(index);

        count--;
    }

    //O(n) operation.
    public int indexOf(int item)
    {
        for (int i = 0; i < count; i++)
            if (items[i] == item) return i;

        return -1;
    }

    //O(n) operation.
    public int max()
    {
        int max = 0;
        for (int i = 0; i < count; i++)
            if (items[i] > max) max = items[i];

        return max;
    }

    //O(n) operation.
    public Array intersect(Array itemsToIntersect)
    {
        Array intersection = new Array(count);
        for (int i = 0; i < itemsToIntersect.count; i++)
            if (indexOf(itemsToIntersect.items[i]) >= 0)
                intersection.insert(itemsToIntersect.items[i]);

        return intersection;
    }

    //O(n) operation.
    public Array reverse()
    {
        Array reversed = new Array(count);
        for (int i = count - 1; i >= 0; i--)
            reversed.insert(items[i]);

        return reversed;
    }

    //O(n) operation.
    public void insertAt(int newItem, int indexFrom)
    {
        if (isOutOfRange(indexFrom)) throw new ArgumentOutOfRangeException();

        if (isFull()) resize();

        for (int i = indexFrom; i < count + 1; i++)
        {
            items[i + 1] = items[i];
        }
        items[indexFrom] = newItem;
        count++;
    }

    //O(n) operation.
    public void print()
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine(items[i]);
    }

    //O(n) operation.
    private void shift(int indexFrom)
    {
        for (int i = indexFrom; i < count; i++)
            items[i] = items[i + 1];
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

    //O(1) operation.
    private bool isFull()
    {
        return items.Length == count;
    }

    //O(1) operation.
    private bool isOutOfRange(int index)
    {
        return index < 0 || index >= count;
    }

}