namespace ValidAnagram.Tests;

using ValidAnagram.Solution;

public class ValidAnagramTests
{
    [Theory]
    [InlineData("racecar", "carrace")]
    [InlineData("rrrrrr", "rrrrrr")]
    public void IsAnagram_ReturnTrueIfStringsAreAnagrams(string input1, string input2)
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = Solution.IsAnagram(input1, input2);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("jar", "car")]
    [InlineData("aabb", "bbcc")]
    [InlineData("rrrrrr", "rrrrrrrrrrrrrrrr")]
    public void IsAnagram_ReturnFalseIfStringsAreNotAnagrams(string input1, string input2)
    {
        // Arrange
        bool expected = false;

        // Act
        bool actual = Solution.IsAnagram(input1, input2);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("", "carrace")]
    [InlineData("racecar", "")]
    public void IsAnagram_ReturnFalseIfOneStringIsEmpty(string input1, string input2)
    {
        // Arrange
        bool expected = false;

        // Act
        bool actual = Solution.IsAnagram(input1, input2);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsAnagram_ReturnTrueIfStringsAreEmpty()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = Solution.IsAnagram("", "");
        
        // Assert
        Assert.Equal(expected, actual);
    }
}
