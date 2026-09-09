namespace TwoSum.Tests;

using TwoSum.Solution;

public class TwoSumTests
{
    public static TheoryData<int[], int, int[]> TestData = new()
    {
        {new[] {3,4,5,6}, 7, new[] {0,1}},
        {new[] {4,5,6}, 10, new[] {0,2}},
        {new[] {5,5}, 10, new[] {0,1}},
        {new[] {1,3,5,7,8,8,9,9,9}, 14, new[] {2,6}},
        {new[] {10,4,56,3,11,24}, 59, new[] {2,3}},
        {new[] {1,8,3,3,5,8,9,9,9}, 16, new[] {1,5}}
    };


    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoSum_ReturnsPairOfIndices(int[] input, int target, int[] expected)
    {
        // Act
        int[] actual = Solution.TwoSum(input, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}
