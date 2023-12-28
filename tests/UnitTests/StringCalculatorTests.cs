using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;

    public StringCalculatorTests()
    {
        _calculator = new StringCalculator();
    }

    [Fact]
    public void Add_OnEmptyString_Returns0()
    {
        // arrange
        var emptyNumber = string.Empty;

        // act
        var result = _calculator.Add(emptyNumber);

        // assert
        result.Should().Be(0);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("10", 10)]
    public void Add_OnSingleNumber_ReturnsNumber(string input, int expectedOutput)
    {
        // arrange
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }
}