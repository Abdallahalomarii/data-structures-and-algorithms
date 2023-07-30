using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15_BinaryTree
{
    public class BinaryTree
    {
        public int[] PreOder(Node? node, List<int> list)
        {
            if (node == null)
            {
                return new int[0];
            }
            list.Add(node.Data);
            PreOder(node.Left, list);
            PreOder(node.Right, list);
            return list.ToArray();
        }

        public int[] InOrder(Node? node, List<int> list)
        {
            if (node == null)
            { return new int[0]; }

            InOrder(node.Left, list);
            list.Add(node.Data);
            InOrder(node.Right, list);
            return list.ToArray();
        }public int[] PostOrder(Node? node, List<int> list)
        {
            if (node == null)
            { return new int[0]; }

            InOrder(node.Left, list);
            InOrder(node.Right, list);
            list.Add(node.Data);
            return list.ToArray();
        }

    }
}
