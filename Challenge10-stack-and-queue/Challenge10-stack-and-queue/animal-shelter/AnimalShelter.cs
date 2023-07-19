using Challenge10_stack_and_queue.Stack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10_stack_and_queue.animal_shelter
{

    public class NodeObject
    {
        public object? Data { get; set; }
        public NodeObject? Next { get; set; }

        public NodeObject(object data)
        {
            Data = data;
        }
    }

    public class AnimalShelter
    {
        public NodeObject? Front { get; set; }
        public NodeObject? Back { get; set; }
        public int Count { get; set; }

        public AnimalShelter()
        {
            Front = null;
            Back = null;
        }

        public void Enqueue(object animal)
        {
            var nameProperty = animal.GetType().GetProperty("name");

            var speciesProperty = animal.GetType().GetProperty("species");

            string? species = speciesProperty.GetValue(animal)?.ToString();

            string? name = nameProperty.GetValue(animal)?.ToString();

            if (species?.ToLower() == "cat" || species?.ToLower() == "dog")
            {
                object data = new { name, species };
                NodeObject? newNode = new(data);
                if (Front == null)
                {
                    Front = newNode;
                    Back = newNode;
                    Count++;
                }
                else
                {
                    Back.Next = newNode;
                    Back = Back.Next;
                    Count++;
                }
            }
            else
            {
                return;
            }
        }


        public object Dequeue(string pref)
        {
            if (pref.ToLower() == "cat" || pref.ToLower() == "dog")
            {

                NodeObject? resultData = null;

                var speciesProperty = Front.Data.GetType().GetProperty("species");


                string? species = speciesProperty.GetValue(Front.Data)?.ToString();

                if (species.ToLower() == pref.ToLower())
                {
                    resultData = Front;
                    Front = Front.Next;
                    Count--;
                    return resultData.Data;
                }

                NodeObject? currentNode = Front;

                NodeObject? deqAnimal = currentNode;
                
                while (currentNode != null)
                {
                    speciesProperty = currentNode.Data.GetType().GetProperty("species");

                    species = speciesProperty.GetValue(currentNode.Data)?.ToString();



                    if (species.ToLower() == pref.ToLower())
                    {
                        deqAnimal.Next = currentNode.Next;

                        resultData = currentNode;
                        currentNode = currentNode.Next;
                        Count--;
                        break;
                    }
                    else
                    {
                        deqAnimal = currentNode;
                        currentNode = currentNode?.Next;
                    }
                }
                return resultData.Data;

            }
            else
            {
                NodeObject? longestAnimal = Front;
                Front = Front.Next;
                Count--;
                return longestAnimal.Data;
            }
            
            
        }


        public void Print()
        {
            NodeObject? printNode = Front;
            while (printNode != null)
            {
                Console.Write($"{printNode.Data}");
                printNode = printNode.Next;
                if (printNode != null)
                    Console.Write(" -> ");
            }
            Console.WriteLine();

        }
    }
}
