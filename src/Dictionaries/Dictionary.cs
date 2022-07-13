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
        var entry = GetEntry(key);
        if (entry != null)
        {
            entry.value = value;
            return;
        }

        GetOrCreateBucket(key).AddLast(new Entry(key, value));
    }

    public string get(int key)
    {
        var entry = GetEntry(key);

        return entry != null ? entry.value : string.Empty;
    }

    public void remove(int key)
    {
        var entry = GetEntry(key);
        if (entry == null) throw new Exception("Item not found!");

        GetBucket(key).Remove(entry);
    }

    private LinkedList<Entry> GetBucket(int key)
    {
        return entries[hash(key)];
    }

    private LinkedList<Entry> GetOrCreateBucket(int key)
    {
        var index = hash(key);
        var bucket = entries[index];

        if (bucket == null)
            bucket = new LinkedList<Entry>();

        return bucket;
    }

    private Entry GetEntry(int key)
    {
        var bucket = GetBucket(key);
        if (bucket != null)
        {
            for (int i = 0; i < bucket.Count; i++)
            {
                var entry = bucket.ElementAt(i);
                if (entry.key == key)
                    return entry;
            }
        }

        return null;
    }

    private int hash(int key)
    {
        return key % entries.Length;
    }

}