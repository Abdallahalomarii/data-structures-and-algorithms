using Challenge10_stack_and_queue.Stack;
using Challenge10_stack_and_queue.Stack_Queue;
using System.Collections;

namespace Challenge10_stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks? stack1 = new();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);

            stack1.PrintStack();
            Console.WriteLine();
            Console.WriteLine();


            Queues? queue = new();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(8);
            queue.Enqueue(10);
            queue.Dequeue();

            queue.PrintQueue();
        }
    }
}