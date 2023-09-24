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

        public HashTable<int, int> Tree_InterSection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            {
                if (tree1 == null || tree2 == null)
                {
                    return new HashTable<int, int>();
                }

                HashTable<int, int> hashTable = new HashTable<int, int>();
                List<int> FirstTree = new List<int>();
                List<int> SecondTree = new List<int>();
                HashTable<int, int> Result = new HashTable<int, int>();

                tree1.InOrder(tree1.Root, FirstTree);
                foreach (var item in FirstTree)
                {
                    hashTable.Set(item, item); // Store values from the first tree
                }

                tree2.InOrder(tree2.Root, SecondTree);

                foreach (var item in SecondTree)
                {
                    if (hashTable.Has(item))
                    {
                        Result.Set(item, item); // Store values that exist in both trees
                    }
                }

                return Result;
            }
        }
    }
}
