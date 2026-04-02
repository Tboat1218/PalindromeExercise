using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("level", true)]
        [InlineData("hello", false)]
        [InlineData("world", false)]
        [InlineData("RaceCar", true)]
        public void IsAPalindrome_GivenAWord_ReturnsExpectedResult(string word, bool expected)
        {
            // Arrange
            WordSmith wordSmith = new WordSmith();

            // Act
            bool actual = wordSmith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}