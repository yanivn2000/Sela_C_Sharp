using System;
namespace AnimalProject
{
    public class Animal
    {
        private string _scientificName;
        public string ScientificName { get { return _scientificName; } }

        public Animal(string ScientificName)
        {
            _scientificName = ScientificName;
        }
        virtual public string MakeSound()
        {
            return "";
        }
        virtual public string Move()
        {
            return "Mammal step..";
        }

        virtual public string PrintMe()
        {
            return "Animal";
        }
        public override string ToString()
        {
            return "Animal";
        }
    }
}
