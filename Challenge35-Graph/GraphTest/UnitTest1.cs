using Challenge35_Graph;

namespace GraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void VertexCanBeSuccessfullyAdded()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();

            // Act
            Vertex<string> vertex = graph.AddVertex("TestVertex");

            // Assert
            Assert.NotNull(vertex);
            Assert.Equal("TestVertex", vertex.Value);
        }

        [Fact]
        public void EdgeCanBeSuccessfullyAdded()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");

            // Act
            graph.AddEdge(vertexA, vertexB, 5);

            // Assert
            // Add assertions as needed to ensure the edge is properly added.
        }
        [Fact]
        public void AllVerticesCanBeRetrieved()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            // Act
            var vertices = graph.GetVertices();

            // Assert
            Assert.Collection(vertices,
                v => Assert.Equal("A", v.Value),
                v => Assert.Equal("B", v.Value),
                v => Assert.Equal("C", v.Value));
        }
        [Fact]
        public void NeighborsCanBeRetrieved()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            // Act
            var neighbors = graph.GetNeighbors(vertexA);

            // Assert
            // Add assertions as needed to ensure the neighbors are properly retrieved.
        }
        [Fact]
        public void NeighborsIncludeWeights()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            // Act
            var neighbors = graph.GetNeighbors(vertexA);

            // Assert
            // Add assertions to ensure that the neighbors' weights are included.
        }
        [Fact]
        public void ProperSizeIsReturned()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            // Act
            int size = graph.Size();

            // Assert
            Assert.Equal(3, size);
        }
        [Fact]
        public void GraphWithOneVertexAndEdge()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 5);

            // Act
            // Perform assertions to ensure the graph structure is as expected.
        }

    }
}