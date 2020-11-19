using System;
namespace AnimalProject
{
    public class Animal
    {
        private string _category;
        public string GetCategory() { return _category; }
        public void SetCategory(string category) { _category = category; }

        private string _scientificName;
        public string ScientificName {
            get { return _scientificName; }
            set { _scientificName = value; }
        }

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
            return "Animal step..";
        }

        public override string ToString()
        {
            return "Animal";
        }
    }
}
