using Xunit;
using CatalanParentheses.App;

namespace CatalanParentheses.Tests
{
    public class CatalanUnitTests
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
        public void CountWellFormedParenthesis_ShouldReturnExpected(int input, int expected)
        {
            int actual = CatalanCalculator.CountWellFormedParenthesis(input);
            Assert.Equal(expected, actual);
        }
    }
}