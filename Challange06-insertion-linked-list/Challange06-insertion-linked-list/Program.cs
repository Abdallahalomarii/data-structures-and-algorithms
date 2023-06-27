namespace Challange06_insertion_linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(30);
            list.Append(20);
            list.Append(60);
            list.Append(80);
            list.Append(50);
            list.Append(15);
            list.InsertBefore(30, 1);
            list.InsertAfter(15, 0);
            list.DeleteNode(50);
            Node currentNode = list.Head;
            while (currentNode != null)
            {
                Console.Write($"{{ { currentNode.Data } }} -> ");
                currentNode = currentNode.Next;
            }
            Console.Write("Null \n\n");
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }
    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList() 
        {
            Head = null;
        }

        public void Append(int data)
        {
            Node appendNode = new Node(data);
            if (Head == null)
            {
                Head = appendNode;
            }
            else
            {
                Node lastNode = Head;
                while(lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = appendNode;
            }
        }
        public void InsertBefore (int before, int data)
        {// 10 20 30 (20,50)
            Node newNode = new Node(data);
            Node currentNode = Head;
            if (Head.Data == before)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            while(currentNode.Next != null)
            {
                Node holdingNode = currentNode;
                if (currentNode.Next.Data == before)
                {
                    holdingNode = currentNode.Next;
                    currentNode.Next = newNode;
                    newNode.Next = holdingNode;
                    currentNode = currentNode.Next;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
        public void InsertAfter (int after, int data)
        {// 10 20 30 (20,50)
            Node newNode = new Node(data);
            Node currentNode = Head;
            while (currentNode != null)
            {
                Node holdingNode = currentNode;
                if (currentNode.Data == after)
                {
                    
                    holdingNode = currentNode.Next;
                    currentNode.Next = newNode;
                    newNode.Next = holdingNode;
                    currentNode = currentNode.Next;

                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
        public void DeleteNode(int NodeValue)
        {
            Node currentNode = Head;
            Node delNode = currentNode;
            if (Head.Data == NodeValue)
            {
                Head = Head.Next;
            }
            while (currentNode != null)
            {
                if (currentNode.Data == NodeValue)
                {
                    delNode.Next = currentNode.Next;
                    currentNode = currentNode.Next;
                }
                else
                {
                    delNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
        }
        
    }
}