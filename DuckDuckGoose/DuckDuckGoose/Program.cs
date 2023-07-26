using DuckDuckGoose.Queue;
using System.Security;

namespace DuckDuckGoose
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queues queue = new Queues();

            //queue.Enqueue("A");
            //queue.Enqueue("B");
            //queue.Enqueue("C");
            //queue.Enqueue("D");
            //queue.Enqueue("E");

            Console.WriteLine($"The Winner is {DuckDuckGoose(new string[] { "A", "B", "C", "D", "E" }, 3)}");



        }
        public static string DuckDuckGoose(string[] arrayOfValues, int k)
        {
            Queues queue = new Queues();
            string result = "";
            foreach (string value in arrayOfValues) 
            { 
                queue.Enqueue(value);
            }
            int i = 0;
            Node first = null;
            Node currentNode = queue.Front;
            Node newNode = currentNode;
            Node defaultNode = newNode;
            while(i != k)
            {
                defaultNode = newNode;
                newNode = newNode.Next;
                newNode = currentNode;
                    currentNode = currentNode.Next;
                     i++;
                if (i == k)
                {
                    queue.Print();
                    i = 0;
                    defaultNode.Next = newNode.Next;
                    first = newNode;
                    currentNode = newNode;
                    currentNode = currentNode.Next;
                    queue.Front = currentNode;
                    queue.Count--;
                    if (currentNode.Next == currentNode)
                    {
                        break;
                    }
                }
            }
            queue.Print();
            return currentNode.Data;
           
        }
    }
}