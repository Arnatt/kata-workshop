using Xunit;
using System;
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTest
{
    /*
    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void ThrowArgumentExceptionWhenNumberNotInRuleTest(int number)
    {
        // Arrange
        var exception = Assert.Throws<ArgumentException>(() => FizzBuzz.PrintFizzBuzz(number));
        Assert.IsType<string>(string.Format("entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.",number));
    
    }
    */
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(4, "4")]
    [InlineData(6, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(90, "FizzBuzz")]
    [InlineData(99, "Fizz")]
    [InlineData(100, "Buzz")]
    [InlineData(0, "Enter number should be between 1 to 100")]
    [InlineData(101, "Enter number should be between 1 to 100")] 
    
    public void SingleNumberTest(int number,string expected)
    {
        // Arrange
        var suspect = new FizzBuzz();
        // Act
        var actual = suspect.SayFizzBuzz(number);
        // Assert
        actual.Should().Be(expected);
    }
    
}

