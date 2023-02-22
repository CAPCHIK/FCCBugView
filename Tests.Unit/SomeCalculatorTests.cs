using FCCBugView;

namespace Tests.Unit
{
    public class SomeCalculatorTests
    {
        private SomeCalculator calculator = new SomeCalculator();
        [Theory]
        [InlineData(1, 1, 2)]
        public void SumTests(int a, int b, int sum)
        {
            Assert.Equal(sum, calculator.Sum(a, b));
        }
    }
}