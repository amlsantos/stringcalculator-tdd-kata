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

    [Fact]
    public void Add_Returns1_GivenStringWith1()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add("1");

        // assert
        result.Should().Be(1);
    }

    [Fact]
    public void Add_Returns2_GivenStringWithOneNumber()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add("2");

        // assert
        result.Should().Be(2);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
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