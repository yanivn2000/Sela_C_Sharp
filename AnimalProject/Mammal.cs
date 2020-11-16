using System;
namespace AnimalProject
{
    public class Mammal : Animal
    {
        private int _gestationPeriod;
        public int GestationPeriod { get { return _gestationPeriod; } }

        public Mammal(string scientific_name,  int gestation_period) : base(scientific_name)
        {
            _gestationPeriod = gestation_period;
        }
        override public string PrintMe()
        {
            return base.PrintMe() + ":" + "Mammal";
        }

    }
}
