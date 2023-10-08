namespace Challenge35_Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            //Vertex<string> a = graph.AddVertex("Amman");
            //Vertex<string> b = graph.AddVertex("Irbid");
            //Vertex<string> c = graph.AddVertex("Al-Karak");
            //Vertex<string> d = graph.AddVertex("Aqaba");

            //graph.AddEdge(a, b, 100);
            //graph.AddEdge(b, c, 240);
            //graph.AddEdge(c, d, 250);
            //graph.AddEdge(c, a, 150);

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

            //Console.WriteLine("-------------------------------------");
            //var x = graph.BreadthFirst(a);

            //foreach (var item in x)
            //{
            //   Console.WriteLine(item.Value);
            //}

            //string[] itinerary1 = new string[] { "Amman", "Irbid", "Al-Karak" };
            //string[] itinerary2 = new string[] { "Amman", "Irbid", "Al-Karak", "Aqaba" };
            //string[] itinerary3 = new string[] { "Amman", "Al-Karak", "Aqaba" };

            //// Calculate costs for the itineraries
            //int? cost1 = CalculateCost(graph, itinerary1);
            //int? cost2 = CalculateCost(graph, itinerary2);
            //int? cost3 = CalculateCost(graph, itinerary3);

            //Console.WriteLine("Cost for itinerary 1: " + (cost1.HasValue ? cost1.Value.ToString() : "Not possible"));
            //Console.WriteLine("Cost for itinerary 2: " + (cost2.HasValue ? cost2.Value.ToString() : "Not possible"));
            //Console.WriteLine("Cost for itinerary 3: " + (cost3.HasValue ? cost3.Value.ToString() : "Not possible"));

            Vertex<string> a = graph.AddVertex("Amman");
            Vertex<string> b = graph.AddVertex("Irbid");
            Vertex<string> c = graph.AddVertex("Al-Karak");
            Vertex<string> d = graph.AddVertex("Aqaba");

            graph.AddEdge(a, b, 100);
            graph.AddEdge(b, c, 240);
            graph.AddEdge(c, d, 250);
            graph.AddEdge(c, a, 150);

            Console.WriteLine("Depth-First Traversal:");
            var dfsResult = graph.DepthFirst(a);
            foreach (var vertex in dfsResult)
            {
                Console.Write($"{vertex.Value} -> ");
            }
            Console.WriteLine();
        }

        public static int? CalculateCost(Graph<string> graph, string[] itinerary)
        {
            if (itinerary.Length <= 1)
            {
                return null; // Trip is not possible with less than 2 cities.
            }

            int totalCost = 0;
            for (int i = 0; i < itinerary.Length - 1; i++)
            {
                var currentCity = itinerary[i];
                var nextCity = itinerary[i + 1];

                var cuurentVertix = graph.GetVertexByValue(currentCity);
                // Check if there's a direct flight from currentCity to nextCity.
                var neighbors = graph.GetNeighbors(cuurentVertix);
                var directFlightFound = false;

                foreach (var edge in neighbors)
                {
                    if (edge.Vertex.Value == nextCity)
                    {
                        totalCost += edge.Weight;
                        directFlightFound = true;
                        break;
                    }
                }

                if (!directFlightFound)
                {
                    return null; // Direct flight not available, trip is not possible.
                }
            }
            return totalCost;
        }
    }
}
