public class CharFinder
{

    public char findFirstNonRepeatingChar(string value)
    {
        Dictionary<char, int> items = new Dictionary<char, int>();

        var chars = value.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            var count = items.ContainsKey(chars[i]) ? items.GetValueOrDefault(chars[i]) : 0;
            items[chars[i]] = count + 1;
        }

        for (var i = 0; i < chars.Length; i++)
            if (items.GetValueOrDefault(chars[i]) == 1)
                return chars[i];

        return Char.MinValue;
    }

    public char findFirstRepeatingChar(string value)
    {
        Dictionary<char, int> items = new Dictionary<char, int>();

        var chars = value.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            var count = items.ContainsKey(chars[i]) ? items.GetValueOrDefault(chars[i]) : 0;
            items[chars[i]] = count + 1;
        }

        for (var i = 0; i < chars.Length; i++)
            if (items.GetValueOrDefault(chars[i]) > 1)
                return chars[i];

        return Char.MinValue;
    }
}