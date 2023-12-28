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

    [Fact]
    public void Add_OnSingleNumber_ReturnsNumber()
    {
        // arrange
        var number = "1";
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add(number);

        // assert
        result.Should().Be(int.Parse(number));
    }
}