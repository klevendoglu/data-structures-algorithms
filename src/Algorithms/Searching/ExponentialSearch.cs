public class ExponentialSearch
{
    public int Search(
              int[] array, int target)
    {

        int bound = 1;
        while (bound < array.Length &&
                array[bound] < target)
            bound *= 2;

        int left = bound / 2;
        int right = Math.Min(bound, array.Length - 1);

        return new BinarySearch().recursive(array, target, left, right);
    }
}