using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDuckGoose.Queue
{
    public class Queues
    {
        public Node Front { get; set; }

        public Node Back { get; set; }

        public int Count { get; set; }

        public Queues() 
        {
            Front = null;
            Back = null;
            Count = 0;
        }

        public void Enqueue(string value)
        {
            Node newNode = new(value);
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
                Back.Next = Front;
                Count++;
            }
        }

        public string Dequeue()
        {
            if (Front == null)
            {
                return null;
            }
            else
            {
                Node deletedNode = Front;
                Front = Front.Next;
                Count--;
                return deletedNode.Data;
            }
        }

   

        public void Print()
        {
            Node printNode = Front;
            Node firstNode = Front;

            while(printNode != null)
            {
                Console.Write($"{{{printNode.Data}}} , ");
                printNode = printNode.Next;
                if (printNode == firstNode)
                {
                    break;
                }

            }
            Console.WriteLine();

        }

    }

}
