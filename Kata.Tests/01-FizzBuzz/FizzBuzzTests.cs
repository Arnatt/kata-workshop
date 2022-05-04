
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
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

