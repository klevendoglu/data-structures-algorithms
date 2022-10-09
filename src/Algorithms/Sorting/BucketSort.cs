
public class BucketSort
{
    public void Sort(int[] array, int numberOfBuckets)
    {
        var i = 0;
        foreach (var bucket in createBuckets(array, numberOfBuckets))
        {
            bucket.Sort();
            foreach (var item in bucket)
                array[i++] = item;
        }
    }

    private List<List<int>> createBuckets(int[] array, int numberOfBuckets)
    {
        List<List<int>> buckets = new List<List<int>>();
        for (var i = 0; i < numberOfBuckets; i++)
            buckets.Add(new List<int>());

        foreach (var item in array)
            buckets[item / numberOfBuckets].Add(item);

        return buckets;
    }
}