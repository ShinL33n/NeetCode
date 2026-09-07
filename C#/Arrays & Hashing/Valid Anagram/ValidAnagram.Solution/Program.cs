namespace ValidAnagram.Solution;
class Program
{
    static void Main(string[] args)
    {
        bool result = Solution.IsAnagram("racecar", "carrace");
        Console.WriteLine(result);
    }
}

public static class Solution {
    public static bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> charCount = [];

        foreach(char c in s)
        {
            if(charCount.ContainsKey(c)) charCount[c] += 1;
            else charCount[c] = 1;
        }

        foreach(char c in t)
        {
            if(!charCount.ContainsKey(c)) return false;
            charCount[c] -= 1;
            if(charCount[c] == 0) charCount.Remove(c);
        }

        return !charCount.Any();
    }
}

