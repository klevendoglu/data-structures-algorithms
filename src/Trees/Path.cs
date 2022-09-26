public class Path
{
    private List<string> nodes = new List<string>();

    public void add(string node)
    {
        nodes.Add(node);
    }

    public override string ToString()
    {
        return nodes.ToString();
    }
}