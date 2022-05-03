public class ExpressionWithStack
{
    private readonly IList<char> leftBrackets = new List<char> { '(', '<', '[', '{' };
    private readonly IList<char> rightBrackets = new List<char> { ')', '>', ']', '}' };

    public bool isBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        var charArray = input.ToCharArray();

        for (var i = 0; i < charArray.Length; i++)
        {
            var ch = charArray[i];
            if (isLeftBracket(ch))
                stack.Push(ch);

            if (isRightBracket(ch))
            {
                if (stack.Count == 0) return false;

                var top = stack.Pop();
                if (!bracketsMatch(top, ch)) return false;
            }
        }

        return stack.Count == 0;
    }

    private bool isLeftBracket(char ch)
    {
        return leftBrackets.Contains(ch);
    }

    private bool isRightBracket(char ch)
    {
        return rightBrackets.Contains(ch);
    }

    private bool bracketsMatch(char left, char right)
    {
        return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
    }
}