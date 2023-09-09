using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Append(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node currentNode = Head;
                Node newNode = new Node(data);

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }
        public int Middle()
        {
            if (Head == null)
            {
                return 0;
            }
            else
            {
                Node counterNode = Head;
                int counter = 0;
                while (counterNode != null)
                {
                    counterNode = counterNode.Next;
                    counter++;
                }
                int middle = 0;
                int result = 0;
                Node currentNode = Head;
                while (currentNode != null)
                {
                    if (middle == counter / 2)
                    {
                        result = currentNode.Data;
                    }
                    middle++;
                    currentNode = currentNode.Next;
                }
                return result;
            }
        }
        public void Reverse()
        {
            if (Head == null)
            {
                throw new Exception("head is null");
            }
            else
            {
                Node currentNode = Head, prev = null, next = null;
                while (currentNode != null)
                {
                    next = currentNode.Next;
                    currentNode.Next = prev;
                    prev = currentNode;
                    currentNode = next;
                }
                Head = prev;

            }
        }
        public void ConvertToCircle()
        {
            if (Head == null)
            {
                throw new Exception("list Empty");
            }
            else
            {
                Node currentNode = Head;
                
                while(Head.Next != null)
                {

                    Head = Head.Next;
                }
                Head.Next = currentNode;
            }
        }
        public void Merge(LinkedList list1, LinkedList list2)
        {
            LinkedList mergeList = new LinkedList();

            Node nodeList1 = list1.Head;
            Node nodeList2 = list2.Head;

            while( nodeList1 != null && nodeList2 != null )
            {
                if (nodeList1.Data <= nodeList2.Data)
                {
                    mergeList.Append(nodeList1.Data);
                    nodeList1 = nodeList1.Next;
                }
                else
                {
                    mergeList.Append(nodeList2.Data );
                    nodeList2 = nodeList2.Next;
                }
               
            }
            while( nodeList1 != null)
            {
                mergeList.Append(nodeList1.Data);
                nodeList1 = nodeList1.Next;
            }
            while( nodeList2 != null)
            {
                mergeList.Append(nodeList2.Data);
                nodeList2 = nodeList2.Next;
            }
        }
        public bool IsPalindrome()
        {
            Node current = Head;
            Stack<int> stack = new Stack<int>();
            bool isPalinDrome = false;
            while( current != null )
            {
                stack.Push( current.Data );
                current = current.Next;
            }
            Node ispaildrome = Head;
            while( ispaildrome != null )
            {
                int value = stack.Pop();
                if (ispaildrome.Data == value)
                {
                    isPalinDrome = true;
                }
                else
                {
                    isPalinDrome = false;
                    break;
                }
                ispaildrome = ispaildrome.Next;
            }
            return isPalinDrome;

        }

        public string PairSum(int x)
        {
            Node current = Head;
            string result = "";
            while ( current != null )
            {
                Node sum = current;
                while(sum != null )
                {
                    if (current.Data + sum.Data == x)
                    {
                        result += $"({current.Data}, {sum.Data})";
                        
                    }
                    sum = sum.Next;
                }
                current = current.Next;
            }
            return result;
        }

        public LinkedList RemoveAllOcc(int x)
        {
            LinkedList list = new LinkedList();
            bool a = true;
            Node current = Head;
            while(current != null)
            {
                
                if (current.Data == x && a == true)
                {
                    a= false;
                    list.Append(current.Data);
                }
                else if (current.Data != x)
                {
                    list.Append(current.Data);
                }
                current = current.Next;
            }
            return list;
        }
    }
    public class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node Prev { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
