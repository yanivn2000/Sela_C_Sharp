using System;
using System.Collections.Generic;

namespace ObjectOrientedPartice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object oriented partic");

            Person person1 = new Person("Nuriel", "Yaniv", 30);
            Person person2 = new Person("Nuriel", "Yaniv" );
            Person person3 = new Person("Cohen", "Dany", 40);

            //operator == and !=
            if (person1 == person2)
                Console.WriteLine("Person1 == Person2");
            else
                Console.WriteLine("Person1 != Person2");

            if (person1 != person3)
                Console.WriteLine("Person1 != Person3");
            else
                Console.WriteLine("Person1 == Person3");

            //operator Equals
            if (person1.Equals(person2))
                Console.WriteLine("Person1 Equals Person2");
                else
                    Console.WriteLine("Person1 Not Equals Person2");

            if (person1.Equals(person3))
                Console.WriteLine("Person1 Equals Person3");
            else
                Console.WriteLine("Person1 Not Equals Person3");


            //calling from one constructor to another
            Person person4 = new Person();
            Person person5 = new Person("unknown", "unknown", 30);
            if (person4 == person5)
                Console.WriteLine("Person4 == Person5");
            else
                Console.WriteLine("Person4 != Person5");

            Console.WriteLine($"Number of persons created is: {Person._countPersons}");

            /*
             * Params keyword
             */
            //Params keyword in C# allows a method or a constructor to receive variable number of parameters.
            //When params is used then the compiler converts the arguments passed to a method into a temporary array.
            //This temporary array then can be used in the receiving method to perform some operation on its elements.
            //When using params you can pass a comma - separated list of arguments of the type specified in the method
            //signature or an array of arguments of the specified type. It also gives you the flexibility to send
            //no arguments to the method and in such a case the length of the params list is zero.
            Person person6 = new Person(35, "Dany", "Shovevany");

            //Using params to init Persons
            Persons persons = new Persons(person1, person2, person3, person4, person5);
            persons.insert(person6);
            //Print persons
            Console.WriteLine(persons);

            /*
            //Boxing unboxing
            */
            //Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type.
            //When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.
            //Object instance and stores it on the managed heap.Unboxing extracts the value type from the object.
            //Boxing is implicit; unboxing is explicit.
            //The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type
            //can be treated as an object.
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing

            int i = 123;
            object o = i;  // implicit boxing

            try
            {
                int j = (int)o;  // attempt to unbox - SUCCEED
                //int j = (short)o;  // attempt to unbox - FAILED

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }

            /*
            //Casting and Converting
            */

            //A cast is a way of explicitly informing the compiler
            //that you intend to make the conversion and that you are aware that data loss might occur.
            double x = 1234.7;
            int a;
            // Cast double to int.
            a = (int)x;
            System.Console.WriteLine(a);

            //For reference types, an explicit cast is required if you need to convert from a base type to a derived type:
            // Create a new derived type.  
            /////Giraffe g = new Giraffe();

            // Implicit conversion to base type is safe.  
            /////Animal a = g;

            // Explicit conversion is required to cast back  
            // to derived type. Note: This will compile but will  
            // throw an exception at run time if the right-side  
            // object is not in fact a Giraffe.  
            //////Giraffe g2 = (Giraffe)a;

            Console.WriteLine(person1);
        }
    }
    class Person
    {
        //private properties
        string _fname;//this is private implict
        private string _lname;
        int _age;
        //read only properties
        public int _id { get; private set; }
        //read only static parameter
        public static int _countPersons { get; private set; }

        //CLASS PERSON
        ~Person()
        {
            _countPersons--;
        }

        //Using params parameters
        public Person(int age = 30, params string[] full_name/*must be last*/): this(full_name[0], full_name[1], age)
        {

        }
        public Person(string fname, string lname, int age = 30)
        {
            _fname = fname;
            _lname = lname;
            _age = age;
            _id = ++_countPersons;
        }
        public Person() : this("unknown", "unknown")
        {
        }
        public override string ToString()
        {
            return $"Person id: {_id}, fname: {_fname}, lname: {_lname}, age: {_age}, hashCode: {GetHashCode()}";
        }
        public override bool Equals(object obj)
        {
            Type t = obj.GetType();
            if (t != GetType())
                return false;
            return obj is Person person &&
                   _fname == person._fname &&
                   _lname == person._lname &&
                   _age == person._age;
        }
        //The following example illustrates the MemberwiseClone method. It defines a ShallowCopy method that calls
        //the MemberwiseClone method to perform a shallow copy operation on a Person object.
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        //It also defines a DeepCopy method that performs a deep copy operation on a Person object.

        public override int GetHashCode()
        {
            int hashCode = -1771114887;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_fname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_lname);
            hashCode = hashCode * -1521134295 + _age.GetHashCode();
            return hashCode;
        }
        public static bool operator == (Person obj1, Person obj2)
        {
            return( obj1._fname == obj2._fname &&
                obj1._lname == obj2._lname &&
                obj1._age == obj2._age );
        }
        public static bool operator != (Person obj1, Person obj2)
        {
            return (obj1._fname != obj2._fname ||
                obj1._lname != obj2._lname ||
                obj1._age != obj2._age);
        }
    }

    /// <summary>
    /// CLASS PERSONS
    /// </summary>
    class Persons
    {
        Person[] _persons;

        public Persons()
        {
            _persons = new Person[] { };//create empty array
        }
        public Persons(params Person[] persons)
        {
            _persons = new Person[persons.Length];
            int counter = 0;
            foreach (var person in persons)
            {
                _persons[counter++] = person;
            }
        }
        public override string ToString()
        {
            string persons_str = "";
            foreach (var person in _persons)
            {
                persons_str += $"{person}\n";
            }
            return persons_str;
        }
        public void insert(Person new_person)
        {
            int new_len = _persons.Length + 1;
            Person[] persons_new = new Person[new_len];
            _persons.CopyTo(persons_new, 0);
            persons_new[new_len-1] = new_person;
            _persons = persons_new;

        }
    }
}
