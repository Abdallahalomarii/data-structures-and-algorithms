using Linkedlists;
namespace LinkedListTest
{
    
    public class UnitTest1
    {
        [Fact]
        public void LinkedListIsEmpty()
        {
            // arrange
            LinkedList testList = new LinkedList();
            // act 
            var result = testList.Head;
            var result2 = testList.Tail;

            Assert.Equal(null, result);
            Assert.Equal(null, result2);
        }

        [Fact]
        public void InsertMutliValue()
        {
            LinkedList testList = new LinkedList();
            string expected = "";

            testList.InsertAtFirst(50);
            testList.InsertAtFirst(45);
            testList.InsertAtFirst(18);
            Node listToString = testList.Head;

            if (listToString == null)
            {
                expected += "{ Null }";
            }
            else
            {

                while (listToString != null)
                {
                    expected += "{ " + listToString.Data.ToString() + " } " + "-> ";
                    listToString = listToString.Next;

                }
                expected += "Null";
            }

            // assert

            Assert.Equal(expected, testList.ToStringList());


        }

        [Fact]
        public void InsertIntoLinkedListTest()
        {
            LinkedList testList = new LinkedList();

            testList.InsertAtFirst(50);
            testList.InsertAtFirst(40);
            testList.InsertAtFirst(30);
            testList.InsertAtFirst(70);

            var result = testList.Head.Next.Next.Next.Data;

            Assert.Equal(50, result);
        }
        [Fact]
        public void HeadPointToTheFirstNode()
        {
            LinkedList testList = new LinkedList();

            testList.InsertAtFirst(50);
            testList.InsertAtFirst(70);

            var result = testList.Head.Data;

            Assert.Equal(70, result);
        }
        [Fact]
        public void FindingAExistValue()
        {
            LinkedList testList = new LinkedList();

            testList.InsertAtFirst(50);
            testList.InsertAtFirst(40);
            testList.InsertAtFirst(30);
            testList.InsertAtFirst(70);

            bool result = testList.Includes(30);

            Assert.True(result);

        }
        [Fact]
        public void FindingANotExistValue()
        {
            LinkedList testList = new LinkedList();

            testList.InsertAtFirst(50);
            testList.InsertAtFirst(40);
            testList.InsertAtFirst(30);
            testList.InsertAtFirst(70);

            bool result = testList.Includes(78);

            Assert.False(result);

        }
        [Theory]
        [InlineData(new int[] { 20, 80, 54, 46, 25, 14, 440 })]
        [InlineData(new int[] { 0, 1 })]
        [InlineData(new int[] { -10, 55, 78, 32, 42, 1000, 320, 45, 98, 774, 30 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 00, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 54, 78, 3654, 129, 87, 54, 65, 37, 29, 19, 78 })]
        [InlineData(new int[] { 0 })]

        public void returnACollectionOfLinkedListValues(int[] values)
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < values.Length; i++)
            {
                list.InsertAtFirst(values[i]);
            }
            int[] expected = new int[values.Length];
            int count = values.Length-1;
            Node currentNode = list.Head;
            while (currentNode != null)
            {
                expected[count] = (int)currentNode.Data;
                currentNode = currentNode.Next;
                count--;
            }

            Assert.Equal(expected, values);
        }

    }

}