public class Dictionary
{
    private class Entry
    {
        public int key;
        public string value;

        public Entry(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

    public void put(int key, string value)
    {
        var index = hash(key);

        if (entries[index] == null)
            entries[index] = new LinkedList<Entry>();

        var bucket = entries[index];
        for (int i = 0; i < bucket.Count; i++)
        {
            var entry = bucket.ElementAt(i);
            if (entry.key == key)
                entry.value = value;

            return;
        }

        bucket.AddLast(new Entry(key, value));
    }

    public string get(int key)
    {
        var index = hash(key);
        var bucket = entries[index];
        if (bucket == null) return null;

        var value = "";
        for (int i = 0; i < bucket.Count; i++)
        {
            var entry = bucket.ElementAt(i);
            if (entry.key == key)
                value = entry.value;
        }

        return value;
    }

    private int hash(int key)
    {
        return key % entries.Length;
    }

}