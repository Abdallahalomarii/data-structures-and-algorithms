using linked_list_kth;
using System.Linq.Expressions;
using Xunit.Sdk;

namespace LLkthTest
{
    public class UnitTest1
    {
        [Fact]
        public void TheKthIsGreaterThanTheLengthOfTheLinkedList()
        {
            // Arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(1);
            listTest.Append(3);
            listTest.Append(8);
            listTest.Append(2);

            // Act
            int result = listTest.kthFromEnd(4);

            // Assert
            Assert.Equal(-1, result);
        }
        [Fact]
        public void TheKthSameAsLengthOfLinkedList()
        {
            // Arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(1);
            listTest.Append(3);
            listTest.Append(8);
            listTest.Append(2);

            // Act
            int result1 = listTest.kthFromEnd(3);

            // Assert
            Assert.Equal(1, result1);
            Assert.Equal(listTest.Head.Data, result1);
        }
        [Fact]
        public void TheKthIsNotAPositiveNumber()
        {
            // Arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(1);
            listTest.Append(3);
            listTest.Append(8);
            listTest.Append(2);

            // Act
            int result = listTest.kthFromEnd(-4);

            // Assert
            Assert.Equal(-1, result);
        }
        [Fact]
        public void TheSizeOfLinkedListIsOne1()
        {
            //Arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(40);

            // Act
            int result = listTest.kthFromEnd(0);

            // Assert
            Assert.Equal(40, result);
        }
        [Fact]
        public void KthIsInTheMiddleOfTheLinkedList()
        {
            //Arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(75);
            listTest.Append(4);
            listTest.Append(8);
            listTest.Append(97);
            listTest.Append(45);
            listTest.Append(113);
            listTest.Append(98);

            //Act
            int result = listTest.kthFromEnd(4);
            int result2 = listTest.kthFromEnd(1);
            int result3 = listTest.kthFromEnd(5);

            // Assert
            Assert.Equal(8, result);
            Assert.Equal(113, result2);
            Assert.Equal(4, result3);
        }
    }
}