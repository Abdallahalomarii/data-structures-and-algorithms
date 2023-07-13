using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10_stack_and_queue.Stack
{
    public class Stacks 
    {
        public Node? Top { get; set; }

        public int Count { get; set; }

        public Stacks() 
        {
            Top = null;
        }

        public void Push(int data)
        {
            Node currentNode = new(data);

            if (Top == null)
            {
                Top = currentNode;
                Count++;
            }
            else
            {
                currentNode.Next = Top;
                Top = currentNode;
                Count++;
            }
        }

        public int Pop()
        {
            if (Top == null)
            {
                throw new NullReferenceException("The Stack is Empty");
            }
            else
            {
                Node removedNode = Top;
                Top = Top.Next;
                Count--;
                return removedNode.Data;
                
            }
        }

        public int Peek()
        {
            if(Top == null)
            {
                throw new NullReferenceException("The stack is Empty");
            }
            else
            {
                // return Top.Data;
                // Or by creating another Node
                Node peekNode = Top;
                return peekNode.Data;
                
            }
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintStack()
        {
            Node printNode = Top;
            Console.WriteLine("Top");
            while(printNode != null)
            {
                Console.WriteLine($"{{{printNode.Data}}}");
                printNode = printNode.Next;
            }
        }

    }
}
