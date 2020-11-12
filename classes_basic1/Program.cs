using System;

namespace classes_basic1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.SetName("Yaniv");
            if(!person1.SetAge(44))
                Console.WriteLine("Bad age");

            person1.PrintMeWithHeader("Mr.");

            Person person2 = new Person();
            person2.SetName("David");
            if(person2.SetAge(37))
                Console.WriteLine("Bad age");


            person2.PrintMeWithHeader("Mr.");
            person2.PrintYearOfBirth();
        }
    }

    class Person
    {
        private string _name;
        private int _age;

        public void SetName(string name)
        {
            _name = name;
        }
        public bool SetAge(int age)
        {
            if (age < 0)
            {
                _age = 0;
                return false;
            }
            _age = age;
            return true;

        }

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
