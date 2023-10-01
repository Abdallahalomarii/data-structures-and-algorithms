# Graph Implementaion 

### Description: 
 - This code provides a C# implementation of a graph data structure. It includes classes for Graph, Vertex, and Edge, allowing you to create and manipulate a graph with vertices and weighted edges.

### Approach & Efficiency
 - The code uses a dictionary to represent the adjacency list of the graph, where each vertex is associated with a list of edges connecting it to other vertices. The Graph class provides methods to add vertices and edges, retrieve vertices, neighbors, and the size of the graph.

   - Adding a vertex: O(1)
   - Adding an edge: O(1)
   - Retrieving vertices: O(V)
   - Retrieving neighbors: O(1)
   - Calculating the size: O(1)
   - Where V is the number of vertices in the graph.

### Solution
 -  To run the code, you can follow these steps:

    - Create a new C# console application project in your preferred development environment.

    - Copy and paste the provided code into your project files.

    - Build and run the application.
    
#### Here's an example of the code in action:

![code](./Code.png)

    ```

    Graph<string> graph = new Graph<string>();

    Vertex<string> a = graph.AddVertex("Amman");
    Vertex<string> b = graph.AddVertex("Irbid");
    Vertex<string> c = graph.AddVertex("Al-Karak");
    Vertex<string> d = graph.AddVertex("Aqaba");

    graph.AddEdge(a, b, 100);
    graph.AddEdge(b, c, 240);
    graph.AddEdge(c, d, 240);
    graph.AddEdge(c, a, 150);

    Console.WriteLine("Vertices in the graph:");
    foreach (var vertex in graph.GetVertices())
    {
        Console.WriteLine(vertex.Value);
    }

    Console.WriteLine("\nNeighbors of Amman:");
    var ammanNeighbors = graph.GetNeighbors(a);
    foreach (var edge in ammanNeighbors)
    {
        Console.WriteLine($"{edge.Vertex.Value} (Weight: {edge.Weight})");
    }

    Console.WriteLine("\nSize of the graph: " + graph.Size());
    ```

- This code creates a simple graph with four vertices and three weighted edges, then prints out the vertices, neighbors of the "Amman" vertex, and the size of the graph.