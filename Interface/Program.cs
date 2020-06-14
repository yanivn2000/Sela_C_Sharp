using System;

/*
 * An interface defines a contract. Any class or struct that implements that contract must
 * provide an implementation of the members defined in the interface.
 * Beginning with C# 8.0, an interface may define a default implementation for members.
 * It may also define static members in order to provide a single implementation for common functionality.
 
 * In the following example, class ImplementationClass must implement a method named SampleMethod that
 * has no parameters and returns void.
 */
namespace Interface
{
    interface ISampleInterfaceV1
    {
        void SampleMethod();
    }
    interface ISampleInterfaceV2
    {
        void SampleMethod();
        int Get9(int num);
    }
    class MainClass: ISampleInterfaceV2
    {
        // Explicit interface member implementation:
        void ISampleInterfaceV2.SampleMethod()
        {
            // Method implementation.
        }
        int ISampleInterfaceV2.Get9(int num)
        {
            return 9;
        }
        static void Main()
        {
            // Declare an interface instance.
            ISampleInterfaceV2 obj = new MainClass();

            // Call the member.
            obj.SampleMethod();
        }
    }
}
