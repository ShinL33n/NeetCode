namespace ContainsDuplicate.Solution;
class Program
{
    static void Main(string[] args)
    {
        bool result = Solution.hasDuplicate(new int[] { 1, 2, 3, 1 });
        Console.WriteLine(result);
    }
}

public static class Solution {
    public static bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        if(nums.Length <= 0 || nums.Length > 100000) return false;
        
        foreach (int num in nums)
        {
            if(set.Contains(num)) {
                return true;
            }
            set.Add(num);
        }
        
        return false;
    }
}

