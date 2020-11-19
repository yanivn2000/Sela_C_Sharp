using System;

namespace AnimalProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Cat("Pet Cat", 4);
            animals[1] = new Dog("Pet Dog", 6);
            animals[0].
            PrintDertails(animals);
        }

        static public void PrintDertails(Animal []animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
