using Challenge15_BinaryTree;
using Xunit;

namespace BreadthFirstTest
{
    public class UnitTest1
    {
        [Fact]
        public void IfTheTreeISEmpty()
        {
            Program program = new();
            

            BinarySearchTree<int> tree= new BinarySearchTree<int>();


            var result = program.BreadthFirst(tree);

            Assert.Equal(new int[0], result);
        }

        [Fact]
        public void TheListReturnValue()
        {
            Program program = new();

            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(20);
            tree.Add(30);
            tree.Add(25);
            tree.Add(15);

            tree.Add(10);

            tree.Add(5);
            tree.Add(35);
            tree.Add(40);
            tree.Add(21);

            var result = program.BreadthFirst(tree);

            List<int> list = new List<int>()
            {20,15,30,10,25,35,5,21,40 };
            Assert.Equal(list.ToArray(), result);
        }
    }
}