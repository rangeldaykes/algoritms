using Xunit;

namespace algoritms.Test
{

    public class FactorialTest
    {
        private readonly Factorial _factorial;
        public FactorialTest()
        {
            _factorial = new Factorial();
        }

        [Fact]
        public void ShouldReturn120_WhenInputIs5()
        {
            // Given
            var value = 5;

            //When
            var result = _factorial.Factorial_With_While(value);

            //Then
            Assert.Equal(120, result);
        }

        [Theory]
        [InlineData(120, 5)]
        [InlineData(24, 4)]
        [InlineData(6, 3)]
        [InlineData(2, 2)]
        public void ShouldReturnFact_WhenInputIsValue_For(int fact, int value)
        {
            var result = _factorial.Factorial_With_For(value);
            
            Assert.Equal(fact, result);
        }

        [Theory]
        [InlineData(120, 5)]
        [InlineData(24, 4)]
        [InlineData(6, 3)]
        [InlineData(2, 2)]
        public void ShouldReturnFact_WhenInputIsValue_Recursive(int fact, int value)
        {
            var result = _factorial.Factorial_With_Recursive(value);
            
            Assert.Equal(fact, result);
        }
    }
}