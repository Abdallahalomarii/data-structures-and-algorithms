using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange32_TreeInterSection
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public Node()
        {
            Left = null;
            Right = null;
        }
        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

}
