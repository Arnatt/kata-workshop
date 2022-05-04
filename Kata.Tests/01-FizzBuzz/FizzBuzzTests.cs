
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTest
{
    [Fact]
    public void SayFizzbuzzTest()
    {
        // Arrange
        var expect = new FizzBuzz();
        // Act
        var actual = expect.SayFizzBuzz(1);
        // Assert
        actual.Should().Be("1");
    }
}

