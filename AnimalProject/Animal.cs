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
    }
}
