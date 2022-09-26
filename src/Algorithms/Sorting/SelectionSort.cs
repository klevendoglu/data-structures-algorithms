public class SelectionSort
{
    public void Sort(int[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            var minIndex = i;
            for (int j = i; j < items.Length; j++)
            {
                if (items[j] < items[minIndex])
                    minIndex = j;
            }
            swap(items, minIndex, i);
        }
    }

    private void swap(int[] items, int index1, int index2)
    {
        var temp = items[index1];
        items[index1] = items[index2];
        items[index2] = temp;
    }
}