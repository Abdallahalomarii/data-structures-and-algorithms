using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challange32_TreeInterSection
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<int> Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node<int> InsertRecursive(Node<int> root, int data)
        {
            if (root == null)
            {
                return new Node<int>(data);
            }

            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRecursive(root.Right, data);
            }

            return root;
        }
        public T[] PreOder(Node<T>? node, List<T> list)
        {
            if (node == null)
            {
                return new T[0];
            }
            list.Add(node.Data);
            PreOder(node.Left, list);
            PreOder(node.Right, list);
            return list.ToArray();
        }

        public T[] InOrder(Node<T>? node, List<T> list)
        {
            if (node == null)
            { return new T[0]; }

            InOrder(node.Left, list);
            list.Add(node.Data);
            InOrder(node.Right, list);
            return list.ToArray();
        }
        public T[] PostOrder(Node<T>? node, List<T> list)
        {
            if (node == null)
            { return new T[0]; }

            InOrder(node.Left, list);
            InOrder(node.Right, list);
            list.Add(node.Data);
            return list.ToArray();
        }

    }

}
