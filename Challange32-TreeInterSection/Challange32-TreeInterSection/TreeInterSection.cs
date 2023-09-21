using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange32_TreeInterSection
{
    public class TreeInterSection
    {

        public List<int> Tree_InterSection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            if (tree1 == null || tree2 == null)
            {
                return new List<int>();
            }
            HashTable<int,int> hashTable = new HashTable<int,int>();
            List<int> FirstTree = new List<int>();
            List<int> SecondTree = new List<int>();
            List<int> Result = new List<int>();
            tree1.InOrder(tree1.Root, FirstTree);
            foreach (var item in FirstTree)
            {
                hashTable.Set(item, item); // 100 : 100
            }
            tree2.InOrder(tree2.Root, SecondTree);

            foreach(var item in SecondTree)
            {
                hashTable.Set(item, item); //100: {100,100}
                if (hashTable.Get(item).Count() > 1)
                {
                    Result.Add(item);
                }
            }
            return Result;
        }
    }
}
