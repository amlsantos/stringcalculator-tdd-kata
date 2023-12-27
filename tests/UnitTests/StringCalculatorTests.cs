using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;

    public StringCalculatorTests() =>
        _calculator = new StringCalculator();

    [Fact]
    public void Add_Returns0_GivenEmptyString()
    {
        // act
        var result = _calculator.Add("");

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
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("2,2", 4)]
    [InlineData("10,10", 20)]
    [InlineData("100,100", 200)]
    public void Add_ReturnsSum_GivenTwoNumbers(string input, int output)
    {
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }

    [Theory]
    [InlineData("1,1,1", 3)]
    [InlineData("2,2,2", 6)]
    [InlineData("10,10,10", 30)]
    [InlineData("100,100,100", 300)]
    public void Add_ReturnsSum_GivenThreeNumbers(string input, int output)
    {
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }
}