using Xunit;
using CatalanParentheses.App;
using System.Diagnostics;

namespace CatalanParentheses.Tests
{
    public class CatalanCalculatorTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(4, 14)]
        [InlineData(5, 42)]
        [InlineData(6, 132)]
        [InlineData(7, 429)]
        [InlineData(15, 9694845)]
        public void TestCatalanNumbers(int input, int expected)
        {
            int actual = CatalanCalculator.CountWellFormedParenthesis(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PerformanceTest_n15_ShouldRunUnder500ms()
        {
            var stopwatch = Stopwatch.StartNew();
            int result = CatalanCalculator.CountWellFormedParenthesis(15);
            stopwatch.Stop();

            Assert.Equal(9694845, result);
            Assert.True(stopwatch.ElapsedMilliseconds < 500, $"Выполнялось слишком долго: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}