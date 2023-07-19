using Challenge10_stack_and_queue.animal_shelter;
using Challenge10_stack_and_queue.pseudo_queue;
using Challenge10_stack_and_queue.Stack;
using Challenge10_stack_and_queue.Stack_Queue;
using System.Collections;

namespace Challenge10_stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stacks? stack1 = new();

            //stack1.Push(1);
            //stack1.Push(2);
            //stack1.Push(3);
            //stack1.Push(4);

            //stack1.PrintStack();
            //Console.WriteLine();
            //Console.WriteLine();


            //Queues? queue = new();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(8);
            //queue.Enqueue(10);
            //queue.Dequeue();

            //queue.PrintQueue();

            //PseudoQueue sud = new PseudoQueue();

            //sud.Enqueue(50);
            //sud.Enqueue(15);
            //sud.Dequeue();
            //sud.Enqueue(10);
            //sud.Enqueue(10);
            //sud.Enqueue(5);
            //sud.Dequeue();
            //sud.Print();

            AnimalShelter animal = new AnimalShelter();

            var newAnimal = new { name = "Leo", species = "Cat" };
            
            animal.Enqueue(new { name = "Banana", species = "Cat" });
            animal.Enqueue(new { name = "Leo", species = "Cat" });
            animal.Enqueue(new { name = "Louis", species = "Dog" });
            animal.Enqueue(new { name = "Messi", species = "Dog" });
            animal.Enqueue(new { name = "Simba", species = "Lion" });

            Console.WriteLine(animal.Dequeue("Dog"));
            Console.WriteLine(animal.Dequeue("lion"));

            animal.Print();

        }
    }
}