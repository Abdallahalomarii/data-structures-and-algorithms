namespace MockInterview
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            LinkedList newList = new LinkedList();
            LinkedList newList2 = new LinkedList();

            newList.Append(2);
            newList.Append(2);
            newList.Append(2);
            newList.Append(1);
            newList.Append(8);
            newList.Append(3);
            newList.Append(2);
            newList.Append(7);

            newList2.Append(2);
            newList2.Append(3);
            newList2.Append(20);
            //newList.Append(12);
            //Console.WriteLine(newList.Middle());
            //newList.Reverse();
            //newList.ConvertToCircle();

            //Console.WriteLine(newList.IsPalindrome());
            //Console.WriteLine(newList.PairSum(7));
            //Console.WriteLine(newList.PairSum(7));

            //

            //Console.WriteLine(list.Head.Data);
            list = newList.RemoveAllOcc(2);
            Node node = list.Head;
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }

        }
    }
}
