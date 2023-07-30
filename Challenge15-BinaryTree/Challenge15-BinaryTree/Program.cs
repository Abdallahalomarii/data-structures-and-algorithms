namespace Challenge15_BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();

            newTree.Add(20);
            newTree.Add(30);
            newTree.Add(25);
            newTree.Add(15);

            newTree.Add(10);

            newTree.Add(5);
            newTree.Add(35);
            newTree.Add(40);
            newTree.Add(21);


            Console.WriteLine("InOrder Traversal here -----");
            string result2 = String.Join(",", newTree.InOrder(newTree.Root,new List<int>()));

            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("PreOder Traversal here -----");
            string result1 = String.Join(",", newTree.PreOder(newTree.Root,new List<int>()));
            Console.WriteLine(result1);
            Console.WriteLine();


            Console.WriteLine("PostOrder Traversal here -----");
            string result3 = String.Join(",", newTree.PostOrder(newTree.Root,new List<int>()));
            Console.WriteLine(result3);
            Console.WriteLine();

            Console.WriteLine(newTree.Contains(34));
        }
    }
}