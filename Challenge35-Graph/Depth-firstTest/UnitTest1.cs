using Challenge35_Graph;

namespace Depth_firstTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateCost_ReturnsCostForValidItinerary()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            var cityA = graph.AddVertex("A");
            var cityB = graph.AddVertex("B");
            var cityC = graph.AddVertex("C");
            graph.AddEdge(cityA, cityB, 100);
            graph.AddEdge(cityB, cityC, 150);

            // Act
            var itinerary = new List<string> { "A", "B", "C" };
            var cost = Program.CalculateCost(graph, itinerary);

            // Assert
            Assert.Equal(250, cost);
        }

        [Fact]
        public void CalculateCost_ReturnsNullForInvalidItinerary()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            var cityA = graph.AddVertex("A");
            var cityB = graph.AddVertex("B");
            var cityC = graph.AddVertex("C");
            graph.AddEdge(cityA, cityB, 100);

            // Act
            var itinerary = new List<string> { "A", "C" };
            var cost = Program.CalculateCost(graph, itinerary);

            // Assert
            Assert.Null(cost);
        }

        [Fact]
        public void CalculateCost_ReturnsNullForEmptyItinerary()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            var cityA = graph.AddVertex("A");

            // Act
            var itinerary = new List<string>();
            var cost = Program.CalculateCost(graph, itinerary);

            // Assert
            Assert.Null(cost);
        }
    }
}