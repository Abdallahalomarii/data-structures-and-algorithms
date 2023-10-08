using Challenge35_Graph;

namespace depth_first_test
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertex_AddsVertexToGraph()
        {
            // Arrange
            var graph = new Graph<string>();

            // Act
            var vertexA = graph.AddVertex("A");

            // Assert
            Assert.Equal(1, graph.Size());
            Assert.Contains(vertexA, graph.GetVertices());
        }

        [Fact]
        public void AddEdge_AddsEdgeToGraph()
        {
            // Arrange
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");

            // Act
            graph.AddEdge(vertexA, vertexB);

            // Assert
            var neighborsA = graph.GetNeighbors(vertexA);
            var neighborsB = graph.GetNeighbors(vertexB);
            Assert.Contains(neighborsA, edge => edge.Vertex == vertexB);
            Assert.Contains(neighborsB, edge => edge.Vertex == vertexA);
        }
        [Fact]
        public void DepthFirst_TraversalReturnsExpectedOrder()
        {
            // Arrange
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");
            var vertexC = graph.AddVertex("C");
            var vertexD = graph.AddVertex("D");

            graph.AddEdge(vertexA, vertexB);
            graph.AddEdge(vertexA, vertexC);
            graph.AddEdge(vertexB, vertexD);

            // Act
            var dfsResult = graph.DepthFirst(vertexA);

            // Assert
            var expectedOrder = new[] { "A", "B", "D", "C" };
            Assert.Equal(expectedOrder, dfsResult.Select(v => v.Value));
        }
    }
}