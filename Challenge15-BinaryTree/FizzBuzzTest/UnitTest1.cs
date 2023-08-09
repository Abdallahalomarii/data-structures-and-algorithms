using Challenge15_BinaryTree;
using Xunit;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void IfTheTreeIsEmpty()
        {
            // arrange 

            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            var fizzBuzz = Program.FizzBuzz(tree);

            // Assert
            Assert.Null(fizzBuzz);
        }
        [Fact]
        public void IfTheTreeNotEmptyAndHasOnlyTheRoot()
        {
            // arrange 

            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(15);
            
            
            var fizzBuzz = Program.FizzBuzz(tree);

            // Act

            var actual = fizzBuzz.PreOder(fizzBuzz.Root, new List<string>());

            string[] expected = new string[] { "FizzBuzz" };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMoreThanOneLevel()
        {
       // arrange 
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
      
            tree.Add(30);
            tree.Add(50);
            tree.Add(35);
            tree.Add(15);
            tree.Add(17);
            tree.Add(16);
            tree.Add(8);

            var fizzBuzz = Program.FizzBuzz(tree);

            // Act

            var actual = fizzBuzz.PreOder(fizzBuzz.Root, new List<string>());

            string[] expected = new string[] {"FizzBuzz", "FizzBuzz","8","17","16", "Buzz","Buzz" };

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}