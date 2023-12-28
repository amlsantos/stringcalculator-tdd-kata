using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class StringCalculatorTests
{
    [Fact]
    public void Add_OnEmptyString_Returns0()
    {
        // arrange
        var emptyNumber = string.Empty;
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(emptyNumber);

        // assert
        result.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("10", 10)]
    public void Add_OnSingleNumber_ReturnsNumber(string input, int output)
    {
        // arrange
        var number = input;
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(number);

        // assert
        result.Should().Be(output);
    }
}