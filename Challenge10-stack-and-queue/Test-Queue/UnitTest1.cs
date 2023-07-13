using Challenge10_stack_and_queue.Stack_Queue;

namespace Test_Queue
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueIntoAQueue()
        {
            // Arrange
            
            Queues queue = new();
            queue.Enqueue(1);
            
            // Act
            var res = queue.Count;
            
            // Assert
            Assert.Equal(1, res);

        }
        [Fact]
        public void EnqueueMultipleValues()
        {
            Queues queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int queueLength = queue.Count;
            
            if (queueLength >= 2)
            {
                Assert.Equal(3, queueLength);
            }
            else
            {
                Assert.Fail($"Excepted {queueLength}");
            }
        }

        [Fact]
        public void DequeueOutOfAQueue()
        {
            Queues queue = new();

            queue.Enqueue(50);
            queue.Enqueue(51);
            queue.Enqueue(52);
            queue.Enqueue(53);
            queue.Enqueue(54);

            var deleted = queue.Dequeue();

            Assert.Equal(50, deleted);

        }
        [Fact]
        public void PeekInAQueue()
        {
            Queues queue = new();

            queue.Enqueue(50);
            queue.Enqueue(51);
            queue.Enqueue(52);
            queue.Enqueue(53);
            queue.Enqueue(54);

            var peeking = queue.Peek();

            Assert.Equal(50, peeking);

        }
        [Fact]
        public void EmptyTheQueueAfterDequeue()
        {
            Queues queue = new();

            queue.Enqueue(50);
            queue.Enqueue(51);
            queue.Enqueue(54);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            var queueLength = queue.Count;
            
            Assert.Equal(0, queueLength);
            Assert.True(queue.IsEmpty());
        }
        [Fact]
        public void InstantiateAnEmptyQueue()
        {
            Queues queue = new();

            Assert.True(queue.IsEmpty());
        }
        [Fact]
        public void DequeueOrPeekException()
        {
            Queues queue = new();
            Action act = () => queue.Dequeue();
            Action act2 = () => queue.Peek();

            Assert.Throws<NullReferenceException>(act);
            Assert.Throws<NullReferenceException>(act2);

        }
    }
}