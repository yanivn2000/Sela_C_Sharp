using System;

namespace AnimalProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("Pet Cat", 4);
            Dog dog1 = new Dog("Pet Dog", 6);

            Console.WriteLine($"{cat1.ScientificName} make a sound: {cat1.MakeSound()}");
            Console.WriteLine($"{dog1.ScientificName} make a sound: {dog1.MakeSound()}");

        }
    }
}
