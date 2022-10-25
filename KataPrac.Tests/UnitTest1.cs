using kataPrac;
using FluentAssertions;

namespace KataPrac.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void ToJadenCaseTest()
    {
        var responce = katas.ToJadenCase("How   can mirrors be real if our eyes aren't real");
        responce.Should().Be("How Can Mirrors Be Real If Our Eyes Aren't Real");
    }

    [Fact]
    public void SeriesSum1()
    {
        var responce = katas.seriesSum(5);
        responce.Should().Be("1.75");


    }
    [Fact]
    public void SeriesSum2()
    {
        var responce = katas.seriesSum(0);
        responce.Should().Be("0.00");
    }
}