

using ch11Ex01;

namespace Ch11Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalCollections animalCollections = new AnimalCollections();
            animalCollections.Add(new Cow("Donna"));
            animalCollections.Add(new Chicken("Mary"));

            foreach (Animal myAnimal in animalCollections)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();


        }
    }
}