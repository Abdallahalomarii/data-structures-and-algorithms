using Challenge10_stack_and_queue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10_stack_and_queue.Stack_Queue
{
    public class Queues
    {
        private Node? Front { get; set; }
        private Node? Back { get; set; }
        public int Count { get; set; }

        public Queues() 
        {
            Front = null;
            Back = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new(data);
            if (Front == null)
            {
                Front = newNode;
                Back = newNode;
                Count++;
            }
            else
            {
                Back.Next = newNode;
                Back = Back.Next;
                Count++;
            }
        }

        public int Dequeue()
        {
            if (Front == null)
            {
                throw new NullReferenceException("The Queue is empty");
            }
            else
            {
                Node dequeueNode = Front;
                Front = Front.Next;
                Count--;
                return dequeueNode.Data;
            }
        }

        public int Peek()
        {   
            if (Front == null)
            {
                throw new NullReferenceException("The stack is Empty");
            }
            else
            {
                Node peekNode = Front;
                return peekNode.Data;

            }
        }

        public bool IsEmpty()
        {
            if (Front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintQueue()
        {
            Node printNode = Front;
            Console.Write("Front->");
            while (printNode != null)
            {
                Console.Write($"{{{printNode.Data}}} -> ");
                printNode = printNode.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
