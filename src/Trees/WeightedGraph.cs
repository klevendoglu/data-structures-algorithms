public class WeightedGraph
{
    private class Node
    {
        public string Label { get; set; }

        private List<Edge> Edges = new List<Edge>();

        public Node(string label)
        {
            this.Label = label;
        }

        public void addEdge(Node to, int weight)
        {
            Edges.Add(new Edge(this, to, weight));
        }

        public List<Edge> getEdges()
        {
            return Edges;
        }

        public override string ToString()
        {
            return Label;
        }
    }

    private class Edge
    {
        public Node From { get; set; }
        public Node To { get; set; }
        public int Weight { get; set; }

        public Edge(Node from, Node to, int weight)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("{0} => {1}", From, To);
        }
    }

    private class NodeEntry
    {
        public Node Node;
        public int Priority;

        public NodeEntry(Node node, int priority)
        {
            this.Node = node;
            this.Priority = priority;
        }
    }

    private Dictionary<string, Node> items = new Dictionary<string, Node>();

    public void AddNode(string label)
    {
        var node = new Node(label);
        if (!items.ContainsKey(label))
            items.Add(label, node);
    }

    public void AddEdge(string from, string to, int weight)
    {
        var fromNode = items[from];
        if (fromNode == null)
            throw new ArgumentException();

        var toNode = items[to];
        if (toNode == null)
            throw new ArgumentException();

        fromNode.addEdge(toNode, weight);
        toNode.addEdge(fromNode, weight);
    }

    public Path GetShortestPath(string from, string to)
    {
        var fromNode = items[from];
        if (fromNode == null)
            throw new ArgumentException("from node is null!");

        var toNode = items[to];
        if (toNode == null)
            throw new ArgumentException("to node is null!");

        Dictionary<Node, int> distances = new Dictionary<Node, int>();
        foreach (var node in items.Values)
            distances[node] = int.MaxValue;

        distances[fromNode] = 0;

        Dictionary<Node, Node> previousNodes = new Dictionary<Node, Node>();

        HashSet<Node> visited = new HashSet<Node>();

        PriorityQueue<NodeEntry, int> queue = new PriorityQueue<NodeEntry, int>();
        queue.Enqueue(new NodeEntry(fromNode, 0), 0);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue().Node;
            visited.Add(current);

            foreach (var edge in current.getEdges())
            {
                if (visited.Contains(edge.To))
                    continue;

                var newDistance = distances[current] + edge.Weight;
                if (newDistance < distances[edge.To])
                {
                    distances[edge.To] = newDistance;
                    previousNodes[edge.To] = current;
                    queue.Enqueue(new NodeEntry(edge.To, newDistance), edge.Weight);
                }
            }
        }

        return buildPath(previousNodes, toNode);
    }

    private Path buildPath(
            Dictionary<Node, Node> previousNodes, Node toNode)
    {

        Stack<Node> stack = new Stack<Node>();
        stack.Push(toNode);
        var previous = previousNodes[toNode];
        while (previous != null)
        {
            stack.Push(previous);
            previous = previousNodes[previous];
        }

        var path = new Path();
        while (stack.Count > 0)
            path.add(stack.Pop().Label);

        return path;
    }
    public void Print()
    {
        var nodes = items.Values;
        foreach (var node in nodes)
        {
            var targets = node.getEdges();
            if (targets != null && targets.Count > 0)
                Console.WriteLine(node.Label + " is connected to " + string.Join(",", targets.Select(t => t.To.Label)));
        }
    }

    public bool HasCycle()
    {
        HashSet<Node> visited = new HashSet<Node>();

        foreach (var node in items.Values)
        {
            if (!visited.Contains(node) &&
                hasCycle(node, null, visited))
                return true;
        }

        return false;
    }

    private bool hasCycle(Node node, Node parent,
                             HashSet<Node> visited)
    {
        visited.Add(node);

        foreach (var edge in node.getEdges())
        {
            if (edge.To == parent)
                continue;

            if (visited.Contains(edge.To) ||
                hasCycle(edge.To, node, visited))
                return true;
        }

        return false;
    }

    public WeightedGraph getMinimumSpanningTree()
    {
        var tree = new WeightedGraph();

        if (items.Count == 0)
            return tree;

        PriorityQueue<Edge, int> edges = new PriorityQueue<Edge, int>();

        var enumerator = items.GetEnumerator();
        if (enumerator.MoveNext())
        {
            var startNode = enumerator.Current;
            foreach (var edge in startNode.Value.getEdges())
                edges.Enqueue(edge, edge.Weight);

            tree.AddNode(startNode.Value.Label);
        }
        
        if (edges.Count == 0)
            return tree;

        while (tree.items.Count < items.Values.Count)
        {
            var minEdge = edges.Dequeue();
            var nextNode = minEdge.To;

            if (tree.containsNode(nextNode.Label))
                continue;

            tree.AddNode(nextNode.Label);
            tree.AddEdge(minEdge.From.Label,
                    nextNode.Label, minEdge.Weight);

            foreach (var edge in nextNode.getEdges())
                if (!tree.containsNode(edge.To.Label))
                    edges.Enqueue(edge, edge.Weight);
        }

        return tree;
    }

    public bool containsNode(string label)
    {
        return items.ContainsKey(label);
    }

}