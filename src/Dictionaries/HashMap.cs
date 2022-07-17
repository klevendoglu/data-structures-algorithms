public class HashMap
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

    private Entry[] entries = new Entry[5];
    private int count;

    public void Put(int key, string value)
    {
        var entry = GetEntry(key);
        if (entry != null)
        {
            entry.value = value;
            return;
        }

        if (isFull())
            throw new Exception("Hashmap is full!");

        entries[GetIndex(key)] = new Entry(key, value);
        count++;
    }

    public String Get(int key)
    {
        var entry = GetEntry(key);
        return entry != null ? entry.value : null;
    }

    public void Remove(int key)
    {
        var index = GetIndex(key);
        if (index == -1 || entries[index] == null)
            return;

        entries[index] = null;
        count--;
    }

    private Entry GetEntry(int key)
    {
        var index = GetIndex(key);
        return index >= 0 ? entries[index] : null;
    }

    private int GetIndex(int key)
    {
        //We use linear probing strategy
        int step = 0;

        while (step < entries.Length)
        {
            var index = Index(key, step++);
            var entry = entries[index];
            if (entry == null || entry.key == key)
                return index;
        }

        return -1;
    }

    public int size()
    {
        return count;
    }

    private int Index(int key, int i)
    {
        return (Hash(key) + i) % entries.Length;
    }

    private int Hash(int key)
    {
        return key % entries.Length;
    }

    private bool isFull()
    {
        return count == entries.Length;
    }

    public override string ToString()
    {
        return string.Join(", ", entries.Where(t=> t != null).Select(t => t.value));
    }
}