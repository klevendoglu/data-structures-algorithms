public class LinkedListQueue
{
    private class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    // O(1)
    public void enqueue(int item)
    {
        var node = new Node(item);

        if (isEmpty())
            head = tail = node;
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }

    // O(1)
    public int dequeue()
    {
        if (isEmpty())
            throw new Exception("Queue is empty!");

        int value;

        if (head == tail)
        {
            value = head.value;
            head = tail = null;
        }
        else
        {
            value = head.value;
            var second = head.next;
            head.next = null;
            head = second;
        }
        count--;

        return value;
    }

    // O(1)
    public int peek()
    {
        if (isEmpty())
            throw new Exception("Queue is empty!");

        return head.value;
    }

    // O(1)
    public int size()
    {
        return count;
    }

    // O(n)
    public String toString()
    {
        Array list = new Array(size());

        Node current = head;

        for (int i = 0; i < size(); i++)
        {
            list.insert(current.value);
            current = current.next;
        }

        return string.Join(", ", list.getItems());
    }

    private bool isEmpty()
    {
        return head == null;
    }

}