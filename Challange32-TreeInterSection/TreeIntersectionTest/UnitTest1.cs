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

            tree1.Insert(5);
            tree1.Insert(10);
            tree1.Insert(13);

            TreeInterSection treeInterSection = new TreeInterSection();

            var result = treeInterSection.Tree_InterSection(tree1, tree2);

            Assert.Equal(new List<int> { }, result);
        }
        [Fact]
        public void IfThereAreNoRepetaedNodesInTheTrees()
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

            Assert.Equal(new List<int> { }, result);

        }
        [Fact]
        public void IfThereAreARepeatedNodesInTheTree()
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

            var expected = new List<int> {10, 13 };

            Assert.Equal(expected, result); 
        }
    }
}