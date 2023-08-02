using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15_BinaryTree
{
    public class BinarySearchTree : BinaryTree
    {
        public Node? Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(int data)
        {
            Root = new Node(data);
        }

        public void Add(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }

            Node node = Root;
            while (true)
            {
                if (data < node.Data)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node(data);
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
                        node.Right = new Node(data);
                        break;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }
        }


        public bool Contains(int data)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                Node containNode = Root;
                while (containNode != null)
                {
                    if (containNode.Data == data)
                    {
                        return true;
                    }
                    else if (containNode.Data > data)
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

        public int FindMax()
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
                Node currentChild = Root;
                int maxValue = int.MinValue;
                while (currentChild != null)
                {
                    if (currentChild.Data > maxValue)
                    {
                        maxValue = currentChild.Data;
                       
                    }
                    else if (currentChild.Data < maxValue)
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
