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
                newTree.Add(40);
                newTree.Add(15);

                newTree.Add(10);

            Console.WriteLine("PreOder Traversal here -----");
            string result1 = String.Join(",", newTree.PreOder(newTree.Root, new List<int>()));


            Console.WriteLine(result1);
            Console.WriteLine();


            Console.WriteLine("PostOrder Traversal here -----");
            string result3 = String.Join(",", newTree.PostOrder(newTree.Root, new List<int>()));
            Console.WriteLine(result3);
            Console.WriteLine();

            Console.WriteLine(newTree.Contains(34));

            Console.WriteLine("\nBreadth First here -----");
            var breadthFirst = String.Join(",",new Program().BreadthFirst(newTree));

            Console.WriteLine(breadthFirst);

        }
        // 20 15 30 10 25 35 5 21 40
        public int[] BreadthFirst(BinarySearchTree tree)
        {
            var root = tree.Root;

            if (root == null)
            {
                return new int[0];
            }

            List<int> list = new List<int>();

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);


            while (queue.Count > 0)
            {
                Node currentChild = queue.Dequeue();

                list.Add(currentChild.Data);

                if (currentChild.Left != null)
                {
                    queue.Enqueue(currentChild.Left);
                }
                if (currentChild.Right != null)
                {
                    queue.Enqueue(currentChild.Right);
                }
            }
            return list.ToArray();


        }
    }
}
