using System;

//Explicit Interface Implementation


/*
 * If a class implements two interfaces that contain a member with the same signature,
 * then implementing that member on the class will cause both interfaces to use that member as their implementation.
 * In the following example, all the calls to Paint invoke the same method. This first sample defines the types:
 * */

namespace ExplicitInterfaceImplementation
{
    //Implicit method implementation
    public interface IControl
    {
        void Paint();
    }
    public interface ISurface
    {
        void Paint();
    }
    public class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
    //Explicit Method implementation
    public class SampleClassExplicit : IControl, ISurface
    {
        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }
        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }
    //Explicit implementation is also used to resolve cases where two interfaces each declare different members of the
    //same name such as a property and a method. To implement both interfaces, a class has to use explicit implementation
    //either for the property P, or the method P, or both, to avoid a compiler error. For example:
    interface ILeft
    {
        int P { get; }
    }
    interface IRight
    {
        int P();
    }

    class Middle : ILeft, IRight
    {
        public int P() { return 0; }
        int ILeft.P { get { return 0; } }
    }

    /*
     * Beginning with C# 8.0, you can define an implementation for members declared in an interface.
     * If a class inherits a method implementation from an interface, that method is only accessible through a reference of the interface type.
     * The inherited member doesn't appear as part of the public interface. The following sample defines a default implementation for an interface method:
     */
    public interface IControlDefaultImplementation
    {
        //void Paint() => Console.WriteLine("Default Paint method");
    }
    public class SampleClassInheritDefaultImplementation : IControlDefaultImplementation
    {
        // Paint() is inherited from IControl.
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            //Implicit:
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            control.Paint();
            surface.Paint();
            // Output:
            // Paint method in SampleClass
            // Paint method in SampleClass
            // Paint method in SampleClass

            //Explicit
            SampleClassExplicit obj = new SampleClassExplicit();
            //obj.Paint();  // Compiler error.

            IControl c = obj;
            c.Paint();  // Calls IControl.Paint on SampleClass.

            ISurface s = obj;
            s.Paint(); // Calls ISurface.Paint on SampleClass.

            // Output:
            // IControl.Paint
            // ISurface.Paint
        }
    }
}
