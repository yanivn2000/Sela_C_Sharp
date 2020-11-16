using System;
namespace AnimalProject
{
    public class Cat : Mammal
    {
        public string MakeSound()
        {
            return "Meow";
        }
        public Cat(string scientific_name, int gestation_period) :
            base(scientific_name, gestation_period)
        {

        }
    }
}
