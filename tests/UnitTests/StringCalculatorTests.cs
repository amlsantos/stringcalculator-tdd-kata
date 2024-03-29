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

    [Theory]
    [InlineData("1\n2,3", 6)]
    [InlineData("11\n22,33", 66)]
    [InlineData("11,22\n33", 66)]
    [InlineData("11,22,33", 66)]
    public void Add_ReturnsSum_GivenThreeNumbersSepatatedWithCommaOrNewLIne(string input, int output)
    {
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//*\n1*2", 3)]
    [InlineData("//*\n1*2*3", 6)]
    [InlineData("//;\n1;2;3", 6)]
    public void Add_ReturnsSum_GivenCustomDelimeter(string input, int output)
    {
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }

    [Theory]
    [InlineData("-1,2", "Negatives not allowed: -1")]
    [InlineData("1,-2", "Negatives not allowed: -2")]
    [InlineData("1,-2,-3", "Negatives not allowed: -2,-3")]
    public void Add_ThrowsException_GivenNegativeInput(string input, string expectedExceptionMessage)
    {
        // act
        var result = () => _calculator.Add(input);

        // assert
        result.Should().Throw<InvalidOperationException>()
            .WithMessage(expectedExceptionMessage);
    }

    [Theory]
    [InlineData("1,1,1001", 2)]
    [InlineData("2,2000,2", 4)]
    [InlineData("10,1001,10", 20)]
    [InlineData("100,1000,100", 1200)]
    [InlineData("1000,1", 1001)]
    public void Add_ReturnsSumIgnoringOver1000_GivenNumbers(string input, int output)
    {
        // act
        var result = _calculator.Add(input);

        // assert
        result.Should().Be(output);
    }
}