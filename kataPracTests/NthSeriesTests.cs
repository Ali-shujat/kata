
using kataPrac;
using Xunit;
using FluentAssertions;


namespace kataPracTests
{
   
    public class NthSeriesTests
    {

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
}
