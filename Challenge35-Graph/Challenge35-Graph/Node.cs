using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge35_Graph
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node()
        {
            Neighbors = new List<Node>();
        }
    }
}
