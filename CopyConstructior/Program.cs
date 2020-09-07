using System;

namespace CopyConstructior
{
    class Person
    {
        // Copy constructor.
        public Person(Person previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }

        //// Alternate copy constructor calls the instance constructor.
        //public Person(Person previousPerson)
        //    : this(previousPerson.Name, previousPerson.Age)
        //{
        //}

        // Instance constructor.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Details()
        {
            return Name + " is " + Age.ToString();
        }
        public virtual Person Duplicate()
        {
            return new Person(this);
        }
    }

    class Child: Person
    {
        public string TeacherName;

        public Child(Child child) : base(child)
        {
            TeacherName = child.TeacherName;
        }

        public Child(string teacherName, string name, int age) : base(name, age)
        {
            TeacherName = teacherName;
        }

        public override Person Duplicate()
        {
            return new Child(this);
        }
    }
    class TestPerson
    {

        public static void foo(int x)
        {
            if (x < 1) return;
            foo(x-1);
        }
        public static void Main(string[] args)
        {

            foo(10);
            // Create a Person object by using the instance constructor.
            Person person1 = new Person("George", 40);

            // Create another Person object, copying person1.
            Person person2 = new Person(person1);

            // Change each person's age.
            person1.Age = 39;
            person2.Age = 41;

            // Change person2's name.
            person2.Name = "Charles";

            // Show details to verify that the name and age fields are distinct.
            Console.WriteLine(person1.Details());
            Console.WriteLine(person2.Details());

            /*** CHILD ***/
            // Create a Person object by using the instance constructor.
            Person child1 = new Child("Yaniv", "George", 40);

            // Create another Person object, copying person1.
            Person child2 = child1.Duplicate();

            // Change each person's age.
            child1.Age = 39;
            child2.Age = 41;

            // Show details to verify that the name and age fields are distinct.
            Console.WriteLine(child1.Details());
            Console.WriteLine(child2.Details());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}


