using System;

namespace Params
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Testing Props");
            Test test = new Test();
            test.Name = 30;//assigment FAILED

            Console.WriteLine($"The height is {test.Name}");
        }
    }

    class Test
    {
        private int name; // field
        public int Name   // property
        {
            get { return name; }
            set { name = value + 10; }
        }

        public Test()
        {
            name = 100;
        }
    }

}
