public class MaxHeap
{
    public static void Heapify(int[] items)
    {
        var lastParentIndex = items.Length / 2 - 1;
        for (int i = lastParentIndex; i >= 0; i--)
            heapify(items, i);
    }

    public static int GetLargestKth(int[] items, int k)
    {
        if (k <= 0 || k > items.Length) throw new ArgumentOutOfRangeException();

        Heap heap = new Heap(items.Length);
        for (int i = 0; i < items.Length; i++)
            heap.Insert(items[i]);

        for (int j = 0; j < k - 1; j++)
            heap.remove();

        return heap.getMax();
    }

    private static void heapify(int[] items, int index)
    {
        var largerIndex = index;

        var leftChildIndex = index * 2 + 1;
        if (leftChildIndex < items.Length &&
                items[leftChildIndex] > items[largerIndex])
            largerIndex = leftChildIndex;

        var rightChildIndex = index * 2 + 2;
        if (rightChildIndex < items.Length &&
            items[rightChildIndex] > items[largerIndex])
            largerIndex = rightChildIndex;

        if (index == largerIndex)
            return;

        swap(items, index, largerIndex);
        heapify(items, largerIndex);
    }

    private static void swap(int[] items, int first, int second)
    {
        var temp = items[first];
        items[first] = items[second];
        items[second] = temp;
    }
}