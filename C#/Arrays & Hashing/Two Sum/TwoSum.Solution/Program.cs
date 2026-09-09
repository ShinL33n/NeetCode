namespace TwoSum.Solution;
class Program
{
    static void Main(string[] args)
    {
        int[] result = Solution.TwoSum([1,8,3,3,5,8,9,9,9], 16);

        foreach(int i in result)
            Console.Write($"{i},");
    }
}
      //  {new[] {1,3,5,7,8,8,9,9,9}, 14, new[] {2,6}},
      //  {new[] {10,4,56,3,11,24}, 59, new[] {2,3}}
       // {new[] {5,5}, 10, new[] {0,1}},

       //  0 1 2 3 4 5 6 7 8
       // {1,8,3,3,5,8,9,9,9} 16 [1,5]
      

      // nums[i] - target == -nums[j]
      // target - nums[i] == nums[j] 

public static class Solution {
    public static int[] TwoSum(int[] nums, int target)
    {
        int differance;
        Dictionary<int, int> diffIndex = [];

        for(int i = 0; i < nums.Length; i++)
        {
            differance = target - nums[i];
            if (diffIndex.ContainsKey(differance))
                return [diffIndex[differance],i];
            else if (!diffIndex.ContainsKey(nums[i]))
                diffIndex.Add(nums[i],i);
        }

        return [0,0];
    }
}

