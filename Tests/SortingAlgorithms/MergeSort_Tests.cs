using MergeSort;
using Xunit;

namespace Tests.SortingAlgorithms
{
    public class MergeSort_Tests
    {
        [Theory]
        [InlineData(new int[] { 34, 63, 11, 61, 6, 0 }, new int[] { 0, 6, 11, 34, 61, 63 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void MergeSort_Success(int[] input, int[] expected)
        {
            Algorithm.MergeSort(input);

            Assert.Equal(input, expected);
        }
    }
}
