using System;
namespace AnimalProject
{
    public class Lion : Mammal
    {
        override public string MakeSound()
        {
            return "Grrr";
        }

        public Lion(string scientific_name, int gestation_period) : base(scientific_name, gestation_period)
        {
        }

        override public string Move()
        {
            return "Lion step..";
        }
        public override string ToString()
        {
            return base.ToString() + $", Lion: Make Sound: {MakeSound()}, Move: {Move()}";
        }
    }
}
