using System;

namespace InterfaceOperators
{
    interface ICanAdd
    {
        int Value { get; }
        //C# interface cannot contain operators because:
        //C# operators have to be static.
        //Interfaces, by definition, apply to instances.
        //There is no mechanism to require a type to implement static members.

        //THEREFORE THIS IS NOT ALLOWED
        //public static int operator +(Add lvalue, int rvalue);

    }

    class Add : ICanAdd
    {
        public int Value => 0;
        public static int operator +(Add lvalue, int rvalue)
        {
            Console.WriteLine("this works in C# 8");
            return lvalue.Value + rvalue;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Add foo = new Add();
            var x = foo + 1;
            Console.WriteLine(x);
        }
    }
}
