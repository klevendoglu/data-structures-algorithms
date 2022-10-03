public class BinarySearch
{
    public int Recursive(int[] array, int target)
    {
        return recursive(array, target, 0, array.Length - 1);
    }

    public int recursive(int[] array, int target, int left, int right)
    {
        if (right < left)
            return -1;

        var middle = (left + right) / 2;

        if (array[middle] == target)
            return middle;

        if (target < array[middle])
            return recursive(array, target, left, middle - 1);

        return recursive(array, target, middle + 1, right);
    }

    public int Iterative(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (array[middle] == target)
                return middle;

            if (target < array[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }
        return -1;
    }
}

