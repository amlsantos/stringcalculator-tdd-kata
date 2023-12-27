using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class StringCalculatorTests
{
    [Fact]
    public void Add_Returns0_GivenEmptyString()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add("");

        // assert
        result.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("10", 10)]
    [InlineData("100", 100)]
    public void Add_ReturnsNumber_GivenNumber(string input, int output)
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(input);

        // assert
        result.Should().Be(output);
    }
}