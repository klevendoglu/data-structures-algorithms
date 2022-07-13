public class DictionaryExercises
{
    public int FindMostFrequent(int[] input)
    {
        Dictionary<int, int> items = new Dictionary<int, int>();

        for (int i = 0; i < input.Length; i++)
        {
            var count = items.ContainsKey(input[i]) ? items.GetValueOrDefault(input[i]) : 0;
            items[input[i]] = count + 1;
        }

        var mostFrequent = 0;
        for (int i = 0; i < input.Length; i++)
            if (items.GetValueOrDefault(input[i]) > mostFrequent)
                mostFrequent = items.GetValueOrDefault(input[i]);

        return mostFrequent;
    }

    // O(n) operation
    public int CountPairsWithDiff(int[] numbers, int difference)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < numbers.Length; i++)
            set.Add(numbers[i]);

        var count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (set.Contains(numbers[i] + difference))
                count++;
            if (set.Contains(numbers[i] - difference))
                count++;
            set.Remove(numbers[i]);
        }

        return count;
    }

    public int[] twoSum(int[] numbers, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map.GetValueOrDefault(complement), i };
            }
            map[numbers[i]] = i;
        }

        return null;
    }
}