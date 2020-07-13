using System;

/*
 * An interface defines a contract. Any class or struct that implements that contract must
 * provide an implementation of the members defined in the interface.
 * Beginning with C# 8.0, an interface may define a default implementation for members.
 * It may also define static members in order to provide a single implementation for common functionality.
 
 * In the following example, class ImplementationClass must implement a method named SampleMethod that
 * has no parameters and returns void.
 *
 * Interface vs Inherit
 * 1. Interface is not inheritance, its mathods are just a contruct and does not "go down" to the child
 * 2. You can not inherit multiple class in C#, while you can get multiple contracts using multiple interfaces
 * 
 */
namespace Interface
{
    interface ISampleInterfaceV1
    {
        void SampleMethod();
    }
    interface ISampleInterfaceV2
    {
        void SampleMethod();    }
    class Sample1: ISampleInterfaceV1
    {
        // Explicit interface member implementation:
        public void SampleMethod()
        {
            Console.WriteLine("Sample1 - This is ISampleInterfaceV1:SampleMethod");
        }
    }
    class Sample2 : ISampleInterfaceV1, ISampleInterfaceV2
    {
        // Explicit interface member implementation:
        void ISampleInterfaceV1.SampleMethod()
        {
            Console.WriteLine("Sample2 - This is ISampleInterfaceV1:SampleMethod");
        }
        void ISampleInterfaceV2.SampleMethod()
        {
            Console.WriteLine("Sample2 - This is ISampleInterfaceV2:SampleMethod");
        }
    }
    class MainClass
    {
        static void Main()
        {
            // Declare an interface instance.
            ISampleInterfaceV1 obj1 = new Sample1();
            DoSomething(obj1);
            // Declare an interface instance.
            obj1 = new Sample2();
            DoSomething(obj1);

            Sample2 obj3 = new Sample2();
            DoSomething(obj3);
            // Call the member.
        }
        static void DoSomething(ISampleInterfaceV2 obj)
        {
            obj.SampleMethod();
        }
        static void DoSomething(ISampleInterfaceV1 obj)
        {
            obj.SampleMethod();
        }
        static void DoSomething(Sample2 obj)
        {
            ((ISampleInterfaceV2)obj).SampleMethod();
        }
    }
}
