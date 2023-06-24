namespace Linkedlists
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedList myList = new LinkedList();
                myList.InsertAtFirst(50);
                myList.InsertAtFirst(54);
                myList.InsertAtFirst(14);
                Node? CurrentNode = myList.Head;
                while (CurrentNode != null)
                {
                    Console.WriteLine(CurrentNode.Data);
                    CurrentNode = CurrentNode.Next;
                }
                if (myList.Includes(50))
                {
                    Console.WriteLine($"The Node you looking at is found ");
                }
                else
                {
                    Console.WriteLine($"The Node you looking at is not found");
                }
                Console.WriteLine(myList.ToStringList());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class Node
    {
        public int? Data { get; set; }
        public Node? Next { get; set; }
        public Node(int data)//20
        {
            Data = data; // Data = 20 
            Next = null;
        }
    }
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void InsertAtFirst(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public bool Includes(int data)
        {
            Node includeNode = new Node(data);
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node currentNode = Head;

                while (currentNode != null)
                {
                    if (currentNode.Data == includeNode.Data)
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }
        public string ToStringList()
        {
            Node listToString = Head;
            string result = "";
            if (listToString == null)
            {
                return result + "{ Null }";
            }
            else
            {
                while (listToString != null)
                {
                    result += "{ " + listToString.Data.ToString() + " } " + "-> ";
                    listToString = listToString.Next;

                }
                return result + "Null";
            }
        }
    }
}