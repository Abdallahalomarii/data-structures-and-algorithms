using Challenge15_BinaryTree;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTree()
        {
            BinarySearchTree tree= new BinarySearchTree();

            Assert.Null(tree.Root);
        }

        [Fact]
        public void HasARootValue()
        {
            BinarySearchTree tree = new BinarySearchTree(25);
            
           Assert.NotNull(tree);
            Assert.Equal(25, tree.Root.Data);
        }

        [Fact]
        public void AddLeftRightNode()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(25);
            tree.Add(30);
            tree.Add(20);

            Node newNode = tree.Root;

            Node leftNode = newNode.Left;

            Node rightNode = newNode.Right;

            Assert.Equal(tree.Root.Data, 25);

            Assert.Equal(leftNode.Data,20);

            Assert.Equal(rightNode.Data,30);
        }
        [Fact]
        public void ReturnCollection()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(25);
            tree.Add(30);
            tree.Add(40);
            tree.Add(10);
            tree.Add(15);

            int[] preOrder = tree.PreOder(tree.Root, new List<int>());

            int[] inOrder = tree.InOrder(tree.Root, new List<int>());

            int[] postOrder = tree.PostOrder(tree.Root, new List<int>());

            int[] result = new int[] { 25,10, 15,30,40};


            int[] result2 = new int[] { 10,15, 25,30,40};


            int[] result3 = new int[] { 10, 15,30,40,25};



            Assert.Equal(result, preOrder);

            Assert.Equal(result2, inOrder);

            Assert.Equal(result3, postOrder);
        }

        [Fact]
        public void ReturnCorrectValue()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(25);
            tree.Add(30);
            tree.Add(20);
            tree.Add(82);
            tree.Add(74);
            tree.Add(27);
            tree.Add(17);
            tree.Add(15);

            bool resultTrue1 = tree.Contains(15);
            bool resultTrue2 = tree.Contains(74);

            bool resultFalse1 = tree.Contains(0);
            bool resultFalse2 = tree.Contains(100);

            Assert.True(resultTrue1);
            Assert.True(resultTrue2);

            Assert.False(resultFalse1);
            Assert.False(resultFalse2);

        }
    }
}