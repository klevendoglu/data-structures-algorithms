using System.Collections;
using System.Text;

public class StringReverserWithStack
{    
    public string reverse(string toReverse)
    {
        if (toReverse == null) throw new ArgumentNullException();

        Stack<char> stack = new Stack<char>();
        var charArray = toReverse.ToCharArray();

        for (var i = 0; i < charArray.Length; i++)
        {
            var current = charArray[i];
            stack.Push(current);
        }

        StringBuilder reversed = new StringBuilder();
        while (stack.Count > 0)
            reversed.Append(stack.Pop());

        return reversed.ToString();
    }    

}