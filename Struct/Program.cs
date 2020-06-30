using System;

/*
 * A structure type (or struct type) is a value type that can encapsulate data and related functionality.
 * You use the struct keyword to define a structure type:
 * Typically, you use structure types to design small data-centric types that provide little or no behavior
 */

/*
 * Limitation:
 1. You can't declare a parameterless constructor. Every structure type already provides an implicit parameterless constructor that produces the default value of the type
 2. You can't initialize an instance field or property at its declaration. However, you can initialize a static or const field or a static property at its declaration.
 3. A constructor of a structure type must initialize all instance fields of the type.
 4. A structure type can't inherit from other class or structure type and it can't be the base of a class. However, a structure type can implement interfaces.
 5. You can't declare a finalizer within a structure type.
*/

/*More:
 * In C#, you must initialize a declared variable before it can be used. Because a structure-type variable can't be null

 * Passing structure-type variables by reference
   When you pass a structure-type variable to a method as an argument or return a structure-type value from a method,
   the whole instance of a structure type is copied.
   That can affect the performance of your code in high-performance scenarios that involve large structure types.
   You can avoid value copying by passing a structure-type variable by reference.
   Use the ref, out, or in method parameter modifiers to indicate that an argument must be passed by reference.
   Use ref returns to return a method result by reference
 */

namespace Struct
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Coords coords = new Coords(5, 10);
            Console.WriteLine($"{coords}");
        }
    }

// C# 7.2, you use the readonly modifier to declare that a structure type is immutable
//public readonly struct Coords
public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        //You can also apply the readonly modifier to methods that override methods declared in System.Object:
        //and also properties and indexers
        //public readonly override string ToString() => $"({X}, {Y})";
        public override string ToString() => $"({X}, {Y})";
    }
    /*
     * All data members of a readonly struct must be read-only as follows:
        Any field declaration must have the readonly modifier
        Any property, including auto-implemented ones, must be read-only
        That guarantees that no member of a readonly struct modifies the state of the struct.
        //public readonly struct Coords
    */
}
