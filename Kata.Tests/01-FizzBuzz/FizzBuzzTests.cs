
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
    [InlineData(30, "FizzBuzz")]
    [InlineData(90, "FizzBuzz")]
    [InlineData(99, "Fizz")]
    [InlineData(100, "Buzz")]
    
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

