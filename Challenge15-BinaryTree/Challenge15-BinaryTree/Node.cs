using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15_BinaryTree
{
    public class Node
    {
        public int Data { get; set; }

        public Node? Left { get; set; }

        public Node? Right { get; set; }

        public Node()
        {
            Left = null;
            Right = null;
        }
        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
