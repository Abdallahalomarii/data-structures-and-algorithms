namespace Challenge15_BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree<int> newTree = new BinarySearchTree<int>();

            newTree.Add(20);
            newTree.Add(30);
            newTree.Add(25);
            newTree.Add(40);
            newTree.Add(15);
            newTree.Add(10);
            newTree.Add(5);
            newTree.Add(35);
            newTree.Add(21);

            Console.WriteLine("InOrder Traversal here -----");
            string result2 = String.Join(",", newTree.InOrder(newTree.Root, new List<int>()));

            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("PreOder Traversal here -----");
            string result1 = String.Join(",", newTree.PreOder(newTree.Root, new List<int>()));
            Console.WriteLine(result1);
            Console.WriteLine();


            Console.WriteLine("PostOrder Traversal here -----");
            string result3 = String.Join(",", newTree.PostOrder(newTree.Root, new List<int>()));
            Console.WriteLine(result3);
            Console.WriteLine();

            Console.WriteLine(newTree.Contains(34));
            Console.WriteLine();

            Console.WriteLine($"The Max Value in The Tree is : {newTree.FindMax()}");

            Console.WriteLine("\nBreadth First here -----");
            var breadthFirst = String.Join(",",new Program().BreadthFirst(newTree));

            Console.WriteLine(breadthFirst);

            
            Console.WriteLine();

            var x = new Program().FizzBuzz(newTree);

            string karyPost = string.Join(", ", x.PostOrder(x.Root, new List<string>()));

            Console.WriteLine(karyPost);

        }
        // 20 15 30 10 25 35 5 21 40
        public int[] BreadthFirst(BinarySearchTree<int> tree)
        {
            var root = tree.Root;

            if (root == null)
            {
                return new int[0];
            }

            List<int> list = new List<int>();

            Queue<Node<int>> queue = new Queue<Node<int>>();

            queue.Enqueue(root);


            while (queue.Count > 0)
            {
                Node<int> currentChild = queue.Dequeue();

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

        public BinarySearchTree<string> FizzBuzz(BinarySearchTree<int> tree)
        {
            var root = tree.Root;


            if (root == null)
            {
                return null;
            }

            BinarySearchTree<string> fizzBuzz = new BinarySearchTree<string>(FizzBuzzValue(root.Data));

            Queue<Node<int>> inputQueue = new Queue<Node<int>>();
            Queue<Node<string>> outputQueue = new Queue<Node<string>>();

            inputQueue.Enqueue(root);
            outputQueue.Enqueue(fizzBuzz.Root);

            while (inputQueue.Count > 0)
            {
                Node<int> currentInputNode = inputQueue.Dequeue();
                Node<string> currentOutputNode = outputQueue.Dequeue();

                if (currentInputNode.Left != null)
                {
                    currentOutputNode.Left = new Node<string>(FizzBuzzValue(currentInputNode.Left.Data));
                    inputQueue.Enqueue(currentInputNode.Left);
                    outputQueue.Enqueue(currentOutputNode.Left);
                }

                if (currentInputNode.Right != null)
                {
                    currentOutputNode.Right = new Node<string>(FizzBuzzValue(currentInputNode.Right.Data));
                    inputQueue.Enqueue(currentInputNode.Right);
                    outputQueue.Enqueue(currentOutputNode.Right);
                }
            }
            return fizzBuzz;
        }
        private string FizzBuzzValue(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
