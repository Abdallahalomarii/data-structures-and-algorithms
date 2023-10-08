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

# Breadth First challenge 36 

## white board 

 - ![white board](./WBBreadthfirst.jpg)

## Approach & Efficiency
 Approach:

The BFS (Breadth-First Search) algorithm starts from a given vertex and explores all its neighbors before moving on to their neighbors.
It uses a queue to keep track of the vertices to visit in a "first in, first out" order.
A HashSet is used to mark vertices as visited to avoid revisiting them.

Efficiency:

Time Complexity: O(V + E), where V is the number of vertices, and E is the number of edges in the graph.
Space Complexity: O(V), where V is the number of vertices.
       
    
## breadth first Code 

  - ![](Breadthfirst.png)


# Bussnis-trip challenge 37

## white board 

  - ![White board ](./bussnis-trip.jpg)


 ## Approach & Efficiency

 Approach:

The function first checks if the length of the itinerary is less than or equal to 1. If it is, the function returns null because a trip with less than 2 cities is not possible.

It initializes a totalCost variable to 0, which will be used to accumulate the cost of the trip.

The function iterates through the itinerary, one city at a time, and for each pair of consecutive cities, it checks if there is a direct flight available between them. It does this by:

Getting the current city and the next city from the itinerary.
Getting the current vertex from the graph based on the current city.
Checking the neighbors (direct flights) of the current vertex and searching for a neighbor that corresponds to the next city.
If a direct flight is found, it adds the cost of that flight to the totalCost. If not, it returns null because the trip is not possible.
After processing all cities in the itinerary, the function returns the accumulated totalCost if the trip is possible, or null if not.


Efficiency:

Time Complexity: The time complexity of this function is O(N), where N is the number of cities in the itinerary. This is because it iterates through the itinerary once, and for each pair of consecutive cities, it checks for a direct flight, which takes constant time in most cases since it typically involves looking up neighbors in the adjacency list of the graph.

Space Complexity: The space complexity is O(1) because it uses a fixed amount of memory regardless of the input size. The additional memory used for variables like totalCost and directFlightFound does not depend on the size of the input.


## Code :camera:

  - ![](./bussnis-trip.png)