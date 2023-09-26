using Challange_33_Hashmap_LeftJoin;

namespace TestLeftJoin
{
    public class UnitTest1
    {
        [Fact]
        public void LeftJoin_WithCommonKeys_ShouldReturnJoinedValues()
        {
            // Arrange
            HashMap<string, string> map1 = new HashMap<string, string>();
            map1.Set("A", "Apple");
            map1.Set("B", "Banana");
            map1.Set("C", "Cherry");


            HashMap<string, string> map2 = new HashMap<string, string>();

            map2.Set("B", "Blueberry");
            map2.Set("D", "Date");


            // Act
            List<List<string>> result = Program.LeftJoin(map1, map2);

            // Assert
            Assert.Collection(result,
                row => Assert.Equal(new List<string> { "A", "Apple", null }, row),
                row => Assert.Equal(new List<string> { "B", "Banana", "Blueberry" }, row),
                row => Assert.Equal(new List<string> { "C", "Cherry", null }, row)
            );
        }

        [Fact]
        public void LeftJoin_WithEmptyHashMaps_ShouldReturnEmptyList()
        {
            // Arrange
            HashMap<string, string> map1 = new HashMap<string, string>();
            HashMap<string, string> map2 = new HashMap<string, string>();

            // Act
            List<List<string>> result = Program.LeftJoin(map1, map2);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void LeftJoin_WithNullValues_ShouldReturnJoinedValuesIncludingNulls()
        {
            // Arrange
            HashMap<string, string> map1 = new HashMap<string, string>();
            map1.Set("A", "Apple");
            map1.Set("B", "Banana");
            map1.Set("C", "Cherry");

            HashMap<string, string> map2 = new HashMap<string, string>();
            map2.Set("B", "Blueberry");
            map2.Set("D", "anything");


            // Act
            List<List<string>> result = Program.LeftJoin(map1, map2);

            // Assert
            Assert.Collection(result,
                row => Assert.Equal(new List<string> { "A", "Apple", null }, row),
                row => Assert.Equal(new List<string> { "B", "Banana",  "Blueberry"  }, row),
                row => Assert.Equal(new List<string> { "C", "Cherry", null }, row)
            );
        }
    }
}