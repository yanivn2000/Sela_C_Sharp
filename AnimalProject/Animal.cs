﻿using System;
namespace AnimalProject
{
    public class Animal
    {
        private string _scientificName;
        protected string ScientificName { get { return _scientificName; } set { _scientificName = value; } }

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
