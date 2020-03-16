using System.Linq;
using Xunit;
using Math = TestMoshClassLibrary.Math;

namespace TestMoshXUnit
{
    public class MathTeste
    {
        private readonly Math _math;
        public MathTeste()
        {
            _math = new Math();
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(1, 2, 2)]
        [InlineData(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNUmbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5).ToList();

            Assert.NotEmpty(result);
            Assert.Equal(3, result.Count());
        }
    }
}
