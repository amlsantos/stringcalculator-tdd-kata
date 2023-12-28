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
    public void Add_On1Integer_ReturnsNumber(string input, int expectedOutput)
    {
        // arrange
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }

    
    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("2,1", 3)]
    [InlineData("10,20", 30)]
    public void Add_On2Integers_ReturnsCorrectSum(string input, int expectedOutput)
    {
        // arrange

        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }

    [Theory]
    [InlineData("1,1,1", 3)]
    [InlineData("2,1,2", 5)]
    [InlineData("10,20,30,40,50", 150)]
    public void Add_OnMultipleIntegers_ReturnsCorrectSum(string input, int expectedOutput)
    {
        // arrange

        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }
}