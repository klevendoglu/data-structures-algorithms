using System.Linq;
using System.Text;

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

    public void traverse()
    {
        traverse(root);
    }

    private void traverse(Node root)
    {
        var children = root.getChildren();
        for (int i = 0; i < children.Length; i++)
            traverse(children[i]);

        // Post-order: visit the root last
        Console.WriteLine(root.Value);
    }

    public void Remove(String word)
    {
        if (word == null)
            return;

        remove(root, word, 0);
    }

    private void remove(Node root, string word, int index)
    {
        if (index == word.Length)
        {
            root.IsEndOfWord = false;
            return;
        }

        var ch = word[index];
        var child = root.getChild(ch);
        if (child == null)
            return;

        remove(child, word, index + 1);

        if (!child.hasChildren() && !child.IsEndOfWord)
            root.removeChild(ch);
    }

    public List<string> FindWords(string prefix)
    {
        List<string> words = new List<string>();
        var lastNode = findLastNodeOf(prefix);
        findWords(lastNode, prefix, words);

        return words;
    }

    private void findWords(Node root, string prefix, List<string> words)
    {
        if (root == null)
            return;

        if (root.IsEndOfWord)
            words.Add(prefix);

        var children = root.getChildren();

        for (int i = 0; i < children.Length; i++)
            findWords(children[i], prefix + children[i].Value, words);
    }

    private Node findLastNodeOf(string prefix)
    {
        if (prefix == null)
            return null;

        var current = root;
        var prefixChars = prefix.ToCharArray();

        for (int i = 0; i < prefixChars.Length; i++)
        {
            var child = current.getChild(prefixChars[i]);
            if (child == null)
                return null;

            current = child;
        }
        return current;
    }

    public bool ContainsRecursive(string word)
    {
        if (word == null)
            return false;

        return containsRecursive(root, word, 0);
    }

    private bool containsRecursive(Node root, string word, int index)
    {
        if (index == word.Length)
            return root.IsEndOfWord;

        if (root == null) return false;

        var wordChars = word.ToCharArray();

        var child = root.getChild(wordChars[index]);
        if (child == null)
            return false;

        return containsRecursive(child, word, index + 1);
    }

    public int CountWords()
    {
        return countWords(root);
    }

    private int countWords(Node root)
    {
        var total = 0;

        if (root.IsEndOfWord)
            total++;

        var children = root.getChildren();
        for (int i = 0; i < children.Length; i++)
            total += countWords(children[i]);

        return total;
    }

    public void PrintWords()
    {
        printWords(root, string.Empty);
    }

    private void printWords(Node root, string word)
    {
        if (root.IsEndOfWord)
            Console.WriteLine(word);

        var children = root.getChildren();
        for (int i = 0; i < children.Length; i++)
            printWords(children[i], word + children[i].Value);
    }

    private List<string> getWords()
    {
        List<string> words = new List<string>();
        getWords(root, string.Empty, words);
        return words;
    }

    private void getWords(Node root, string word, List<string> words)
    {
        if (root == null)
            return;

        if (root.IsEndOfWord)
            words.Add(word);

        var children = root.getChildren();
        for (int i = 0; i < children.Length; i++)
            getWords(children[i], word + children[i].Value, words);
    }

    public string longestCommonPrefix()
    {
        var prefix = new StringBuilder();
        var maxChars = getShortest().Length;
        var current = root;
        while (prefix.Length < maxChars)
        {
            var children = current.getChildren();
            if (children.Length != 1)
                break;
            current = children[0];
            prefix.Append(current.Value);
        }

        return prefix.ToString();
    }

    private string getShortest()
    {
        var words = getWords();
        if (words == null || words.Count == 0)
            return "";

        var shortest = words[0];
        for (var i = 1; i < words.Count; i++)
        {
            if (words[i].Length < shortest.Length)
                shortest = words[i];
        }

        return shortest;
    }
}