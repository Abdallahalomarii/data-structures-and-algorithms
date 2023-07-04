namespace linked_list_kth
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Append(1);
                linkedList.Append(3);
                linkedList.Append(8);
                linkedList.Append(2); // will return this one 
                linkedList.Append(78);
                linkedList.Append(97);
                linkedList.Append(45);

                linkedList.Print();

                Console.WriteLine(linkedList.kthFromEnd(20));
                Console.WriteLine("The Middle linked list  Node Value is : "+linkedList.MiddleNumber());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
           
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
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = appendNode;
            }
        }
        public void Print()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.Write($"{{ {currentNode.Data} }} -> ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine("{ NULL }");
        }

        public int kthFromEnd(int k)
        {
            int result = 0;
            int count = 0;
            int i = 0;
            if (Head == null)
            {
                throw new Exception("Your List is empty");
            }
            else if (Head.Next == null)
            {
                if (count - i == k)
                {
                    result = Head.Data;
                }
                else
                {
                    throw new Exception("Index out of range");
                }
                return result;
            }
            else
            {
                Node currentNode = Head;
                Node newNode = Head;
                while (currentNode.Next != null)
                {
                    count++;
                    currentNode = currentNode.Next;
                }
                while (newNode != null)
                {
                    if (count - i < k || k < 0)
                    {
                        throw new IndexOutOfRangeException("Index out of range");
                    }
                    else if (count - i == k)
                    {
                        result = newNode.Data;
                        return result;
                    }
                    else
                    {
                        i++;
                        newNode = newNode.Next;
                    }
                }
                return result;
            }
        }

        public int MiddleNumber()
        {
            int result = 0;
            int count = 0;
            int i = 0;
            Node currentNode = Head;
            Node newNode = Head;
            while (currentNode.Next != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            while(newNode != null)
            {
                if (count / 2 == i)
                {
                    result = newNode.Data;
                    return result;
                }
                else
                {
                    i++;
                    newNode= newNode.Next;
                }
            }
            return result;
        }
    }
}