namespace Challange32_TreeInterSection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();

            BinaryTree<int> tree2 = new BinaryTree<int>();

            TreeInterSection tree = new TreeInterSection();



            tree1.Insert(150);
            tree1.Insert(100);//2
            tree1.Insert(75);
            tree1.Insert(160);// 4
            tree1.Insert(125);//3 
            tree1.Insert(175);// 5
            tree1.Insert(250);
            tree1.Insert(5);// 1
            tree1.Insert(200);// 6
            tree1.Insert(350);// 7
            tree1.Insert(300);
            tree1.Insert(500);//8 


            tree2.Insert(42);
            tree2.Insert(100);
            tree2.Insert(15);
            tree2.Insert(160);
            tree2.Insert(125);
            tree2.Insert(175);
            tree2.Insert(5);
            tree2.Insert(600);
            tree2.Insert(200);
            tree2.Insert(350);
            tree2.Insert(4);
            tree2.Insert(500);

            var repeatedNumbers = tree.Tree_InterSection(tree1, tree2);

            repeatedNumbers.Print();
        }
    }
}
