using Xunit;

namespace algoritms.Test
{
    public class FibonacciTest
    {
        private readonly Fibonacci _fibonacci;
        public FibonacciTest()
        {
            _fibonacci = new Fibonacci();
        }

        [Theory]
        [InlineData(new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 0, 1, 1 }, 3)]
        [InlineData(new int[] { 0, 1, 1, 2 }, 4)]
        [InlineData(new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, 10)]
        public void ShouldReturnSequence_WhenNumValue_For(int[] sequence, int num)
        {
            //var result = _fibonacci.Fibonacci_With_For(num);
            var result = _fibonacci.Fibonacci_With_For2(num);            

            Assert.Equal(sequence, result);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 1, 2 }, 4)]
        public void ShouldReturnSequence_WhenNumValue_Recursive(int[] sequence, int num)
        {
            var result = _fibonacci.Fibonacci_With_For(num);

            Assert.Equal(sequence, result);
        }
    }
}