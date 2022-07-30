public class Tree
{
    private class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return "Node= " + Value;
        }
    }

    private Node root;

    public void Insert(int value)
    {
        var node = new Node(value);

        if (root == null)
        {
            root = node;
            return;
        }

        var current = root;
        while (true)
        {
            if (value < current.Value)
            {
                if (current.LeftChild == null)
                {
                    current.LeftChild = node;
                    break;
                }
                current = current.LeftChild;
            }
            else
            {
                if (current.RightChild == null)
                {
                    current.RightChild = node;
                    break;
                }
                current = current.RightChild;
            }
        }
    }

    public bool find(int value)
    {
        var current = root;
        while (current != null)
        {
            if (value < current.Value)
                current = current.LeftChild;
            else if (value > current.Value)
                current = current.RightChild;
            else
                return true;
        }
        return false;
    }

    public void TraversePreOrder()
    {
        TraversePreOrder(root);
    }

    private void TraversePreOrder(Node node)
    {
        if (node == null) return;

        Console.WriteLine(node.Value);

        TraversePreOrder(node.LeftChild);
        TraversePreOrder(node.RightChild);
    }

    public void TraverseInOrder()
    {
        TraverseInOrder(root);
    }

    private void TraverseInOrder(Node node)
    {
        if (node == null) return;

        TraverseInOrder(node.LeftChild);
        Console.WriteLine(node.Value);
        TraverseInOrder(node.RightChild);
    }

    public void TraversePostOrder()
    {
        TraversePostOrder(root);
    }

    private void TraversePostOrder(Node node)
    {
        if (node == null) return;

        TraversePostOrder(node.LeftChild);
        TraversePostOrder(node.RightChild);
        Console.WriteLine(node.Value);
    }

    public int Height()
    {
        return height(root);
    }

    private int height(Node node)
    {
        if (node == null) return -1;

        if (node.LeftChild == null && node.RightChild == null)
            return 0;

        return 1 + Math.Max(height(node.LeftChild), height(node.RightChild));
    }

    public bool Equals(Tree other)
    {
        if (other == null || other.root == null) throw new Exception("Tree cannot be null!");

        return Equals(root, other.root);
    }

    private bool Equals(Node first, Node second)
    {
        if (first == null && second == null) return true;

        if (first != null && second != null)
        {
            return first.Value == second.Value &&
                    Equals(first.LeftChild, second.LeftChild) &&
                    Equals(first.RightChild, second.RightChild);
        }

        return false;
    }

    public void SwapRoot()
    {
        var temp = root.LeftChild;
        root.LeftChild = root.RightChild;
        root.RightChild = temp;
    }

    public bool IsBinarySearchTree()
    {
        return isBinarySearchTree(root, int.MinValue, int.MaxValue);
    }

    private bool isBinarySearchTree(Node root, int min, int max)
    {
        if (root == null) return true;

        if (root.Value < min || root.Value > max) return false;

        return isBinarySearchTree(root.LeftChild, min, root.Value - 1) &&
                isBinarySearchTree(root.RightChild, root.Value + 1, max);
    }

    public List<int> GetNodesAtDistance(int distance)
    {
        List<int> list = new List<int>();
        getNodesAtDistance(root, distance, list);

        return list;
    }

    private void getNodesAtDistance(Node root, int distance, List<int> toReturnList)
    {
        if (root == null) return;

        if (distance == 0)
        {
            toReturnList.Add(root.Value);
            return;
        }

        getNodesAtDistance(root.LeftChild, distance - 1, toReturnList);
        getNodesAtDistance(root.RightChild, distance - 1, toReturnList);
    }

    public void TraverseLevelOrder()
    {
        for (int i = 0; i <= height(root); i++)
        {
            var list = GetNodesAtDistance(i);
            for (int j = 0; j < list.Count; j++)
                Console.WriteLine(list[j]);
        }
    }

    public int Min()
    {
        return min(root);
    }

    //O(n) operation.
    private int min(Node node)
    {
        if (isLeaf(node)) return node.Value;

        var left = min(node.LeftChild);
        var right = min(node.RightChild);

        return Math.Min(Math.Min(left, right), root.Value);
    }

    public int Max()
    {
        if (root == null)
            throw new Exception("Root cannot be null");

        return max(root);
    }

    //O(log n) operation.
    private int max(Node root)
    {
        if (root.RightChild == null)
            return root.Value;

        return max(root.RightChild);
    }

    public int Size()
    {
        return size(root);
    }

    private int size(Node node)
    {
        if (node == null) return 0;

        if (isLeaf(node)) return 1;

        return 1 + size(node.LeftChild) + size(node.RightChild);
    }

    public int CountLeaves()
    {
        return countLeaves(root);
    }

    private int countLeaves(Node node)
    {
        if (node == null)
            return 0;

        if (isLeaf(node))
            return 1;

        return countLeaves(node.LeftChild) + countLeaves(node.RightChild);
    }

    public bool Contains(int value)
    {
        return contains(root, value);
    }

    private bool contains(Node node, int value)
    {
        if (node == null) return false;

        if (node.Value == value) return true;

        return contains(node.LeftChild, value) || contains(node.RightChild, value);
    }

    public bool AreSibling(int first, int second)
    {
        return areSibling(root, first, second);
    }

    private bool areSibling(Node node, int first, int second)
    {
        if (node == null)
            return false;

        var areSiblings = false;
        if (node.LeftChild != null && node.RightChild != null)
        {
            areSiblings = (node.LeftChild.Value == first && node.RightChild.Value == second) ||
                         (node.RightChild.Value == first && node.LeftChild.Value == second);
        }

        return areSiblings ||
        areSibling(node.LeftChild, first, second) ||
        areSibling(node.RightChild, first, second);
    }

    public List<int> getAncestors(int value)
    {
        var list = new List<int>();
        getAncestors(root, value, list);
        return list;
    }

    private bool getAncestors(Node root, int value, List<int> list)
    {
        if (root == null)
            return false;

        if (root.Value == value)
            return true;

        if (getAncestors(root.LeftChild, value, list) ||
            getAncestors(root.RightChild, value, list))
        {
            list.Add(root.Value);
            return true;
        }

        return false;
    }

    private bool isLeaf(Node node)
    {
        return node.LeftChild == null && node.RightChild == null;
    }
}