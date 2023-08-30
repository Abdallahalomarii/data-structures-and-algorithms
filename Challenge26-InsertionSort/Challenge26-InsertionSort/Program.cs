namespace Challenge26_InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insertion insertionArray = new Insertion();
            int[] array = new int[] { 2, 3, 5, 7, 13, 11 };

            int[] SortedArray = insertionArray.InsertionSort(array);

            Console.WriteLine("Sorted Array:");
            foreach (int num in SortedArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
