using Challenge10_stack_and_queue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10_stack_and_queue.pseudo_queue
{
    public class PseudoQueue
    {


        public Stacks stack1;
        public Stacks stack2;


        public PseudoQueue()
        {
            stack1 = new Stacks();
            stack2 = new Stacks();
        }

        public void Enqueue(int data)
        {
            stack1.Push(data);

            Node? oldStack = stack1.Top;
        }
        // 5 10 20 30
        public void Dequeue()
        {
            int x = 0;
            int removedNode = 0;
            // used another way instead of while loop and this condition to stop the recursive
            if (x == stack1.Count-1) 
            {
                Console.WriteLine(stack1.Pop());
                return;
            }
            else
            {
                stack2.Push(stack1.Pop());
                x++;
                Dequeue(); // calling the  recursive function it self several time till the condition break it 
            }
            Node? currentNode = stack2.Top;
            while (currentNode != null)
            {
                stack1.Push(stack2.Pop());
                currentNode = currentNode.Next;
            }
        }

        public void Print()
        {
            Node? printNode = stack1.Top;
            while (printNode != null)
            {
                Console.Write($"[ {printNode.Data} ]");
                printNode = printNode.Next;
                if (printNode != null)
                    Console.Write("->");
            }
            Console.WriteLine();

        }
    }
}
