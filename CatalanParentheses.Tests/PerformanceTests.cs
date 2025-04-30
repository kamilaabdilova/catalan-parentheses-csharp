using Xunit;
using CatalanParentheses.App;
using System.Diagnostics;

namespace CatalanParentheses.Tests
{
    public class PerformanceTests
    {
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