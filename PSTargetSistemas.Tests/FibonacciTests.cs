namespace PSTargetSistemas.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(-10, false)]
        [InlineData(0, true)]
        [InlineData(2, true)]
        [InlineData(21, true)]
        [InlineData(22, false)]

        public void TestIsInSequence(int number, bool expected)
        {
            Fibonacci fibonacci = new Fibonacci();
            bool actual = fibonacci.IsInSequence(number);
            Assert.Equal(expected, actual);
        }
    }
}