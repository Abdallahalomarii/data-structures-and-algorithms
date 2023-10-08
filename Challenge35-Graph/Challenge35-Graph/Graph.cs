using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge35_Graph
{
    public class Graph<T>
    {

        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> node = new Vertex<T>(value);

            AdjacencyList[node] = new List<Edge<T>>();
            return node;
        }

        public void AddEdge(Vertex<T> vertex1, Vertex<T> vertex2, int weight = 0)
        {
            if (!AdjacencyList.ContainsKey(vertex1) || !AdjacencyList.ContainsKey(vertex2))
            {
                throw new ArgumentException("Both vertices should already be in the graph");
            }

            AdjacencyList[vertex1].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex2,
            });

            AdjacencyList[vertex2].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex1,
            });
        }

        public List<Vertex<T>> GetVertices()
        {
            return new List<Vertex<T>>(AdjacencyList.Keys);
        }

        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            if (AdjacencyList.ContainsKey(vertex))
            {
                return AdjacencyList[vertex];
            }
            else
            {
                return new List<Edge<T>>();
            }
        }

        public int Size()
        {
            return AdjacencyList.Count;
        }

        public void Print()
        {
            foreach (var item in AdjacencyList)
            {
                Console.Write($"Vertex {item.Key.Value} =>");

                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value} (Weight: {edge.Weight}) =>");
                }

                Console.WriteLine();
            }
        }

        public List<Vertex<T>> BreadthFirst(Vertex<T> startVertex)
        {
            if (!AdjacencyList.ContainsKey(startVertex))
                throw new InvalidOperationException("Start vertex is not in the graph.");

            List<Vertex<T>> visitedNodes = new List<Vertex<T>>();
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();
                visitedNodes.Add(currentVertex);

                foreach (var edge in AdjacencyList[currentVertex])
                {
                    if (!visited.Contains(edge.Vertex))
                    {
                        visited.Add(edge.Vertex);
                        queue.Enqueue(edge.Vertex);
                    }
                }
            }
                return visitedNodes;
        }

    }


}
