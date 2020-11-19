using System;
namespace AnimalProject
{
    public class Dog : Mammal
    {
        override public string MakeSound()
        {
            return "Bark";
        }

        public Dog(string scientific_name, int gestation_period) : base(scientific_name, gestation_period)
        {
        }

        override public string Move()
        {
            return "Dog step..";
        }

        public override string ToString()
        {
            return base.ToString() + $", Dog: Make Sound: {MakeSound()}, Move: {Move()}";
        }
    }
}
