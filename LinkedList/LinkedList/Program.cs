namespace Linkedlists
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is a Single Linked List");

                LinkedList myList = new LinkedList();
                myList.InsertAtFirst(50);
                myList.InsertAtFirst(54);
                myList.InsertAtFirst(14);
                Node? CurrentNode = myList.Head;
              
                Console.WriteLine(myList.ToStringList());

                Console.Write("\nTo search for number enter here : ");

                int searchForNumber = Convert.ToInt32(Console.ReadLine());

                if (myList.Includes(searchForNumber))
                {
                    Console.WriteLine($"The Number {searchForNumber} you looking at is found \n");
                }
                else
                {
                    Console.WriteLine($"The Number {searchForNumber} you looking at is not found\n");
                }
                Console.WriteLine("\nThis is a Double Linked List");

                DoubleLinkedList dbList = new DoubleLinkedList();
                
                dbList.InsertAtLast(50);
                dbList.InsertAtLast(755);
                dbList.InsertAtfirst(14);
                dbList.InsertAtfirst(12);

                Console.WriteLine(dbList.PrintList());
                Console.Write("\nEnter A Number To Search in Double Linked List : ");
                int searchInDouble = Convert.ToInt32(Console.ReadLine());

                if (dbList.Search(searchInDouble))
                {
                    Console.WriteLine($"The Number {searchInDouble} you looking at is found");
                }
                else
                {
                    Console.WriteLine($"The Number {searchInDouble} you looking at is not found");
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong Input "+ex.Message);
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
        public Node? Prev { get; set; }
        public Node(int data)//20
        {
            Data = data; // Data = 20 
            Next = null;
            Prev = null;
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

    
    public class DoubleLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public DoubleLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void InsertAtLast(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }
        }
        public void InsertAtfirst(int data)
        {
            try
            {
                Node node = new Node(data);
                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Head.Prev = node;
                    node.Prev = null;
                    node.Next = Head;
                    Head = node;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool Search(int data)
        {

            Node? searchNode = Head;
            if (Head == null)
            {
                return false;
            }
            else
            {
                while (searchNode != null)
                {
                    if (searchNode.Data == data)
                    {
                        return true;
                    }
                    searchNode = searchNode.Next;
                }
                return false;
            }
        }

        public string PrintList()
        {
            Node? newNode = Head;
            string result = "";
            if (Head == null)
            {
                return result+"NULL";
            }
            else
            {
                result += "NULL < - ";
                while(newNode != null)
                {
                    if (newNode.Data == Tail.Data)
                    {
                        result += " { " + newNode.Data.ToString() + " } " + " - > ";
                        newNode = newNode.Next;
                    }
                    else
                    {
                        result += "{ " + newNode.Data.ToString() + " } " + " < - > ";
                        newNode = newNode.Next;
                    }
                }
                return result+" NULL ";
            }
        }
    }
}