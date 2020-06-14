using System;

/*
 * Sealed class cannot be inherited and sealed method in C# programming cannot be overridden.
 * If we need to stop a method to be overridden or further extension of a class in inheritance hierarchy,
 * we need to use Sealed method and Sealed class respectively in C# object oriented programming.
 * */
namespace Sealed
{
    //Sealed Class
    sealed class Aclass
    {

    }

    //if we derive B from A we will get
    //compiler error :'B': cannot derive from sealed type 'A'
    /*class B : Aclass
    {
    }*/


// Sealed method:
/*
In below source code example class B will seal the X(), so,
it cannot be overridden / Implemented in class C and class C will use the same X() of class B.
*/
class A
{
    public virtual void X()
    {
        Console.WriteLine("A::X()");
    }
    public virtual void Y()
    {
        Console.WriteLine("A::Y()\n");
    }
}
class B : A
{
    sealed public override void X()
    {
        Console.WriteLine("B::X()");
    }
    public override void Y()
    {
        Console.WriteLine("B::Y()\n");
    }
}
//This C class can not overrid X()
//as it is sealed in B class.

//C will use class B, same X()implementation
//and it cannot implements it's own.

class C : B
{
    //Can not override X function or else
    //compiler error : 'C.X()': cannot override inherited member
    //'B.X()' because it is sealed.


    //sealed public virtual void X()
    //{
    //    Console.WriteLine("B::X()");
    //}
    public override void Y()
    {
        Console.WriteLine("C::Y()");
    }

}
//--------------------TEST------------------------------------
    class SealedClassAndMethodTest
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.X();
            a.Y();

            B b = new B();
            b.X();
            b.Y();

            C c = new C();
            c.X();
            c.Y();

        }
    }
}
