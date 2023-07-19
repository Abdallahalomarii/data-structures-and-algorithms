using Challenge10_stack_and_queue.animal_shelter;

namespace QueueShelter
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfCreateEmptyInstance()
        {
           AnimalShelter animal = new AnimalShelter();


            Assert.Equal(0, animal.Count);
            Assert.Null(animal.Front);
            Assert.Null(animal.Back);

        }

        [Fact]
        public void TestIfCanEnqueueSuccessfully()
        {
            AnimalShelter animal = new AnimalShelter();
            object newAnimal = new { name = "Max", species = "Cat" };
            animal.Enqueue(newAnimal);


            NodeObject newNode = animal.Front;

            var nameProp = newAnimal.GetType().GetProperty("name");

            string? name = nameProp?.GetValue(newAnimal)?.ToString();


            Assert.Contains("Max",name );

            Assert.Equal(newNode, animal.Front);

            Assert.Equal(1, animal.Count);


        }
        [Fact]
        public void TestIfCanDequeueSuccessfully()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            object newAnimal = new { name = "Max", species = "Cat" };
            object newAnimal2 = new { name = "Max2", species = "Dog" };
            animalShelter.Enqueue(newAnimal);
            animalShelter.Enqueue(newAnimal2);

            // Act
            var removedObject = animalShelter.Dequeue("Cat");

            // Assert
            Assert.Equal(1, animalShelter.Count);

            var nameProperty = removedObject.GetType().GetProperty("name");
            string name = nameProperty.GetValue(removedObject)?.ToString();

            Assert.Contains("Max", name);


        }
        [Fact]
        public void TestDequeueWithNonMatchingSpecies()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new { name = "Max", species = "Cat" });
            animalShelter.Enqueue(new { name = "Banana", species = "Cat" });
            animalShelter.Enqueue(new { name = "Leo", species = "dog" });

            // Act
            var dequeuedNonMatching = animalShelter.Dequeue("Lion");

            var nameProperty = dequeuedNonMatching.GetType().GetProperty("name");
            string name = nameProperty.GetValue(dequeuedNonMatching)?.ToString();


            // Assert
            Assert.Equal(2, animalShelter.Count);
            Assert.Contains("Max", name);
        }

    }
}