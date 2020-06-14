using System;

/*
 * The is operator checks if the result of an expression is compatible with a given type,
 * or (starting with C# 7.0) tests an expression against a pattern.
 * For information about the type-testing is operator see the is operator section of the Type-testing
 * and cast operators article.
 */
namespace IsOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Employee : IComparable
    {
        public String Name { get; set; }
        public int Id { get; set; }

        public int CompareTo(Object o)
        {
            if (o is Employee e)
            {
                return Name.CompareTo(e.Name);
            }
            throw new ArgumentException("o is not an Employee object.");
        }
    }
    /*
     * Without pattern matching, this code might be written as follows.
     * The use of type pattern matching produces more compact, readable code by eliminating the
     * need to test whether the result of a conversion is a null.
     */
    public class Employee2 : IComparable
    {
        public String Name { get; set; }
        public int Id { get; set; }

        public int CompareTo(Object o)
        {
            var e = o as Employee2;
            if (e == null)
            {
                throw new ArgumentException("o is not an Employee object.");
            }
            return Name.CompareTo(e.Name);
        }
    }
    /*
     * The is type pattern also produces more compact code when determining the type of a value type.
     * The following example uses the is type pattern to determine whether an object is a Person or a Dog
     * instance before displaying the value of an appropriate property.
     */
    /*
    public static void ShowValue(object o)
    {
        if (o is Person)
        {
            Person p = (Person)o;
            Console.WriteLine(p.Name);
        }
        else if (o is Dog)
        {
            Dog d = (Dog)o;
            Console.WriteLine(d.Breed);
        }
    }
    */
}

