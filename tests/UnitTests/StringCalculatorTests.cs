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
}