namespace Challenge35_Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> a = graph.AddVertex("Amman");
            Vertex<string> b = graph.AddVertex("Irbid");
            Vertex<string> c = graph.AddVertex("Al-Karak");
            Vertex<string> d = graph.AddVertex("Aqaba");

            graph.AddEdge(a, b, 100);
            graph.AddEdge(b, c, 240);
            graph.AddEdge(c, d, 250);
            graph.AddEdge(c, a, 150);

            //Console.WriteLine("Vertices in the graph:");
            //foreach (var vertex in graph.GetVertices())
            //{
            //    Console.WriteLine(vertex.Value);
            //}

            //Console.WriteLine("\nNeighbors of Amman:");
            //var newYorkNeighbors = graph.GetNeighbors(a);
            //foreach (var edge in newYorkNeighbors)
            //{
            //    Console.WriteLine($"{edge.Vertex.Value} (Weight: {edge.Weight})");
            //}

            //Console.WriteLine("\nSize of the graph: " + graph.Size());

            Console.WriteLine("-------------------------------------");
            var x = graph.BreadthFirst(a);

            foreach (var item in x)
            {
               Console.WriteLine(item.Value);
            }
        }
    }
}
