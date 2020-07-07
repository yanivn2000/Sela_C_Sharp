using System;

namespace ToString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Yaniv", 56777, "big heart");

            Console.WriteLine($"Person details get persmission date/time: {person}");

            string myPerson = "Hey" + person;

        }

    }

    class Humen
    {
        public string myheart { get; private set; }
        public Humen(string heart)
        {
            myheart = heart;
        }
        public override string ToString()
        {

            return $"myheart: {myheart}";
        }
    }
    class Person : Humen
    {
        public string myname { get; private set; }
        public int myid { get; private set; }
        public Person(string name, int id, string heart) : base(heart)
        {
            myname = name;
            myid = id;
        }
        public override string ToString()
        {
            
            return $"{base.ToString()}, myname {myname}, myid {myid}";
        }
    }
}
