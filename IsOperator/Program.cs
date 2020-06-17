using System;

/*
 * The is operator checks if the result of an expression is compatible with a given type,
 * or (starting with C# 7.0) tests an expression against a pattern.
 * For information about the type-testing is operator see the is operator section of the Type-testing
 * and cast operators article.
 */


// taking a class 
public class P { }

// taking a class 
// derived from P 
public class P1 : P { }

// taking a class 
public class P2 { }

namespace IsOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // creating an instance 
            // of class P 
            P o1 = new P();

            // creating an instance 
            // of class P1 
            P1 o2 = new P1();

            // checking whether 'o1' 
            // is of type 'P' 
            Console.WriteLine(o1 is P);

            // checking whether 'o1' is 
            // of type Object class 
            // (Base class for all classes) 
            Console.WriteLine(o1 is Object);

            // checking whether 'o2' 
            // is of type 'P1' 
            Console.WriteLine(o2 is P1);

            // checking whether 'o2' is 
            // of type Object class 
            // (Base class for all classes) 
            Console.WriteLine(o2 is Object);

            // checking whether 'o2' 
            // is of type 'P' 
            // it will return true as P1 
            // is derived from P 
            Console.WriteLine(o2 is P1);

            // checking whether o1 
            // is of type P2 
            // it will return false 
            Console.WriteLine(o1 is P2);

            // checking whether o2 
            // is of type P2 
            // it will return false 
            Console.WriteLine(o2 is P2);
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

