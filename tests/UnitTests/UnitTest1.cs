using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        1.Should().Be(1);
    }
}