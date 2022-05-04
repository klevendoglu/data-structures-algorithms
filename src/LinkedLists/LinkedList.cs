public class LinkedList
{
    private Node first;
    private Node last;
    private int count;

    private class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }


    public void addFirst(int value)
    {
        var node = new Node(value);
        if (isNull())
            first = last = node;
        else
        {
            node.next = first;
            first = node;
        }

        count++;
    }

    public void removeFirst()
    {
        if (isNull()) throw new ArgumentNullException();

        if (isSingleNode())
            first = last = null;
        else
        {
            var second = first.next;
            first.next = null;
            first = second;
        }

        count--;
    }

    public void addLast(int value)
    {
        var node = new Node(value);
        if (isNull())
            first = last = node;
        else
        {
            last.next = node;
            last = node;
        }

        count++;
    }

    public void removeLast()
    {
        if (isNull()) throw new ArgumentNullException();

        if (isSingleNode())
            first = last = null;
        else
        {
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
        }

        count--;
    }

    public int indexOf(int item)
    {
        int index = 0;
        var current = first;
        while (current != null)
        {
            if (current.value == item)
                return index;
            index++;
            current = current.next;
        }
        return -1;
    }

    public bool contains(int item)
    {
        return indexOf(item) > -1;
    }

    public int size()
    {
        return count;
    }

    public int[] toArray()
    {
        var array = new int[count];
        var index = 0;

        var current = first;
        while (current != null)
        {
            array[index++] = current.value;

            current = current.next;
        }

        return array;
    }

    public void reverse()
    {
        if (isNull()) return;

        var previous = first;
        var current = first.next;
        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        last = first;
        last.next = null;
        first = previous;
    }

    public int getKthFromTheEnd(int k)
    {
        if (isNull()) return -1;

        var p1 = first;
        var p2 = first;

        for (var i = 0; i < k - 1; i++)
        {
            p2 = p2.next;
            if (p2 == null) throw new ArgumentOutOfRangeException();
        }

        while (p2 != last)
        {
            p1 = p1.next;
            p2 = p2.next;
        }
        return p1.value;
    }

    public string printMiddle()
    {
        if (isNull()) return string.Empty;

        var p1 = first;
        var p2 = first;

        while (p2 != last && p2.next != last)
        {
            p2 = p2.next.next;
            p1 = p1.next;
        }

        if (p2 == last)
            return p1.value.ToString();
        else
            return p1.value + "," + p1.next.value;
    }

    public bool hasLoop()
    {
        var slow = first;
        var fast = first;

        while (fast != last && fast.next != last)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast == slow) return true;
        }

        return false;
    }

    private Node getPrevious(Node node)
    {
        var current = first;
        while (current != null)
        {
            if (current.next.value == last.value)
                return current;

            current = current.next;
        }
        return null;
    }

    private bool isNull()
    {
        return first == null;
    }

    private bool isSingleNode()
    {
        return first == last;
    }
}

