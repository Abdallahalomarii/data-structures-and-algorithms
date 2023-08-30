using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15_BinaryTree
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(T data)
        {
            Root = new Node<T>(data);
        }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                return;
            }

            Node<T> node = Root;
            while (true)
            {
                if (data.CompareTo(node.Data) < 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node<T>(data);
                        break;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node<T>(data);
                        break;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }
        }


        public bool Contains(T data)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                Node<T> containNode = Root;
                while (containNode != null)
                {
                    if (containNode.Data.Equals(data))
                    {
                        return true;
                    }
                    else if (containNode.Data.CompareTo(data) > 0)
                    {
                        containNode = containNode.Left;
                    }
                    else
                    {
                        containNode = containNode.Right;
                    }
                }
                return false;
            }
        }

        public T FindMax()
        {
            if (Root == null)
            {
                throw new Exception("The Tree is Empty");
            }
            else if (Root.Left == null && Root.Right == null)
            {
                return Root.Data;
            }
            else
            {
                Node<T> currentChild = Root;
                T maxValue = default(T);
                while (currentChild != null)
                {
                    if (currentChild.Data.CompareTo(maxValue) > 0)
                    {
                        maxValue = currentChild.Data;
                    }
                    else if (currentChild.Data.CompareTo(maxValue) < 0)
                    {
                        currentChild = currentChild.Left;
                    }
                    else
                    {
                        currentChild = currentChild.Right;
                    }
                }
                return maxValue;
            }
        }
    }
}
