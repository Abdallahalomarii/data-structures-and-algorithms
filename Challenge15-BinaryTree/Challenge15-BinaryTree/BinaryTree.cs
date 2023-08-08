using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15_BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
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
        }public T[] PostOrder(Node<T>? node, List<T> list)
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
