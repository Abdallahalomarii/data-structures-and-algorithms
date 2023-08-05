using Challenge15_BinaryTree;

namespace TestMax
{
    public class UnitTest1
    {
        [Fact]
        public void IfBinaryTreeEmpty()
        {
            // Arrange 
            BinarySearchTree tree = new BinarySearchTree();

            //var result = tree.FindMax();

            // Assert
            Assert.Throws<Exception>(() => tree.FindMax());
        }

        [Fact]
        public void FindMaxInBinaryTree()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10); 
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(20);

            // Act
            int maxValue = tree.FindMax();

            // Assert
            Assert.Equal(20, maxValue);
        }
        [Fact]
        public void FindMaxInBinaryTreeNeagtiveNumber()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(-10);
            tree.Add(-5);
            tree.Add(-15);
            tree.Add(-3);
            tree.Add(-7);
            tree.Add(-12);
            tree.Add(-20);

            // Act
            int maxValue = tree.FindMax();

            // Assert
            Assert.Equal(-3, maxValue);
        }

    }
}