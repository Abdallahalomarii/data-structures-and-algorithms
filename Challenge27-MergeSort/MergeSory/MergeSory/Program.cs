namespace MergeSory
{
    public class Program
    {
        static void Main(string[] args)
        {
            MergeSort mergeSort = new MergeSort();

            int[] arr = new int[] { 2, 8, -1, 44, 1, 50, 23, 78, 49, 100, 90 };
            mergeSort.MergeSorts(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
