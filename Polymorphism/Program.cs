using System;
using System.Threading;


namespace Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Please enter animal type that you want to create (0,1...or {AnimalsTypes.NONE} to quit): ");
                AnimalsTypes animalType = (AnimalsTypes)int.Parse(Console.ReadLine());
                if (AnimalsTypes.NONE == animalType) break;

                Animal animal = AnimalFactory(animalType);
                StartWorking(animal);
            }
        }

        public static void StartWorking(Animal animal)
        {
            Console.WriteLine("Animal1 sleep 10:");
            animal.Sleep(10);
            Console.WriteLine("Animal1 move 2 right and 5 up");
            animal.Move(2, 5);

        }

        public static Animal AnimalFactory(AnimalsTypes animalsTypes)
        {
            switch (animalsTypes)
            {
                case AnimalsTypes.Tigris:
                    {
                        return new Tigris(uterine_months: 5, max_age: 13, number_of_legs: 4, weight: 40, height: 30);
                    }
                case AnimalsTypes.GermanShepherd:
                    {
                        return new German_Shepherd(uterine_months: 5, max_age: 13, number_of_legs: 4, weight: 40, height: 30);
                    }
            }
            return null;
        }
        public enum AnimalsTypes{
            Tigris,
            GermanShepherd,
            NONE = 100
        }
    }

    abstract class Animal
    {
        int max_age;
        int number_of_legs;
        int weight;
        int height;

        public Animal(int max_age, int number_of_legs, int weight, int height)
        {
            this.max_age = max_age;
            this.number_of_legs = number_of_legs;
            this.weight = weight;
            this.height = height;
        }

        public abstract void Sleep(int time_to_sleep);
        public abstract void Move(int x, int y);
    }

    abstract class Mammal : Animal
    {
        int Uterine_Months;
        public Mammal(int uterine_months, int max_age, int number_of_legs, int weight, int height)
            : base(max_age, number_of_legs, weight, height)
        {
            Uterine_Months = uterine_months;
        }
        public override void Sleep(int time_to_sleep)
        {
            Console.WriteLine("Going to sleep");
            for (int i = 0; i < time_to_sleep; i++)
            {
                Console.Write("Z");
            }
            Console.WriteLine();
            Console.WriteLine("Wakeup");
        }
    }
    abstract class Dog : Mammal
    {
        public Dog(int uterine_months, int max_age, int number_of_legs, int weight, int height)
            : base(uterine_months, max_age, number_of_legs, weight, height)
        {
        }

    }
    class German_Shepherd : Dog
    {
        public German_Shepherd(int uterine_months, int max_age, int number_of_legs, int weight, int height) :
            base(uterine_months, max_age, number_of_legs, weight, height)
        {
        }
        public override void Move(int x, int y)
        {
            Console.WriteLine();
            for (int i = 0; i < x*y; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Step");
            }
            Console.WriteLine("Arrived!");
            Console.WriteLine();
        }
    }
    abstract class Cat : Mammal
    {
        public Cat(int uterine_months, int max_age, int number_of_legs, int weight, int height)
            : base(uterine_months, max_age, number_of_legs, weight, height)
        {
        }
    }
    class Tigris : Cat
    {
        public Tigris(int uterine_months, int max_age, int number_of_legs, int weight, int height) : base(uterine_months, max_age, number_of_legs, weight, height)
        {
        }
        public override void Move(int x, int y)
        {
            Console.WriteLine();
            for (int i = 0; i < x * y; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Step");
            }
            Console.WriteLine("Arrived!");
            Console.WriteLine();
        }
    }
}
