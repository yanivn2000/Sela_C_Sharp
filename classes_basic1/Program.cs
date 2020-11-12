using System;

namespace classes_basic1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person[] personArr = new Person[3];
            for (int i = 0; i < personArr.Length; i++)
            {
                Person person = new Person();
                Console.Write("What your name? ");
                person.Name = Console.ReadLine();
                Console.Write("\nHow old are you? ");

                
                while (!person.SetAge(ReadNum()))
                {
                    Console.WriteLine("YOU NEED TO BE WITH A POSITIVE AGE!");
                }
                personArr[i] = person;
            }

            foreach (var person in personArr)
            {
                person.PrintMe();
            }

        }
        public static int ReadNum()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("GIVE ME NUMBER!!");
            }
            return num;
        }
    }

    class Person
    {
        string[] _address;
        private string _name;
        public string Name
        {
            get { return "NAME:" + _name; }
            set { _name = value; }
        }
        private int _age;
        public Person(string name = "DEFAULT", int age = 0, int numOfAddresses = 2)
        {
            _age = 99;
            _name = name;
            _address = new string[numOfAddresses];
            Console.WriteLine("New person was created");
        }
        public Person()
        {
            _age = 99;
            _name = "";
            _address = new string[2];
            Console.WriteLine("New person was created");
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
            Console.WriteLine($"Person details - name: {Name} age: {_age}");
        }
        public void PrintYearOfBirth()
        {
            Console.WriteLine($"Year of birth is {2020 - _age}");
        }
    }
}
