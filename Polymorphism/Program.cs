using System;
using System.Threading;


namespace Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new German_Shepherd(uterine_months: 5, max_age: 13, number_of_legs: 4, weight: 40, height: 30);
            Animal animal2 = new Tigris(uterine_months: 5, max_age: 13, number_of_legs: 4, weight: 40, height: 30);

            Console.WriteLine("Animal1 sleep 10:");
            animal1.Sleep(10);
            Console.WriteLine("Animal2 sleep 20:");
            animal2.Sleep(20);
            Console.WriteLine("Animal1 move 2 right and 5 up");
            animal1.Move(2,5);
            Console.WriteLine("Animal2 move 3 right and 8 up");
            animal2.Move(3,8);

            PrintAnimal(animal1);
        }

        public static void PrintAnimal(Animal animal)
        {

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
        public German_Shepherd(int uterine_months, int max_age, int number_of_legs, int weight, int height) : base(uterine_months, max_age, number_of_legs, weight, height)
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
