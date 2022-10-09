using System.Text;

public class StringUtils
{
    public static int CountVowels(string str)
    {
        if (str == null)
            return 0;

        int count = 0;
        string vowels = "aeiou";
        foreach (var ch in str.ToLowerInvariant().ToCharArray())
            if (vowels.IndexOf(ch) != -1)
                count++;

        return count;
    }

    public static string Reverse(string str)
    {
        if (str == null)
            return "";

        StringBuilder reversed = new StringBuilder();
        for (var i = str.Length - 1; i >= 0; i--)
            reversed.Append(str[i]);

        return reversed.ToString();
    }

    public static String ReverseWords(string sentence)
    {
        if (sentence == null)
            return "";

        string[] words = sentence.Trim().Split(" ");
        words.Reverse();
        return string.Join(" ", words);
    }

    public static bool AreRotations(
              string str1, string str2)
    {
        if (str1 == null || str2 == null)
            return false;

        return (str1.Length == str2.Length &&
                (str1 + str1).Contains(str2));
    }

    public static string RemoveDuplicates(string str)
    {
        if (str == null)
            return "";

        StringBuilder output = new StringBuilder();
        HashSet<Char> seen = new HashSet<Char>();

        foreach (var ch in str.ToCharArray())
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                output.Append(ch);
            }
        }

        return output.ToString();
    }

    public static char GetMaxOccuringChar(string str)
    {
        if (str == null || string.IsNullOrEmpty(str))
            throw new Exception("String cannot be null!");

        const int ASCII_SIZE = 256;
        int[] frequencies = new int[ASCII_SIZE];
        foreach (var ch in str.ToCharArray())
            frequencies[ch]++;

        int max = 0;
        char result = ' ';
        for (var i = 0; i < frequencies.Length; i++)
            if (frequencies[i] > max)
            {
                max = frequencies[i];
                result = (char)i;
            }

        return result;
    }

    public static string capitalize(string sentence)
    {
        if (sentence == null || string.IsNullOrEmpty(sentence.Trim()))
            return "";

        string[] words = sentence
                          .Trim()
                          .Replace(" +", " ")
                          .Split(" ");

        for (var i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Substring(0, 1).ToUpperInvariant()
                        + words[i].Substring(1).ToLowerInvariant();
        }

        return string.Join(" ", words);
    }


    //O(n log n)
    public static bool areAnagrams(
        string first, string second
    )
    {
        if (first == null || second == null)
            return false;

        var list1 = first.ToLowerInvariant().ToList();

        list1.Sort();

        var list2 = second.ToLowerInvariant().ToList();
        list2.Sort();

        return list1.SequenceEqual(list2);
    }

    // O(n)
    public static bool areAnagram2(
      string first, string second
    )
    {
        if (first == null || second == null)
            return false;

        const int ENGLISH_ALPHABET = 26;
        int[] frequencies = new int[ENGLISH_ALPHABET];

        first = first.ToLowerInvariant();
        for (var i = 0; i < first.Length; i++)
            frequencies[first[i] - 'a']++;

        second = second.ToLowerInvariant();
        for (var i = 0; i < second.Length; i++)
        {
            var index = second[i] - 'a';
            if (frequencies[index] == 0)
                return false;

            frequencies[index]--;
        }

        return true;
    }

    public static bool isPalindrome(string word)
    {
        if (word == null)
            return false;

        int left = 0;
        int right = word.Length - 1;

        while (left < right)
            if (word[left++] != word[right--])
                return false;

        return true;
    }
}