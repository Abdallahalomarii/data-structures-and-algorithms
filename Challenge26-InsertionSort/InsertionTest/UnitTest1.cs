using Challenge26_InsertionSort;

namespace InsertionTest
{
    public class UnitTest1
    {
        public class InsertionTests
        {
            [Theory]
            [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
            [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
            [InlineData(new int[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2,5,8,12,18,20 })]
            [InlineData(new int[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5,5,5,7,7,12 })]
            [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
            [InlineData(new int[] { }, new int[] { })]
            public void InsertionSort_ShouldSortArray(int[] inputArray, int[] expectedSortedArray)
            {
                // Arrange
                Insertion insertion = new Insertion();

                // Act
                int[] sortedArray = insertion.InsertionSort(inputArray);

                // Assert
                Assert.Equal(expectedSortedArray, sortedArray);
            }
        }
    }
}