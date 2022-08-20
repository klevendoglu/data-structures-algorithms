public class AVLTree
{
    private class AVLNode
    {
        public int Value { get; set; }
        public int Height { get; set; }
        public AVLNode LeftChild { get; set; }
        public AVLNode RightChild { get; set; }

        public AVLNode(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return "Node= " + Value;
        }
    }

    private AVLNode root;

    public void Insert(int value)
    {
        root = insert(root, value);
    }

    private AVLNode insert(AVLNode root, int value)
    {
        if (root == null)
            return new AVLNode(value);

        if (value < root.Value)
            root.LeftChild = insert(root.LeftChild, value);
        else
            root.RightChild = insert(root.RightChild, value);

        setHeight(root);

        return balance(root);
    }

    public bool IsBalanced()
    {
        return isBalanced(root);
    }

    public bool isPerfect()
    {
        return Size() == (Math.Pow(2, Height() + 1) - 1);
    }

    private bool isBalanced(AVLNode root)
    {
        if (root == null) return true;

        var balanceFactor = height(root.LeftChild) - height(root.RightChild);

        return Math.Abs(balanceFactor) <= 1 &&
                       isBalanced(root.LeftChild) &&
                       isBalanced(root.RightChild);
    }

    private AVLNode balance(AVLNode node)
    {
        if (isLeftHeavy(node))
        {
            if (balanceFactor(node.LeftChild) < 0)
                leftRotate(node.LeftChild);
            return rightRotate(node);

        }
        else if (isRightHeavy(node))
        {
            if (balanceFactor(node.RightChild) > 0)
                rightRotate(node.RightChild);
            return leftRotate(node);
        }

        return node;
    }

    private AVLNode leftRotate(AVLNode node)
    {
        AVLNode newRoot = node.RightChild;

        node.RightChild = newRoot.LeftChild;
        newRoot.LeftChild = node;

        setHeight(node);
        setHeight(newRoot);

        return newRoot;
    }

    private AVLNode rightRotate(AVLNode node)
    {
        AVLNode newRoot = node.LeftChild;

        node.LeftChild = newRoot.RightChild;
        newRoot.RightChild = node;

        setHeight(node);
        setHeight(newRoot);

        return newRoot;
    }

    private bool isLeftHeavy(AVLNode node)
    {
        return balanceFactor(node) > 1;
    }

    private bool isRightHeavy(AVLNode node)
    {
        return balanceFactor(node) < -1;
    }

    private int balanceFactor(AVLNode node)
    {
        return node == null ? 0 : height(node.LeftChild) - height(node.RightChild);
    }

    public int Height()
    {
        return height(root);
    }

    private int height(AVLNode node)
    {
        return node == null ? -1 : node.Height;
    }

    private void setHeight(AVLNode node)
    {
        node.Height = Math.Max(height(root.LeftChild), height(root.RightChild)) + 1;
    }

    public int Size()
    {
        return size(root);
    }

    private int size(AVLNode node)
    {
        if (node == null) return 0;

        if (isLeaf(node)) return 1;

        return 1 + size(node.LeftChild) + size(node.RightChild);
    }

    private bool isLeaf(AVLNode node)
    {
        return node.LeftChild == null && node.RightChild == null;
    }

}