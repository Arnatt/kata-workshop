
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    public void SayFizzbuzzTest(int number,string expected)
    {
        // Arrange
        var suspect = new FizzBuzz();
        // Act
        var actual = suspect.SayFizzBuzz(number);
        // Assert
        actual.Should().Be(expected);
    }
}

