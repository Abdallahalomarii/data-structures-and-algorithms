using Challange06_insertion_linked_list;

namespace insertionTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddANodeToTheEndOfTheLinkedList()
        {
            // arrange
            LinkedList listTest = new LinkedList();
            listTest.Append(1);
            listTest.Append(2);

            //act 
            var result = listTest.Head.Next;
            // assert
            
            Assert.NotNull(result);
        }
        [Fact]
        public void AddMultipleNodesToTheEndOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();
            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);

            Node endOfTheLinkedList = listTest.Head;
            int[] array = new int[3];
            int count = 0;
            while (endOfTheLinkedList != null)
            {
                array[count] = endOfTheLinkedList.Data;
                endOfTheLinkedList = endOfTheLinkedList.Next;
                count++;
            }
            int[] expected = new int[] { 1, 2, 3 };
            Assert.Equal(expected, array);
        }
        [Fact]
        public void InsertBeforeANodeLocatedInTheLinkedListInTheMiddle()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);

            listTest.InsertBefore(2, 500);

            Node middle = listTest.Head;


            int[] array = new int[4];
            int count = 0;
            while (middle != null)
            {
                array[count] = middle.Data;
                middle = middle.Next;
                count++;
            }
            int[] expected = new int[] { 1, 500,2,3 };
            Assert.Equal(expected, array);

        }

        [Fact]
        public void InsertBeforeANodeLocatedInTheLinkedListAtFirst()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);

            listTest.InsertBefore(1, 500);

            Assert.Equal(500, listTest.Head.Data);

        }
        [Fact]
        public void InsertAfterANodeLocatedInTheMiddleOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);
            listTest.Append(64);
            listTest.Append(23);

            listTest.InsertAfter(2, 500);

            Node middle = listTest.Head;


            int[] array = new int[6];
            int count = 0;
            while (middle != null)
            {
                array[count] = middle.Data;
                middle = middle.Next;
                count++;
            }
            int[] expected = new int[] { 1, 2,500,3,64,23 };
            Assert.Equal(expected, array);

        }

        [Fact]
        public void InsertAtTheLastOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);
            listTest.Append(5);

            listTest.InsertAfter(5, 500);

           Node middle = listTest.Head;


            int[] array = new int[5];
            int count = 0;
            while (middle != null)
            {
                array[count] = middle.Data;
                middle = middle.Next;
                count++;
            }
            int[] expected = new int[] { 1, 2, 3 ,5, 500 };
            Assert.Equal(expected, array);

        }
        // Stretch Goal Delete Test
        [Fact]
        public void DeleteInTheEndOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);
            listTest.Append(5);

            listTest.DeleteNode(5);

            Node middle = listTest.Head;


            int[] array = new int[3];
            int count = 0;
            while (middle != null)
            {
                array[count] = middle.Data;
                middle = middle.Next;
                count++;
            }
            int[] expected = new int[] { 1, 2, 3 };
            Assert.Equal(expected, array);
        }
        [Fact]
        public void DeleteInTheMiddleOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(2);
            listTest.Append(3);
            listTest.Append(5);

           listTest.DeleteNode(3);
    
            Node middle = listTest.Head;
             

            int[] array = new int[3];
            int count = 0;
            while (middle != null)
            {
                array[count] = middle.Data;
                middle = middle.Next;
                count++;
            }
            int[] expected = new int[] { 1, 2, 5 };
            Assert.Equal(expected, array);
        }
        [Fact]
        public void DeleteAtTheFirstOfTheLinkedList()
        {
            LinkedList listTest = new LinkedList();

            listTest.Append(1);
            listTest.Append(50);
            listTest.Append(3);
            listTest.Append(5);

            Node first = listTest.Head;
            while ( first!=null)
            {
                if (first.Data == 1)
                {
                    listTest.DeleteNode(1);
                }
                
                first = first.Next;

            }
            Assert.Equal(50, listTest.Head.Data);
        }



    }
}