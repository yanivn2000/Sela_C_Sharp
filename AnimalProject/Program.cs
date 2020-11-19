using System;

namespace AnimalProject
{
    class MainClass
    {

        enum E_ANIMALS
        {
            CAT,
            DOG,
            LION
        }
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];


            animals[(int)E_ANIMALS.CAT] = new Cat("Pet Cat", 4);
            animals[(int)E_ANIMALS.DOG] = new Dog("Pet Dog", 6);
            animals[(int)E_ANIMALS.LION] = new Lion("African Lion", 7);

            Console.Write("Please enter your animal (-1 quit, 0 - Cat, 1 - Dog, 2 - Lion): ");
            E_ANIMALS user_selctor = (E_ANIMALS)(int.Parse(Console.ReadLine()));
            Animal animal;
            switch (user_selctor)
            {
                case E_ANIMALS.CAT:
                    animal = new Cat("Pet Cat", 4);
                    break;
                case E_ANIMALS.DOG:
                    animal = new Cat("Pet Dog", 4);
                    break;
                case E_ANIMALS.LION:
                    animal = new Cat("Pet Lio", 4);
                    break;
                default:
                    break;
            }

            PrintDertails(animals);
        }

        static public void PrintDertails(Animal []animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                //Console.WriteLine(animal.Move());
            }
        }
    }
}
