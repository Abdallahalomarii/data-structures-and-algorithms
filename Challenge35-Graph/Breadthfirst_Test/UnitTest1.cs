using Challenge35_Graph;

namespace Breadthfirst_Test
{
    public class UnitTest1
    {
        [Fact]
        public void BreadthFirst_ShouldReturnBFSOrder_WhenGraphIsTraversable()
        {
            // Arrange
            var graph = new Graph<int>();
            var vertexA = graph.AddVertex(1);
            var vertexB = graph.AddVertex(2);
            var vertexC = graph.AddVertex(3);
            var vertexD = graph.AddVertex(4);
            var vertexE = graph.AddVertex(5);

            graph.AddEdge(vertexA, vertexB);
            graph.AddEdge(vertexA, vertexC);
            graph.AddEdge(vertexB, vertexD);
            graph.AddEdge(vertexC, vertexE);

            // Act
            var bfsOrder = graph.BreadthFirst(vertexA);

            // Assert
            var expectedBfsOrder = new List<Vertex<int>> { vertexA, vertexB, vertexC, vertexD, vertexE };
            Assert.Equal(expectedBfsOrder, bfsOrder);
        }

        [Fact]
        public void BreadthFirst_ShouldThrowException_WhenStartVertexNotInGraph()
        {
            // Arrange
            var graph = new Graph<int>();
            var startVertex = new Vertex<int>(1);

            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => graph.BreadthFirst(startVertex));
            Assert.Equal("Start vertex is not in the graph.", exception.Message);
        }

        [Fact]
        public void BreadthFirst_ShouldReturnSingleVertex_WhenGraphHasOnlyOneVertex()
        {
            // Arrange
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("Test1");

            // Act
            var bfsOrder = graph.BreadthFirst(vertexA);

            // Assert
            var expectedBfsOrder = new List<Vertex<string>> { vertexA };
            Assert.Equal(expectedBfsOrder, bfsOrder);
        }
    }
}