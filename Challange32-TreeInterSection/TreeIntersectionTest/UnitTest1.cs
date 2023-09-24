using Challange32_TreeInterSection;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void IfOneOfTheTreesIsEmptyOrBoth()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            TreeInterSection treeInterSection = new TreeInterSection();

            var result = treeInterSection.Tree_InterSection(tree1, tree2);

            HashTable<int, int> expected = new HashTable<int, int>();

            Assert.Equal(expected.Map , result.Map);
            
        }

        [Fact]
        public void NoRepeatedValues()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Insert(5);
            tree1.Insert(10);
            tree1.Insert(13);

            tree2.Insert(7);
            tree2.Insert(9);
            tree2.Insert(11);

            TreeInterSection treeInterSection = new TreeInterSection();

            var result = treeInterSection.Tree_InterSection(tree1, tree2);

            HashTable<int, int> expected = new HashTable<int, int>();

            Assert.Equal(expected.Map, result.Map);
        }

        [Fact]
        public void IfThereAreRepeatedValues()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Insert(5);
            tree1.Insert(10);
            tree1.Insert(13);

            tree2.Insert(7);
            tree2.Insert(9);
            tree2.Insert(13);
            tree2.Insert(10);

            TreeInterSection treeInterSection = new TreeInterSection();

            var result = treeInterSection.Tree_InterSection(tree1, tree2);

            HashTable<int, int> expected = new HashTable<int, int>();
            expected.Set(10, 10);
            expected.Set(13, 13);

            Assert.Equal(expected.Map.Length, result.Map.Length);
            Assert.Equal(expected.Get(10), result.Get(10));
            Assert.Equal(expected.Get(13), result.Get(13));
            Assert.True(result.Has(10));
            Assert.True(result.Has(13));
            Assert.True(expected.Has(10));
            Assert.True(expected.Has(13));
        }

    }
}