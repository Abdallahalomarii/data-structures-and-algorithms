using Challange08_linked_list_zip;
namespace linked_list_zipTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfTheTwoLinkedListHasSameLength()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(10);
            list1.Append(8);
            list1.Append(5);

            list2.Append(7);
            list2.Append(20);
            list2.Append(15);

            LinkedList zipList = Program.ZipLists(list1 , list2);
            Node currentNode = zipList.Head;
            int[] result = new int[6];
            int index = 0;
            while (currentNode != null)
            {
                result[index] = currentNode.Data;
                index++;
                currentNode = currentNode.Next;
            }
            int[] expected = new int[] { 10, 7, 8, 20, 5, 15 };
            Assert.Equal(expected, result);


        }
        [Fact]
        public void IfTheLinkedListOneShortThanTheLinkedListTwo()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(10);
            list1.Append(8);

            list2.Append(7);
            list2.Append(20);
            list2.Append(15);

            LinkedList zipList = Program.ZipLists(list1, list2);
            Node currentNode = zipList.Head;
            int[] result = new int[5];
            int index = 0;
            while (currentNode != null)
            {
                result[index] = currentNode.Data;
                index++;
                currentNode = currentNode.Next;
            }
            int[] expected = new int[] { 10, 7, 8, 20, 15 };
            Assert.Equal(expected, result);
        }
        [Fact]
        public void IfTheLinkedListTwoShortThanTheLinkedListOne()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(10);
            list1.Append(8);
            list1.Append(50);

            list2.Append(7);
            list2.Append(20);

            LinkedList zipList = Program.ZipLists(list1, list2);
            Node currentNode = zipList.Head;
            string result = "";
            while (currentNode != null)
            {
                result += $"{{ {currentNode.Data} }} -> ";
                currentNode = currentNode.Next;
            }
            result+="Null";

            int[] expected = new int[] { 10, 7, 8, 20, 15 };
            Assert.Equal("{ 10 } -> { 7 } -> { 8 } -> { 20 } -> { 50 } -> Null",result );
        }
    }
}