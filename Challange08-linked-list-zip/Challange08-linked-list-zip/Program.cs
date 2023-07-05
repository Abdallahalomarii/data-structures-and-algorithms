namespace Challange08_linked_list_zip
{

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // list 1
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);
            // list 2
            list2.Append(5);
            list2.Append(9);
            list2.Append(4);

            LinkedList newList = ZipLists(list1, list2);

            Node currentNode = newList.Head;
            while (currentNode != null)
            {
                Console.Write($"{{ {currentNode.Data} }} -> ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine("Null");
        }
        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            Node node1 = list1.Head;
            Node node2 = list2.Head;

            LinkedList newList = new LinkedList();

            while (node1 != null || node2 != null)
            {
                if (node1 != null)
                {
                    newList.Append(node1.Data);
                    node1 = node1.Next;
                }
                if (node2 != null)
                {
                    newList.Append(node2.Data);
                    node2 = node2.Next;
                }
            }

            return newList;
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
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
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node lastNode = Head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
        }
    }

}

