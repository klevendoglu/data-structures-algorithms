using System.Linq;

public class Trie
{
    public static int ALPHABET_SIZE = 29;
    private class Node
    {
        public char Value;
        public Dictionary<char, Node> Children = new Dictionary<char, Node>();
        public bool IsEndOfWord;
        public Node(char value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return "Value= " + Value;
        }

        public bool hasChild(char ch)
        {
            return Children.ContainsKey(ch);
        }

        public void addChild(char ch)
        {
            Children.Add(ch, new Node(ch));
        }

        public Node getChild(char ch)
        {
            return Children[ch];
        }

        public Node[] getChildren()
        {
            return Children.Values.ToArray();
        }

        public bool hasChildren()
        {
            return Children.Count() > 0;
        }

        public void removeChild(char ch)
        {
            Children.Remove(ch);
        }
    }

    private Node root = new Node(' ');

    public void Insert(string word)
    {
        var charArray = word.ToCharArray();

        var current = root;
        for (int i = 0; i < charArray.Length; i++)
        {
            var charValue = charArray[i];
            if (!current.hasChild(charValue))
                current.addChild(charValue);

            current = current.getChild(charValue);
        }
        current.IsEndOfWord = true;
    }

    public bool Contains(string word)
    {
        if (word is null) return false;

        var charArray = word.ToCharArray();

        var current = root;
        for (int i = 0; i < charArray.Length; i++)
        {
            var charValue = charArray[i];
            if (!current.hasChild(charValue)) return false;

            current = current.getChild(charValue);
        }

        return current.IsEndOfWord;
    }
}