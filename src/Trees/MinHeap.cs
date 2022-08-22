public class MinHeap
{
    public class Node
    {
        public int key { get; set; }
        public string value { get; set; }

        public Node(int key, String value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private Node[] nodes = new Node[10];
    private int size;

    public void Insert(int key, string value)
    {
        if (isFull()) throw new Exception("Heap is full!");

        nodes[size++] = new Node(key, value);

        bubbleUp();
    }

    public String remove()
    {
        if (isEmpty())
            throw new Exception("Heap is empty!");

        var root = nodes[0].value;
        nodes[0] = nodes[--size];

        bubbleDown();

        return root;
    }

    private void bubbleUp()
    {
        var index = size - 1;
        while (index > 0 && nodes[index].key < nodes[parent(index)].key)
        {
            swap(index, parent(index));
            index = parent(index);
        }
    }

    private void bubbleDown()
    {
        var index = 0;
        while (index <= size && !isValidParent(index))
        {
            var largerChildIndex = smallerChildIndex(index);
            swap(index, largerChildIndex);
            index = largerChildIndex;
        }
    }

    private void swap(int first, int second)
    {
        var temp = nodes[first];
        nodes[first] = nodes[second];
        nodes[second] = temp;
    }

    private int parent(int index)
    {
        return (index - 1) / 2;
    }

    //O(1) operation.
    public Node[] GetItems()
    {
        return nodes;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    private int smallerChildIndex(int index)
    {
        if (!hasLeftChild(index))
            return index;

        if (!hasRightChild(index))
            return leftChildIndex(index);

        return (leftChild(index).key < rightChild(index).key) ?
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

        var isValid = nodes[index].key <= leftChild(index).key;

        if (hasRightChild(index))
            isValid &= nodes[index].key <= rightChild(index).key;

        return isValid;
    }

    private Node rightChild(int index)
    {
        return nodes[rightChildIndex(index)];
    }

    private Node leftChild(int index)
    {
        return nodes[leftChildIndex(index)];
    }

    private int leftChildIndex(int index)
    {
        return index * 2 + 1;
    }

    private int rightChildIndex(int index)
    {
        return index * 2 + 2;
    }

    private bool isFull()
    {
        return size == nodes.Length;
    }
}