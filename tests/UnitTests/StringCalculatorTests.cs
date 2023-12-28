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

    [Theory]
    [InlineData("1\n1,1", 3)]
    [InlineData("2\n1,2", 5)]
    [InlineData("1\n2,3", 6)]
    public void Add_OnNewLinesAndCommaWithMultipleIntegers_ReturnsCorrectSum(string input, int expectedOutput)
    {
        // arrange
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n1;2;3", 6)]
    [InlineData("//*\n1*2*3*4", 10)]
    public void Add_OnDifferentDelimeter_ReturnsCorrectSum(string input, int expectedOutput)
    {
        // arrange
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(expectedOutput);
    }

    [Theory]
    [InlineData("-1,2", "Negatives not allowed: -1")]
    [InlineData("1,-2", "Negatives not allowed: -2")]
    [InlineData("2,-4,3,-5", "Negatives not allowed: -4,-5")]
    public void Add_OnNegativeIntegers_ThrowsException(string input, string expectedExceptionMessage)
    {
        // arrange
        // act
        var result = () => _calculator.Add(input);

        // assert
        result.Should().Throw<InvalidOperationException>()
        .WithMessage(expectedExceptionMessage);
    }
}