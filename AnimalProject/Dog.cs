using System;
namespace AnimalProject
{
    public class Dog : Mammal
    {
        public string MakeSound()
        {
            return "Bark";
        }

        public Dog(string scientific_name, int gestation_period) : base(scientific_name, gestation_period)
        {

        }
    }
}
