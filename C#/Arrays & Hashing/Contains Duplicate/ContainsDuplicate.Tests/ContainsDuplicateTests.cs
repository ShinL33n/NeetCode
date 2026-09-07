namespace ContainsDuplicate.Tests;

using ContainsDuplicate.Solution;

public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3 })]
    [InlineData(new int[] { 1, Int32.MaxValue, Int32.MaxValue, 3 })]
    public void hasDuplicate_ReturnsTrueWhenArrayContainsDuplicate(int[] input)
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = Solution.hasDuplicate(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, Int32.MaxValue, Int32.MinValue, 3 })]
    public void hasDuplicate_ReturnsFailsWhenArrayDoesNotContainDuplicate(int[] input)
    {
        // Arrange
        bool expected = false;

        // Act
        bool actual = Solution.hasDuplicate(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
