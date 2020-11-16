using System;
namespace AnimalProject
{
    public class Cat : Mammal
    {
        override public string MakeSound()
        {
            return "Meow";
        }
        public Cat(string scientific_name, int gestation_period) :
            base(scientific_name, gestation_period)
        {

        }
        override public string Move()
        {
            return "Cat step..";
        }
        override public string PrintMe()
        {
            return base.PrintMe() + ":" + "Cat";
        }

        public override string ToString()
        {
            return base.ToString()+ $"Cat: Make Sound: {MakeSound()}, Move: {Move()}";
        }
    }
}
