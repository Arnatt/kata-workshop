
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTest
{
    [Theory]
    [InlineData(1, "1")]
    public void SayFizzbuzzTest(int nuber,string expected)
    {
        // Arrange
        var suspect = new FizzBuzz();
        // Act
        var actual = suspect.SayFizzBuzz(nuber);
        // Assert
        actual.Should().Be(expected);
    }
}

