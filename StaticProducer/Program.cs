using System;

namespace StaticProducer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person1 = PersonProducer.Produce(123);
            Person person2 = PersonProducer.Produce(123);
            Person person3 = PersonProducer.Produce(123);
            Person person4 = PersonProducer.Produce(123);

        }
    }

    public static class PersonProducer
    {
        static int counter;
        static int max = 3;

        public static Person Produce(int id)
        {
            if(counter >= max)
            {
                Console.WriteLine("Number of Persons exceeded");
            }
            else
            {
                Console.WriteLine($"Add a Person, total persons in system {counter}");
                counter++;
                return new Person(id);
            }
            return null;
        }
        public static void KillPerson(Person person)
        {
            person = null;
            counter--;
        }
    }
    public class Person
    {
        int _id;
        public Person(int id)
        {
            _id = id;
        }
    }


}
