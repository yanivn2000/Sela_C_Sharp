using System;

namespace classes_basic1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1._name = "Yaniv";
            person1._age = 44;

            person1.PrintMeWithHeader("Mr.");

            Person person2 = new Person();
            person2._name = "David";
            person2._age = 37;

            person2.PrintMeWithHeader("Mr.");
            person2.PrintYearOfBirth();
        }
    }

    class Person
    {
        public string _name;
        public int _age;

        public void PrintMe()
        {
            Console.WriteLine($"Person details - name: {_name} age: {_age}");

        }
        public void PrintMeWithHeader(string header)
        {
            Console.WriteLine($"Person details - name: {header} {_name} age: {_age}");
        }
        public void PrintYearOfBirth()
        {
            Console.WriteLine($"Year of birth is {2020 - _age}");
        }
    }
}
