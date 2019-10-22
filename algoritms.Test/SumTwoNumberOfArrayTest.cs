using Xunit;

namespace algoritms.Test
{
    public class SumTwoNumberOfArrayTest
    {
        private readonly SumTwoNumberOfArray _sumTwoNumberOfArray;
        public SumTwoNumberOfArrayTest()
        {
            _sumTwoNumberOfArray = new SumTwoNumberOfArray();
        }

        [Theory]
        //[InlineData(new int[] { 1, 2, 6, 9 }, 8, new int[] { 2, 6 })]
        //[InlineData(new int[] { 1, 2, 3, 9 }, 8, new int[] { -1, -1 })]
        [InlineData(new int[] { 1, 2, 4, 4 }, 8, new int[] { 4, 4 })]
        public void PairMatchingQuadraticTest(int[] arr, int num, int[] arrResult)
        {
            var result = _sumTwoNumberOfArray.PairMatchingQuadratic(arr, num);

            Assert.Equal(arrResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 6, 9 }, 8, new int[] { 2, 6 })]
        //[InlineData(new int[] { 1, 2, 3, 9 }, 8, new int[] { -1, -1 })]
        //[InlineData(new int[] { 1, 2, 4, 4 }, 8, new int[] { 4, 4 })]
        public void PairMatchingLinearTest(int[] arr, int num, int[] arrResult)
        {
            var result = _sumTwoNumberOfArray.PairMatchingLinear(arr, num);

            Assert.Equal(arrResult, result);
        }        
    }
}