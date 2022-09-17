public class Graph
{
    private class Node
    {
        public string Label { get; set; }

        public Node(string label)
        {
            this.Label = label;
        }

        public override string ToString()
        {
            return Label;
        }
    }

    private Dictionary<string, Node> items = new Dictionary<string, Node>();
    private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

    public void AddNode(string label)
    {
        var node = new Node(label);
        if (!items.ContainsKey(label))
            items.Add(label, node);

        if (!adjacencyList.ContainsKey(node))
            adjacencyList.Add(node, new List<Node>());
    }

    public void AddEdge(string from, string to)
    {
        var fromNode = items[from];
        if (fromNode == null)
            throw new ArgumentException();

        var toNode = items[to];
        if (toNode == null)
            throw new ArgumentException();

        adjacencyList[fromNode].Add(toNode);
    }

    public void RemoveNode(string Label)
    {
        var node = items[Label];
        if (node == null) return;

        var adjacencyKeys = adjacencyList.Keys.ToArray();
        for (int i = 0; i < adjacencyKeys.Length; i++)
            adjacencyList[adjacencyKeys[i]].Remove(node);

        adjacencyList.Remove(node);
        items.Remove(Label);
    }

    public void RemoveEdge(string from, string to)
    {
        var fromNode = items[from];
        var toNode = items[to];

        if (fromNode is null || toNode is null) return;

        adjacencyList[fromNode].Remove(toNode);
    }

    public void Print()
    {
        var adjacencyKeys = adjacencyList.Keys.ToArray();
        for (int i = 0; i < adjacencyKeys.Length; i++)
        {
            var targets = adjacencyList[adjacencyKeys[i]];
            if (targets != null && targets.Count > 0)
                Console.WriteLine(adjacencyKeys[i].Label + " is connected to " + string.Join(",", targets.Select(t => t.Label)));
        }
    }

    public void TraverseBreadthFirstIterative(string root)
    {
        items.TryGetValue(root, out var node);
        if (node is null)
        {
            Console.WriteLine("Node is not found!");
            return;
        };

        HashSet<Node> visited = new HashSet<Node>();

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (visited.Contains(current))
                continue;

            Console.WriteLine(current.Label);
            visited.Add(current);

            var neighbours = adjacencyList[current];
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (!visited.Contains(neighbours[i]))
                    queue.Enqueue(neighbours[i]);
            }
        }
    }

    public void TraverseDepthFirstIterative(string root)
    {
        items.TryGetValue(root, out var node);
        if (node is null)
        {
            Console.WriteLine("Node is not found!");
            return;
        };

        HashSet<Node> visited = new HashSet<Node>();

        Stack<Node> stack = new Stack<Node>();
        stack.Push(node);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (visited.Contains(current))
                continue;

            Console.WriteLine(current.Label);
            visited.Add(current);

            var neighbours = adjacencyList[current];
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (!visited.Contains(neighbours[i]))
                    stack.Push(neighbours[i]);
            }
        }
    }

    public void TraverseDepthFirst(string root)
    {
        items.TryGetValue(root, out var node);
        if (node is null)
        {
            Console.WriteLine("Node is not found!");
            return;
        };

        traverseDepthFirst(node, new HashSet<Node>());
    }

    private void traverseDepthFirst(Node root, HashSet<Node> visited)
    {
        Console.WriteLine(root.Label);
        visited.Add(root);

        var nodes = adjacencyList[root];
        for (int i = 0; i < nodes.Count; i++)
        {
            if (!visited.Contains(nodes[i]))
                traverseDepthFirst(nodes[i], visited);
        }
    }

    public List<string> topologicalSort()
    {
        Stack<Node> stack = new Stack<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        var nodes = items.Values.ToArray();
        for (int i = 0; i < nodes.Length; i++)
            topologicalSort(nodes[i], visited, stack);

        List<String> sorted = new List<String>();
        while (stack.Count > 0)
            sorted.Add(stack.Pop().Label);

        return sorted;
    }

    private void topologicalSort(
        Node node, HashSet<Node> visited, Stack<Node> stack)
    {
        if (visited.Contains(node))
            return;

        visited.Add(node);

        var neighbours = adjacencyList[node];
        for (int i = 0; i < neighbours.Count; i++)
            topologicalSort(neighbours[i], visited, stack);

        stack.Push(node);
    }

    public bool HasCycle()
    {
        HashSet<Node> all = new HashSet<Node>();

        var nodes = items.Values.ToArray();
        for (int i = 0; i < nodes.Length; i++)
            all.Add(nodes[i]);

        HashSet<Node> visiting = new HashSet<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        var enumerator = all.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;
            if (hasCycle(current, all, visiting, visited))
                return true;
        }

        return false;
    }

    private bool hasCycle(Node node, HashSet<Node> all,
                 HashSet<Node> visiting, HashSet<Node> visited)
    {
        all.Remove(node);
        visiting.Add(node);

        foreach (var neighbour in adjacencyList[node])
        {
            if (visited.Contains(neighbour))
                continue;

            if (visiting.Contains(neighbour))
                return true;

            if (hasCycle(neighbour, all, visiting, visited))
                return true;
        }

        visiting.Remove(node);
        visited.Add(node);

        return false;
    }

}