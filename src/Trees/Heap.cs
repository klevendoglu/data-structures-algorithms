public class Heap
{
    private int[] items;
    private int size;

    public Heap(int capacity)
    {
        items = new int[capacity];
    }

    public void Insert(int item)
    {
        if (isFull()) throw new Exception("Heap is full!");

        items[size++] = item;

        bubbleUp(item);
    }

    public int remove()
    {
        if (isEmpty()) throw new Exception("Heap is empty!");

        var root = items[0];
        items[0] = items[--size];

        bubbleDown();

        return root;
    }

    private void bubbleDown()
    {
        var index = 0;
        while (index <= size && !isValidParent(index))
        {
            var largerChildIndex = getLargerChildIndex(index);
            swap(index, largerChildIndex);
            index = largerChildIndex;
        }
    }

    private int getLargerChildIndex(int index)
    {
        if (!hasLeftChild(index))
            return index;

        if (!hasRightChild(index))
            return leftChildIndex(index);

        return (leftChild(index) > rightChild(index)) ?
                leftChildIndex(index) :
                rightChildIndex(index);
    }

    private bool hasLeftChild(int index)
    {
        return leftChildIndex(index) <= size;
    }

    private bool hasRightChild(int index)
    {
        return rightChildIndex(index) <= size;
    }

    private bool isValidParent(int index)
    {
        if (!hasLeftChild(index))
            return true;

        var isValid = items[index] >= leftChild(index);

        if (hasRightChild(index))
            isValid &= items[index] >= rightChild(index);

        return isValid;
    }

    private int rightChild(int index)
    {
        return items[rightChildIndex(index)];
    }

    private int leftChild(int index)
    {
        return items[leftChildIndex(index)];
    }

    private int leftChildIndex(int index)
    {
        return index * 2 + 1;
    }

    private int rightChildIndex(int index)
    {
        return index * 2 + 2;
    }
    //O(1) operation.
    public int[] GetItems()
    {
        return items;
    }

    private void bubbleUp(int item)
    {
        var index = size - 1;
        while (items[index] > items[parent(index)])
        {
            swap(index, parent(index));
            index = parent(index);
        }
    }

    private void swap(int first, int second)
    {
        var temp = items[first];
        items[first] = items[second];
        items[second] = temp;
    }

    private int parent(int index)
    {
        return (index - 1) / 2;
    }

    private bool isFull()
    {
        return size == items.Length;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public int getMax()
    {
        return items[0];
    }
}