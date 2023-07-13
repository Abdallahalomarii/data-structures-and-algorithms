using Challenge10_stack_and_queue.Stack;
using System.Linq.Expressions;

namespace Test_stack_and_queue
{
    public class UnitTest1
    {
        [Fact]
        public void PushIntoStackSuccess()
        {
            Stacks stack = new();
            stack.Push(1);

            var res = stack.Count;
            
            Assert.Equal(1, res);
            Assert.NotNull(stack);
        }

        [Fact]
        public void PushMulitpleValuesToTheStack()
        {
            Stacks stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int stackLength = stack.Count;

            Assert.Equal(4, stackLength);
            Assert.NotNull(stack);
        }

        [Fact]
        public void PopOfTheStack()
        {
            // Arrange
            Stacks stack = new();
            stack.Push(1);
            stack.Pop();

            // Act
            var res = stack.Count;

            // Assert
            Assert.Equal(0, res);
            
        }

        [Fact]
        public void EmptyAStackAfterMultiplePops()
        {
            //Arrange
            Stacks stack = new();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Act 

            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void PeekTheTopNodeValueOfTheStack()
        {
            // Arrange
            Stacks stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // Act
            int peekNode = stack.Peek();
            // Assert
            Assert.Equal(4, peekNode);
        }

        [Fact]
        public void EmptyStack()
        {
            // Arrange
            Stacks stack = new();

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void CallingPopOrPeekAException()
        {
            Stacks stack = new();

            Action act = ()=> stack.Pop();
            Action act2 = () =>  stack.Peek();

            Assert.Throws<NullReferenceException>(act);
            Assert.Throws<NullReferenceException>(act2);

        }
        


        

    }
}